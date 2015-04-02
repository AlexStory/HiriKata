(function () {
    angular.module('hirikata').factory('apiFactory', ["$http", function ($http) {
        var _get = function (params, cb) {
            $http.get('../app/' + params).success(function (data) {
                cb(data);
            });

        }

        var _post = function (url, params, cb) {
            $http.post('../app/' + url, params).success(function (data) {
                cb(data);
            });
        }
        return {
            get: _get,
            post: _post
        }
    }]);
})();