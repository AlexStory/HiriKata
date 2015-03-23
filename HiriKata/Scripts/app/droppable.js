(function () {
    angular.module('hirikata').directive('draggable', function ($location) {
        return function (scope, element) {
            var el = element[0];
            el.draggable = true;

            el.addEventListener(
                'dragstart',
                function (e) {
                    e.dataTransfer.effectAllowed = 'move';
                    e.dataTransfer.setData('Text', this.id);
                    this.classList.add('drag');
                    return false;
                },
                false
            );

            el.addEventListener(
                'dragend',
                function (e) {
                    this.classList.remove('drag');
                    return false;
                },
                false
            );
        }
    });

    angular.module('hirikata').directive('droppable', function ($location) {
        return {
            scope: {},
            link: function (scope, element) {
                // again we need the native object
                var el = element[0];
                
                el.addEventListener(
                'dragover',
                function (e) {
                    e.dataTransfer.dropEffect = 'move';
                    // allows us to drop
                    if (e.preventDefault) e.preventDefault();
                    this.classList.add('over');
                    return false;
                    },
                    false
                );

                el.addEventListener(
                'dragenter',
                function (e) {
                    this.classList.add('over');
                    return false;
                },
                false
                );

                el.addEventListener(
                    'dragleave',
                    function (e) {
                        this.classList.remove('over');
                        return false;
                    },
                    false
                );

                el.addEventListener(
                    'drop',
                    function (e) {
                        // Stops some browsers from redirecting.
                        if (e.stopPropagation) e.stopPropagation();

                        this.classList.remove('over');
                        var selected = e.dataTransfer.getData('Text')
                        scope.$apply($location.path("/hirigana/" + selected ));

                        return false;
                    },
                    false
                );

            }
        }
    });
})();
