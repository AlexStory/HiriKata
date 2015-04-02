(function () {
    angular.module('hirikata').controller('quizCtrl', ['$scope', '$routeParams', 'apiFactory', '$rootScope', function ($scope, $routeParams, apiFactory, $rootScope) {
        $scope.questions = {};
        $scope.correct = 0;
        $scope.len = 0;
        $scope.possibilities = [];
        $scope.current = [];
        $scope.on = 0;

        apiFactory.get($rootScope.section + '/' + $routeParams.id, function (data) {
            $scope.questions = data;
            $('.start').show();
            $scope.len = data.length;
            data.forEach(function (item) {
                $scope.possibilities.push(item.En);
            });
        });

        $('.start').click(function () {
            $(this).hide();
            $scope.current = getQuestion();
            $('.answers').show();
            getAnswers();
            $scope.$apply();
        });

        $scope.sendAnswer = function (ans) {
            ans == $scope.current[0].En ?  $scope.correct += 1: null;
            $scope.on++;

            if ($scope.questions.length == 0) {                
                $rootScope.user ? createGame() : null;             
                $('.results').show();
                $('.total').hide();
                $('.answers').hide();
                $('.current').hide();
            } else {
                $scope.current = getQuestion();
                getAnswers();
            }
        }

        var getQuestion = function () {
            var num = getRandomSpot();
            var q = $scope.questions.splice(num, 1);
            return q;
        }

        var getAnswers = function () {
            var answers = [];
            var correct = $scope.current[0].En;
            answers.push(correct);
            while (answers.length < 5) {
                var first = $scope.possibilities[Math.floor(Math.random() * $scope.len)];
                if (answers.indexOf(first) == -1) {
                    answers.push(first);
                }
                if (answers.length == 4) {
                    var opts = [0, 1, 2, 3];
                    var newOps = [];
                    for (var i = 4; i > 0; i--) {
                        var num = Math.floor(Math.random() * opts.length);
                        var ans = opts.splice(num, 1);
                        newOps.push(ans[0]);
                    }
                    $scope.a = answers[newOps[0]];
                    $scope.b = answers[newOps[1]];
                    $scope.c = answers[newOps[2]];
                    $scope.d = answers[newOps[3]];
                }

            }
        }

        var addPerfectGame = function(game) {
            apiFactory.post('/perfect', game, function(data) {
                console.log(data);   
            });
        }

        var createGame = function(){
            var game = {
                Section: $scope.current[0].Section,
                Category: $routeParams.id,
                Correct: $scope.correct,
                Possible: $scope.len,
                UserID: $rootScope.user.ID
            }

            apiFactory.post("games", game, function (data) {
                console.log(data);
            });

            game.Possible == game.Correct ? addPerfectGame(game): null;
        }

        var getRandomSpot = function() {
            var num = Math.floor(Math.random() * $scope.questions.length);
            return num;
        }
    }]);

})();