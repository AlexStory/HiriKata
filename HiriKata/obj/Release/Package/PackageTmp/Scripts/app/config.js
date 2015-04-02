(function () {
    angular.module("hirikata").config(["$routeProvider", function ($routeProvider) {
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
        .when('/katakana/:id', {
            templateUrl: 'Scripts/app/pages/quiz.html',
            controller: 'quizCtrl'
        })
        .when('/katakana', {
            templateUrl: 'Scripts/app/pages/katakana.html',
            controller: 'katakanaCtrl'
        })
        .when('/games', {
            templateUrl: 'Scripts/app/pages/games.html',
            controller: 'gamesCtrl'
        })
        .when('/learn', {
                templateUrl: 'Scripts/app/pages/learn.html'
        });

    }]);
})();