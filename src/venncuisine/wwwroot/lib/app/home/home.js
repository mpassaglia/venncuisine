vc.controller('vcHome', ['$scope', 'vcAPI', function ($scope, vcAPI) {
    $scope.cuisineIngredients = [];
    $scope.selectedIngredient = {};
    $scope.cuisines = {
        cuisineList: [],
        selectedCuisine_1: {},
        selectedCuisine_2: {},
        union: []
    };

    vcAPI.getCuisineIngredients.then(function (ci) {
        $scope.cuisineIngredients = ci.data;
    });
    
    vcAPI.getCuisines.then(function (c) {
        $scope.cuisines.cuisineList = c.data;
    });

    $scope.findUnion = function (c1, c2) {
        var obj = {
            first: c1.CuisineId,
            second: c2.CuisineId
        }
        vcAPI.union(obj).then(function (u) {
            $scope.cuisines.union = u.data;
        });
    };
}]);