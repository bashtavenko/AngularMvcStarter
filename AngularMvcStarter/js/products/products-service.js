"use strict";
starterModule.factory("productsService", function ($resource) {
    return {
        getProducts: function (productName) {
            var params = { productName: productName };
            return $resource("/api/products/:productName", { productName: "@productName" }).query(params);
        }
    };
});

