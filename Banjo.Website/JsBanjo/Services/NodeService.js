angular.module("BanjoApp")
    .factory("NodeService", ["$http",
        function ($http) {
            return {

                all: function (success) {
                    $http.get("/api/node/all").success(success);
                },

                getRoot: function (success) {
                    $http.get("/api/node/root").success(success);
                },

                getChildren: function (id, success) {
                    $http.get("/api/node/" + id.toString() + "/children").success(success);
                }

            };
        }]);
