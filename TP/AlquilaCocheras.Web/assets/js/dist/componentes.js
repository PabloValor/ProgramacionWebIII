var BaseMaster = function() {
    'use strict';
    this.cargar = function() {
        cargarSidenav();
    }

    function cargarSidenav() {
        $(".button-collapse").sideNav();
    }
};

var LayoutBase = function () {
    'use strict';

    this.cargar = function () {
        $('.modal-trigger').leanModal();

        function initMap(lat, lon) {
            var map = new google.maps.Map(document.getElementById('modal-mapa-contenedor'), {
                center: { lat: lat, lng: lon },
                scrollwheel: false,
                zoom: 11
            });
        };

        $('.btn-modal-mapa').on('click', function() {
            var lat = parseInt($(this).data('latitud'));
            var lon = parseInt($(this).data('longitud'));
            initMap(lat, lon);
        });
    }
};
