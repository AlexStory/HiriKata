angular.module('hirikata').controller('katakanaCtrl', function (apiFactory, $scope, $location, $rootScope) {
    $scope.characters = {};
    $rootScope.section = "katakana"

    $scope.goToRoute = function(params) {
        $location.path('/hirigana/' + params);
    }

    apiFactory.get('categories', function (data) {
        $scope.characters = data;
    });
});