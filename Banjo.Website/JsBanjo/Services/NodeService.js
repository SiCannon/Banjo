angular.module("BanjoApp")
    .factory("NodeService", ["$http",
        function ($http) {
            return {

                all: function (success) {
                    $http.get("/api/node/all").success(success);
                },

                root: function (success) {
                    $http.get("/api/node/root").success(success);
                },

                children: function (id, success) {
                    $http.get("/api/node/" + id.toString() + "/children").success(success);
                }

            };
        }]);
