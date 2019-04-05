(function () {
    "use strict"
    var app = angular.module("app");
    app.component("categoryList", {
        templateUrl: "~/App/Main/views/Categories/category.cshtml",
        controllerAs: "vm",
        controller: [Controller]
    });
    function Controller() {
        debugger
        var vm = this;
    }
})();