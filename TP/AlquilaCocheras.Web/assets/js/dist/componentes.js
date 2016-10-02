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
    }
};
