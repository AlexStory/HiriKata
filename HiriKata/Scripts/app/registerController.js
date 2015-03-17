(function () {
    angular.module('hirikata').controller('registerCtrl', function ($scope, accountFactory) {
        var vm = this;
        vm.message = "hi";
        user = {};

        $scope.postForm = function () {
            user.username = vm.username;
            user.password = vm.password;
            user.confirmPassword = vm.confirmPassword;
            accountFactory.register($scope.newUser, function (data) {
                console.log(data);
            });
        }
    });
})();