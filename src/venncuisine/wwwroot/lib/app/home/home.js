vc.controller('vcHome', ['$scope', 'vcAPI', function ($scope, vcAPI) {
    $scope.cuisineIngredients = [];
    $scope.selectedIngredient = {};
    vcAPI.getCuisineIngredients().then(function (ci) {
        $scope.cuisineIngredients = ci.data;
    });
}]);