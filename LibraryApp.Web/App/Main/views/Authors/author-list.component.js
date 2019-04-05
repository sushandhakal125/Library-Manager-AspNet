(function () {
    "use strict"
    var app = angular.module("app");
    app.component("authorList", {
        templateUrl: "~/App/Main/views/Authors/author.cshtml",
        controllerAs: "vm",
        controller: [Controller]
    });
    function Controller() {
        debugger
        var vm = this;
    }
})();