(function () {
    angular.module('hirikata').controller('navCtrl', function ($scope, accountFactory) {

        $scope.logout = function () {
            accountFactory.logout();
        }
    });
})();