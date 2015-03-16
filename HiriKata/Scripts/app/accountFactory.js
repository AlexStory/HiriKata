﻿(function () {
    angular.module('hirikata').factory('accountFactory', function ($http) {
        var _register = function (params, cb) {
            $http.post('../Account/Register', params).success(function (data) {
                cb(data)
            });
        }

        return {
            register : _register
        }
    });
})();