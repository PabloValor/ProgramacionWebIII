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
