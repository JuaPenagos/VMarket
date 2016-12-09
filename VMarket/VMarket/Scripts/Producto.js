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
        if ($scope.Product.indexOf(aproducts) == -1)
        {
            $scope.Product.push(aproducts);
        }
       
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
        OrderDetail = {
            OrderDetailId: 1,
            Order: {
                OrderId: null,
                Fecha: null,
                StateId: 1
            },
            Product: null,
            Cantidad: 0,
            Subtotal: 0
        };
        OrderDetails = [];
        console.log("Hola Guardando");        
        var obj = $(this);
        console.log(OrderDetails);
        console.log("Hola Guardando2");
        console.log($scope.Product);
        console.log($scope.Product.length);
        if ($scope.Product.length == 0)
        {
            window.location.reload();
        } else
        {


        for (var i = 0; i < $scope.Product.length; i++) {
            OrderDetail = {
                OrderDetailId: 1,
                Order: {
                    OrderId: null,
                    Fecha: null,
                    StateId: 1
                },
                Product: null,
                Cantidad: 0,
                Subtotal: 0
            };
            console.log($scope.Product[i]);
            OrderDetail.ProductId = $scope.Product[i].ProductId;
            OrderDetail.Cantidad = $scope.Product[i].CantidadReal;
            OrderDetail.OrderDetailId = 2;
            OrderDetail.Subtotal = $scope.Product[i].CantidadReal * $scope.Product[i].Precio
            OrderDetails.push(OrderDetail);
        }
        

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
            
            window.location.href = '../Home'
        })
        }
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