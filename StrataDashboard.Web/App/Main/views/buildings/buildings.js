(function () {
    var app = angular.module('app');

    var controllerId = 'buildings.list';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.buildingsService',
        function($scope, buildingsService) {
            var vm = this;

            vm.buildings = [];


            abp.ui.setBusy(//Set whole page busy until getTasks complete
                null,
                buildingsService.getAllBuildings().success(function(data) {
                    vm.buildings = data.buildings;
                })
            );
        }
    ]);
})();