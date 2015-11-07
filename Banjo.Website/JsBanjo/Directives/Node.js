angular.module("BanjoApp")
    .directive("node", ["RecursionHelper",
        function (RecursionHelper) {

            return {
                restrict: "E",
                scope: {
                    data: "="
                },
                templateUrl: "JsBanjo/Directives/Node.html",


                compile: function(element) {
                    return RecursionHelper.compile(element, function(scope, iElement, iAttrs, controller, transcludeFn){
                        // Define your normal link function here.
                        // Alternative: instead of passing a function,
                        // you can also pass an object with 
                        // a 'pre'- and 'post'-link function.

                        scope.toggle = function () {
                            scope.isExpanded = !scope.isExpanded;
                        }

                    });
                }

                /*link: function (scope, element, attrs) {
                    scope.toggle = function () {
                        scope.isExpanded = !scope.isExpanded;
                        if (scope.isExpanded) {
                            if (scope.data.Children.length == 0) {
                                for (var i = 0; i < 3; i++) {
                                    scope.data.Children.push({
                                        Text: scope.data.Text + "-" + i.toString(),
                                        Children: []
                                    });
                                }
                            }
                        }
                    }
                }*/
            }

        }]);