angular.module("BanjoApp")
    .controller("NodeController", ["$scope", "NodeService",
        function ($scope, NodeService) {

            NodeService.all(function (data) { $scope.nodes = data; });

            $scope.expand = function () {
            }

        }]);