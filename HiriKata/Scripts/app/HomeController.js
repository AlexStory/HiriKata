(function () {
    angular.module('hirikata').controller('HomeCtrl', function ($http, $scope, apiFactory) {
        $scope.things = {};
        apiFactory.get('', function (data) {
            $scope.things = data;
        })
    });
})()