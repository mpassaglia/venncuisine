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
                method: 'POST',
                url: baseUrl + '/' + path,
                data: prms,
                dataType: 'json',
                contentType: 'application/x-www-form-urlencoded; charset=utf-8'
            });
        }
    };
}]);
vc.factory('vcAPI', ['urls', '$http', 'vcShared', function (urls, $http, vcShared) {
    var vcAPI = {};

    vcAPI.getCuisineIngredients = vcShared.vcGet(urls.home, 'GetCuisineIngredients');

    vcAPI.getCuisines = vcShared.vcGet(urls.home, 'GetCuisines');

    //var params = new URLSearchParams()
    vcAPI.union = function (obj) {
        return vcShared.vcPost(urls.home, 'FindUnion', obj);
    };

    return vcAPI;
}]);

//vc.config(function ($httpProvider) {
//    $httpProvider.defaults.transformRequest = function (data) {
//        if (data === undefined) {
//            return data;
//        }
//        return $.param(data);
//    }
//});