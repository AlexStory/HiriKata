angular.module('hirikata').controller('hiriganaCtrl', function (apiFactory, $scope, $q) {
    $scope.characters = {};

    apiFactory.get('categories', function (data) {
        defer.resolve(data);
    });

    var defer = $q.defer();
    var cards = $('.cards');

    defer.promise
    .then(function (data) {
        $scope.characters = data;
    })
    .then(function () {
        $('.card').draggable({ revert: true });
        $('.board').droppable();
    });
});