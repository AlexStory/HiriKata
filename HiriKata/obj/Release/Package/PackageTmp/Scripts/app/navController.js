(function () {
    angular.module('hirikata').controller('navCtrl', ['$scope', 'accountFactory', function ($scope, accountFactory, $location) {

        $scope.logout = function () {
            accountFactory.logout();
            $location.path('/');

        }
    }]);
})();