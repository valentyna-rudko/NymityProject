var myApp = angular.module('myApp', []);
myApp.controller('MasterDetailCtrl',
    function ($scope, $http) {
        $scope.categories = null;
        //$scope.selectedCategory - null;
        $scope.showDetail = false;

        $http.get("/api/Product/")
            .success(function (data) {
                $scope.categories = data;
            })
            .error(function (data, status, headers, config) {
                $scope.errorMessage = "Couldn't load the list of Categories, error # " + status;
            });

        $scope.selectCategory = function (val) {
            //$scope.selectedCategory = val.CategoryID;
            $scope.loadProducts(val);
        }

        $scope.loadProducts = function (item) {
            //  Reset our list  (when binded, this'll ensure the previous list  disappears from the screen while we're loading our JSON data)
            $scope.products = null;
            $scope.showDetail = false;
            $scope.products = item.Products;
            $scope.showDetail = true;           
        }
});



