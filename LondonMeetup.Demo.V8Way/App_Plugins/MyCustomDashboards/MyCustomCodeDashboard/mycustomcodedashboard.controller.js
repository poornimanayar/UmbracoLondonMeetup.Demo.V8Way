function MyCustomCodedashboardController($scope) {

    var vm = this;
    vm.title = "Hello from custom code dashboard!!!";
}
angular.module("umbraco").controller("Umbraco.Dashboard.MyCustomCodedashboardController", MyCustomCodedashboardController);