var myApp = angular.module("Producto", []);
myApp.controller("ProductoCtrl", function ($scope, $http) {

    $http.get("../Products/getProducts").success(function (data) {
        
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
    $scope.eliminarProducto = function (aproduct) {
        
        var pos = $scope.Product.indexOf(aproduct);
        $scope.Product.splice(pos);
    }

    $scope.getTotal = function () {
        var total = 0;
        for (var i = 0; i < $scope.Product.length; i++) {
            var product = $scope.Product[i];
            total += (product.Precio * product.CantidadReal);
        }
        return total;
    }
    $scope.getNumeroProductos = function () {
        var Numero = 0;
        Numero = $scope.Products.length;
        return Numero;
    }


   
    $scope.agregarOrden = function (Product) {
        OrderDetails = [{
            OrderDetailId: 1,
            Order: null,
            Product: null,
            Cantidad: 20,
            Subtotal: 0
        }];
        console.log("Hola");
        var orden = {OrderId :0,
            Fecha : 2016-09-16
        };
        
        var obj = $(this);
       
 
        OrderDetails[0].Order = orden;
        OrderDetails[0].ProductId =  $scope.Product[0].ProductId ;
        OrderDetails[0].Cantidad = $scope.Product[0].CantidadReal;
        OrderDetails[0].OrderDetailId = 2;
        OrderDetails[0].Subtotal = $scope.Product[0].Cantidad * $scope.Product[0].Precio

        OrderDetails = { OrderDetails: OrderDetails }
        
        console.log(OrderDetails);
        $http({
            traditional: true,
            contentType: 'application/json; charset=utf-8',
            url: "../OrderDetails/Guardar",
            method: "POST",
            data:  JSON.stringify(OrderDetails),
            dataType: "json"

        }).success(function (data) {
            console.log("Producto Guardado")
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