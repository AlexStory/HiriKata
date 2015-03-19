(function () {
    angular.module('hirikata').factory('apiFactory', function ($http) {
        var _get = function (params, cb) {
            $http.get('../app/' + params).success(function (data) {
                cb(data);
            });

        }
        return {
            get: _get
        }
    })
})();