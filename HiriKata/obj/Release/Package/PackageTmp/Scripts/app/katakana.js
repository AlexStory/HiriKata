angular.module('hirikata').controller('katakanaCtrl', ['apiFactory', '$scope', '$location', '$rootScope', function (apiFactory, $scope, $location, $rootScope) {
    $scope.characters = {};
    $rootScope.section = "katakana"

    $scope.goToRoute = function(params) {
        $location.path('/hirigana/' + params);
    }

    apiFactory.get('categories', function (data) {
        $scope.characters = data;
    });
}]);