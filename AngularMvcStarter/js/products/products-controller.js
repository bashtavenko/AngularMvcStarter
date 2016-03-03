"use strict";
starterModule.controller("ProductsController", function($scope, productsService) {
    $scope.productName = "Bearing";

    $scope.getProducts = function() {
        productsService.getProducts($scope.productName)
            .$promise.then(
                function(response) {
                    $scope.products = response;
                }
            );
    };
});

