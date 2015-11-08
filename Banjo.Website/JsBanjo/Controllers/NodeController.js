angular.module("BanjoApp")
    .controller("NodeController", ["$scope", "NodeService",
        function ($scope, NodeService) {

            NodeService.getRoot(function (data) { $scope.root = data; });

            //$scope.expand = function (node) {
            //    NodeService.children(node.NodeId, function (data) { node.children = data; });
            //}

            /*$scope.root = {
                Text: "Root",
                Children: [
                    {
                        Text: "Node 1",
                        Children: [
                            {
                                Text: "Node 1-1",
                                Children: []
                            },
                            {
                                Text: "Node 1-2",
                                Children: []
                            }
                        ]
                    },
                    {
                        Text: "Node 2",
                        Children: []
                    },
                    {
                        Text: "Node 3",
                        Children: []
                    }
                ]
            };*/

        }]);