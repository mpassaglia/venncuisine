var vc = angular.module('VennCuisine', []);

vc.factory('vcAPI', ['$http', 'urls', function ($http, urls) {
    var vcAPI = {};

    vcAPI.getCuisineIngredients = function () {
        return $http({
            method: 'get',
            url: urls.home + '/GetCuisineIngredients',
            dataType: 'json',
            contentType: 'application/json'
        });
    };

    return vcAPI;
}])