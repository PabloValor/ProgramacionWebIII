var BaseMaster = function() {
    'use strict';
    this.cargar = function() {
        cargarMascarasInputs();
        cargarSidenav();
        cargarModals();
        cargarCombos();
    }

    function cargarSidenav() {
        $(".button-collapse").sideNav();
    }

    function cargarMascarasInputs() {
        var $inputsFecha = $('input.fecha'),
            $inputsHora = $('input.hora');

          $inputsFecha.mask('00/00/0000');
          $inputsHora.mask('00:00');
    }

    function cargarModals() {
        $('.modal-trigger').leanModal();
    }

    function cargarCombos() {
        $('select').material_select();
    }
};

var Mapas = function () {
    'use strict';

    this.cargar = function () {

        function initMap(lat, lon) {
            var map = new google.maps.Map(document.getElementById('modal-mapa-contenedor'), {
                center: { lat: lat, lng: lon },
                scrollwheel: false,
                zoom: 14
            });
            var marker = new google.maps.Marker({
                position: { lat: lat, lng: lon },
                map: map,
                title: 'Ubicación de cochera'
            });
        };

        $('.btn-modal-mapa').on('click', function() {
            var lat = parseFloat($(this).data('latitud'));
            var lon = parseFloat($(this).data('longitud'));
            initMap(lat, lon);
        });
    }
};

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