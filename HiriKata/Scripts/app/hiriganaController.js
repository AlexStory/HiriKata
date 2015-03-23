angular.module('hirikata').controller('hiriganaCtrl', function (apiFactory, $scope, $location) {
    $scope.characters = {};

    $scope.goToRoute = function(params) {
        $location.path('/hirigana/' + params);
    }

    apiFactory.get('categories', function (data) {
        $scope.characters = data;
    });
});