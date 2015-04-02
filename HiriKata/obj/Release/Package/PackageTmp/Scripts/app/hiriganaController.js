angular.module('hirikata').controller('hiriganaCtrl', ['apiFactory', '$scope', '$location', '$rootScope', function (apiFactory, $scope, $location, $rootScope) {
    $scope.characters = {};
    $rootScope.section = 'hirigana'

    $scope.goToRoute = function(params) {
        $location.path('/hirigana/' + params);
    }

    apiFactory.get('categories', function (data) {
        $scope.characters = data;
    });
}]);