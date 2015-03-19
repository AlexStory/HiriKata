angular.module('hirikata').controller('hiriganaCtrl', function (apiFactory, $scope) {
    $scope.characters = {};
    apiFactory.get('categories', function (data) {
        $scope.characters = data;
    });
});