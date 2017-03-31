var vc = angular.module('VennCuisine', []);


vc.service('vcShared', ['$http', function ($http) {
    return {
        vcGet: function (baseUrl, path, prms) {
            return $http({
                method: 'get',
                url: baseUrl + '/' + path,
                params: prms || {},
                dataType: 'json',
                contentType: 'application/json'
            });
        },
        vcPost: function (baseUrl, path, prms) {
            return $http({
                traditional: true,
                method: 'POST',
                url: baseUrl + '/' + path,
                data: prms,
                headers: { 'Content-Type': 'application/json' }
            })
        }
    };
}]);
vc.factory('vcAPI', ['urls', 'vcShared', function (urls, vcShared) {
    var vcAPI = {};

    vcAPI.getCuisineIngredients = vcShared.vcGet(urls.home, 'GetCuisineIngredients');

    vcAPI.getCuisines = vcShared.vcGet(urls.home, 'GetCuisines');

    return vcAPI;
}])