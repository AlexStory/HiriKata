(function () {
    angular.module("hirikata").config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: 'Scripts/app/pages/home.html',
            controller: 'HomeCtrl'
        })
        .when('/register', {
            templateUrl: '../Account/Register',
            controller: 'registerCtrl'
        })
    });
})();