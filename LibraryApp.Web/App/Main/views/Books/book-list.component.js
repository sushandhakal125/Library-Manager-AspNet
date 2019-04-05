(function () {
    "use strict"
    var app = angular.module("app");
    app.component("bookList", {
        templateUrl: "~/App/Main/views/Books/book.cshtml",
        controllerAs: "vm",
        controller: [Controller]
    });
    function Controller() {
        debugger
        var vm = this;
    }
})();