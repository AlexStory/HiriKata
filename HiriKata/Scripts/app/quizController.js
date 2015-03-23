(function () {
    angular.module('hirikata').controller('quizCtrl', function ($scope, $routeParams, apiFactory, $rootScope) {
        $scope.questions = {};
        $scope.correct = 0;
        $scope.len = 0;
        $scope.possibilities = [];
        $scope.current = [];
        $scope.on = 0;

        apiFactory.get('category/' + $routeParams.id, function (data) {
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
            if (ans == $scope.current[0].En) {
                $scope.correct += 1;
            }
            $scope.on++;
            if ($scope.questions.length == 0) {
                console.log($scope.current[0].Section)
                var game = {
                    Section: $scope.current[0].Section,
                    Category: $routeParams.id,
                    Correct: $scope.correct,
                    Possible: $scope.len
                }
                if ($rootScope.user) {
                    game.UserID = $rootScope.user.ID;
                    apiFactory.post("games", game, function (data) {
                        console.log(data);
                    });
                }
                console.log(game);
                $('.results').show();
                $('.total').hide();
                $('.answers').hide();
                $('.current').hide();
            } else {
                $scope.current = getQuestion();
                getAnswers();
                //$scope.$apply();
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

        var getRandomSpot = function () {
            var num = Math.floor(Math.random() * $scope.questions.length);
            return num;
        }
    });

})();