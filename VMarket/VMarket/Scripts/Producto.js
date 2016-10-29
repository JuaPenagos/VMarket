var myApp = angular.module("Producto", []);
myApp.controller("ProductoCtrl", function ($scope, $http) {

    $http.get("getProducts").success(function (data) {
        
        $scope.Products = data;
        
    }).
    error(function (data, status, headers, config) {
    }
    );

    $scope.Product = [];
    $scope.agregarProducto = function (aproducts) {

        console.log("Hola");
        
        
        console.log(aproducts);
        $scope.Product.push(aproducts);
    };

    $scope.getTotal = function () {
        var total = 0;
        for (var i = 0; i < $scope.Product.length; i++) {
            var product = $scope.Product[i];
            total += (product.Precio * product.CantidadReal);
        }
        return total;
    }




    $scope.agregarPersonas = function (personas) {
        console.log("Hola");
        $http({
            traditional: true,
            url: "Personas/Create",
            method: "POST",
            data: JSON.stringify(personas),
            dataType: "json"
        }).success(function (data) {


            alert("insert Success");
            $scope.Personas.push(angular.copy(personas));

        })
    };
    $scope.ObtenerCiudad = function (ciudadId) {
        alert(ciudadId);
        var ciudad = { ciudadID: ciudadId };
        console.log(ciudad);
        $http({
            traditional: true,
            url: "ObtenerCiudad",
            method: "POST",
            data: JSON.stringify(ciudad),
            dataType: "json"
        }).success(function (data) {
            console.log(data);
            $scope.Ciudad = data;
        });

    }

});