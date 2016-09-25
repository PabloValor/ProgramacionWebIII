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
        var $header = $('#home-header');
        var $window = $(window);

        header($header, $window);
    }

    function header($header, $window) {
        $header.height($window.height());
    }
};