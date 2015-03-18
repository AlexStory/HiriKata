(function () {
    angular.module('hirikata').controller('loginCtrl', function ($scope, accountFactory) {
        var vm = this;
        user = {};

        $scope.postForm = function () {
            user.username = vm.username;
            user.password = vm.password;
            user.confirmPassword = vm.confirmPassword;
            accountFactory.login(user);
        }
    });
})();