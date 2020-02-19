angular.module("umbraco").controller("MyWelcomeDashboardController", function (userService) {
    var vm = this;
    vm.title = "Hello, welcome to the Umbraco London Meet Up!!!";

    //inject and use the user service to get the current logged in backoffice user and show it
    userService.getCurrentUser().then(function (user) {
        vm.title = "Welcome " + user.name;
    });
});