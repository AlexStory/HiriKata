﻿angular.module('hirikata').controller('hiriganaCtrl', function (apiFactory, $scope, $location, $rootScope) {
    $scope.characters = {};
    $rootScope.section = 'hirigana'

    $scope.goToRoute = function(params) {
        $location.path('/hirigana/' + params);
    }

    apiFactory.get('categories', function (data) {
        $scope.characters = data;
    });
});