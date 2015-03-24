(function () {
    angular.module('hirikata').controller('gamesCtrl', function (apiFactory, $scope, $rootScope) {
        $scope.games = [];
        apiFactory.get('perfect/' + $rootScope.user.ID, function (data) {
            $scope.games = data;
        });
    });

})();