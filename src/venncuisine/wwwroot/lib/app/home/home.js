vc.controller('vcHome', ['$scope', 'vcAPI', function ($scope, vcAPI) {
    $scope.cuisineIngredients = [];
    $scope.selectedIngredient = {};
    $scope.cuisines = [];
    $scope.selectedCuisine = {};

    vcAPI.getCuisineIngredients.then(function (ci) {
        $scope.cuisineIngredients = ci.data;
    });
    
    vcAPI.getCuisines.then(function (c) {
        $scope.cuisines = c.data;
    });
}]);