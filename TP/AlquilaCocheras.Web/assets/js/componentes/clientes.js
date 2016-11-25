var Clientes = function () {
    'use strict';

    this.cargar = function () {
        cargarCamposIdReserva();
    }

    this.GuardarFechasInicioFinReserva = function () {
        $('.btn-reservar').on('click', function () {
            var fechaInicio = $('#txtFechaInicio')[0].value || false;
            var fechaFin = $('#txtFechaFin')[0].value || false;

            if (fechaInicio && fechaFin) {
                sessionStorage.setItem('fechaInicio', fechaInicio);
                sessionStorage.setItem('fechaFin', fechaFin);
            }

        });
    }

    this.ConfirmarCochera = function () {
        setearFechasInicioFinReserva();
        $('#txtHorarioInicio, #txtHorarioFin, #txtFechaInicio, #txtFechaFin').keyup(bindiarFechasYHorarios);


    }

    function setearFechasInicioFinReserva() {
        $('#txtFechaInicio')[0].value = sessionStorage.getItem('fechaInicio') || "";
        $('#txtFechaFin')[0].value = sessionStorage.getItem('fechaFin') || "";

        sessionStorage.removeItem('fechaInicio');
        sessionStorage.removeItem('fechaFin');
    }

    function bindiarFechasYHorarios() {
        var fechaInicio = $('#txtFechaInicio')[0].value;
        var fechaFin = $('#txtFechaFin')[0].value;
        var horarioInicio = $('#txtHorarioInicio')[0].value;
        var horarioFin = $('#txtHorarioFin')[0].value;

        $('#lblFechaInicio').text('Fecha de inicio: ' + fechaInicio);
        $('#lblFechaFin').text('Fecha de fin: ' + fechaFin);

        $('#lblHoraInicio').text('Horario de inicio: ' + horarioInicio);
        $('#lblHorarioFin').text('Horario de fin: ' + horarioFin);

        calcularPrecioFinal(fechaInicio, fechaFin, horarioInicio, horarioFin);

    }

    function cargarCamposIdReserva() {
        $('.btn-reserva').on('click', function () {
            var idReserva = $(this).data('idreserva');

            $('#hdIdReserva').attr('value', idReserva);
        });
    }

    function calcularPrecioFinal(fechaInicio, fechaFin, horarioInicio, horarioFin) {
        var lblPrecioTotal = $('#lblPrecioTotal');
        var fecha1 = fechaInicio.split('/');
        var horario1 = horarioInicio.split(':');

        var fecha2 = fechaFin.split('/');
        var horario2 = horarioFin.split(':');

        try {

            var date1 = new Date(fecha1[2], fecha1[1], fecha1[0] - 1 , horario1[1], horario1[0], 0, 0);
            var date2 = new Date(fecha2[2], fecha2[1], fecha2[0] - 1, horario2[1] , horario2[0], 0, 0);

            var totalHoras = Math.abs(date1 - date2) / 36e5;;
            var precioPorhora = parseFloat($('#hdPrecioHora')[0].value);
            var precioTotal = totalHoras * precioPorhora || 0;
            lblPrecioTotal.text('Precio total: $' + precioTotal);

        } catch (e) {

        } 
    }
};