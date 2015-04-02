(function () {
    angular.module('hirikata').factory('accountFactory', ["$http", "$rootScope", "$location", function ($http, $rootScope, $location) {
        var _register = function (params) {
            $http.get('../Register?username='+ params.username + "&password=" + params.password).success(function (data) {
                $rootScope.user = data;
                $location.path("/");
            });
       };
     

        var _login = function (params) {
            $http.get('../Register/Login?username=' + params.username + "&password=" + params.password).success(function (data) {
                $rootScope.user = data;
                $location.path("/");
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
    }]);
})();