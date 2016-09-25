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
