var BaseMaster = function() {
    'use strict';
    this.cargar = function() {
        cargarMascarasInputs();
        cargarSidenav();
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
};
