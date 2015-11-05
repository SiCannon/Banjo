angular.module("BanjoApp")
    .controller("NodeController", ["$scope", "NodeService",
        function ($scope, NodeService) {

            NodeService.root(function (data) { $scope.nodes = data; });

            $scope.expand = function (node) {
                NodeService.children(node.NodeId, function (data) { node.children = data; });
            }

        }]);