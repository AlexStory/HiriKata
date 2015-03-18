(function () {
    angular.module('hirikata').controller('registerCtrl', function ($scope, accountFactory) {
        var vm = this;
        user = {};

        $scope.postForm = function () {
            user.username = vm.username;
            user.password = vm.password;
            user.confirmPassword = vm.confirmPassword;
            accountFactory.register(user);
        }
    });
})();