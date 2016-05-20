"use strict";

(function() {
  angular.module("App", [])
    .controller("HelloWorldController", function($scope) {
      $scope.greeting = "Hello World";
    });
})();