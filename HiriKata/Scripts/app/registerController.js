(function () {
    angular.module('hirikata').controller('registerCtrl', function ($scope, accountFactory) {
        var vm = this;
        vm.message = "hi";
        user = {};

        $scope.postForm = function () {
            user.Email = vm.Email;
            user.Password = vm.Password;
            user.ConfirmPassword;
            accountFactory.register($scope.newUser, function (data) {
                console.log(data);
            });
        }
    });
})();