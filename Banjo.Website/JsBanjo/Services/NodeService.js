angular.module("BanjoApp")
    .factory("NodeService", ["$http",
        function ($http) {
            return {

                all: function (success) {
                    $http.get("/api/node").success(success);
                }

            };
        }]);
