(function () {
    angular.module('hirikata').controller('HomeCtrl', function ($http, $scope) {
        var vm = this;
        $scope.things = {};
        $http.get('../Api').success(function(data){
            $scope.things = data;
            console.log(data, 'success');
        })
    });
})()