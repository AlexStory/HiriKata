(function () {
    angular.module("hirikata").config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: 'Scripts/app/pages/home.html',
            controller: 'HomeCtrl'
        })
        .when('/register', {
            templateUrl: 'Scripts/app/pages/register.html',
            controller: 'registerCtrl',
            controllerAs: 'regCtrl'
        })
            .when('/login', {
            templateUrl: 'Scripts/app/pages/login.html',
            controller: 'loginCtrl',
            controllerAs: 'logCtrl'
        })
    });
})();