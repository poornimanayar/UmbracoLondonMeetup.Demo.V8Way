 //angular
 //       .module('umbraco')
 //       .component('My.PropertyEditor',
 //           {
 //               templateUrl: '/App_Plugins/MyPropertyEditor/view.html',
 //               controller: MyPropertyEditorController,
 //               controllerAs: 'vm',
 //               require: {
 //                   umbProperty: '?^umbProperty'
 //               }
 //           });


function MyPropertyEditorController($scope) {
    function removeAllEntries() {
        console.log('here');
    }

    var removeAllEntriesAction = {
        labelKey: 'MyPropertyEditor_labelForMyAction',
        labelTokens: [],
        icon: 'trash',
        method: removeAllEntries,
        isDisabled: false
    };


    var propertyActions = [
        removeAllEntriesAction
    ];

    if ($scope.umbProperty) {
        $scope.umbProperty.setPropertyActions(propertyActions);
    }

}

angular.module("umbraco").controller("MyPropertyEditorController", MyPropertyEditorController);