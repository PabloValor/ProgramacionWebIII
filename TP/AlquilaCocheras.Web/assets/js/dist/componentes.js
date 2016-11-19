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
        };

        $('.btn-modal-mapa').on('click', function() {
            var lat = parseInt($(this).data('latitud'));
            var lon = parseInt($(this).data('longitud'));
            initMap(lat, lon);
        });
    }
};
