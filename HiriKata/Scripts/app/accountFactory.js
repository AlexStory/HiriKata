(function () {
    angular.module('hirikata').factory('accountFactory', function ($http) {
        var _register = function (params, cb) {
            $http.post('../Account/Register', {});
        }

        return {
            register : _register
        }
    });
})();