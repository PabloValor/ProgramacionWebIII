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
