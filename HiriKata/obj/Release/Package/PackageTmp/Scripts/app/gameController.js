(function () {
    angular.module('hirikata').controller('gamesCtrl',['apiFactory', '$scope', '$rootScope',  function (apiFactory, $scope, $rootScope) {
        $scope.games = [];
        apiFactory.get('/games/' + $rootScope.user.ID, function (data) {
            $scope.games = data;
        });
    }]);

})();