(function () {
    angular.module('hirikata').factory('accountFactory', function ($http) {
        var _register = function (params, cb) {
            $http.post('../api/account/register', params).success(function (data) {
                _login(params, function (data) {
                    cb(data);
                })
            });
        }

        var _login = function (params, cb) {
            $http.post('../api/account/login', params).success(function (data) {
                cb(data)
            });
        }

        return {
            register: _register,
            login: _login
        }
    });
})();