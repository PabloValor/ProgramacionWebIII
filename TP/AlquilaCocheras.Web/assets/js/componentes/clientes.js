var Clientes = function() {
    'use strict';

    this.cargar = function() {
        cargarCamposIdReserva();
    }

    function cargarCamposIdReserva() {
        $('.btn-reserva').on('click', function () {
            var idReserva = $(this).data('idreserva');

            $('#hdIdReserva').attr('value', idReserva);
        });
    }
};