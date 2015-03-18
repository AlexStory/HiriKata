(function () {
    angular.module('hirikata').factory('accountFactory', function ($http, $rootScope, $location) {
        var _register = function (params) {
            $http.get('../Register?username='+ params.username + "&password=" + params.password).success(function (data) {
                $rootScope.user = data;
            });
       };
     

        var _login = function (params) {
            $http.get('../Register/Login?username=' + params.username + "&password=" + params.password).success(function (data) {
                $rootScope.user = data;
            });
        }

        var _logout = function () {
            $rootScope.user = null;
            $location.path("/");
        }

        return {
            register : _register,
            login : _login,
            logout : _logout
        }
    });
})();