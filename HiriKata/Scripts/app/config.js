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
        .when('/hirigana', {
            templateUrl: 'Scripts/app/pages/hirigana.html',
            controller: 'hiriganaCtrl',
            controllerAs: 'hiri'
        })
        .when('/hirigana/:id', {
            templateUrl: 'Scripts/app/pages/quiz.html',
            controller: 'quizCtrl'
        })
        .when('/games', {
            templateUrl: 'Scripts/app/pages/games.html',
            controller: 'gamesCtrl'
        });

    });
})();