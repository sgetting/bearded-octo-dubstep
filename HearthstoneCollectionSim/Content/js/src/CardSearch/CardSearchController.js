
HearthstoneCollectionApp.service("$dataService", function($http) {
   this.getData = function(callbackFunc) {
      $http.get("Home/Cards").
         success(function(data) {
            callbackFunc(data);
         }).error(function(data, errorMsg) {
            console.log(data + " " + errorMsg);
         });
   };
});

HearthstoneCollectionApp.filter("cardSearchFilter", function() {
      return function(cards, searchString, playerClassName) {
         var filtered = [];
         // for each card in cards
         for (var i = 0; i < cards.length; i++) {
            var card = cards[i];
            if (!card.playerClass)
               card.playerClass = "Neutral";
            if (card.playerClass === playerClassName
               && card.collectible === true
               && (
               // search string matches any of these fields
                  card.name.toLowerCase().search(searchString.toLowerCase()) > -1
                     || card.rarity.toLowerCase() === searchString.toLowerCase()
                     || (card.race && card.race.toLowerCase() === searchString.toLowerCase())
                     // TODO make a set selector
                     //|| (card.setName && card.setName.toLowerCase().search(searchString.toLowerCase()) > -1)
                     || card.type.toLowerCase() === searchString.toLowerCase()
                     || (card.text && card.text.toLowerCase().search(searchString.toLowerCase()) > -1 )
               )) {
               filtered.push(card);
            }
         }
         return filtered;
      };
   }
);

HearthstoneCollectionApp.controller("CardSearchController", [
   "$scope", "$dataService", function($scope, $dataService) {
      $dataService.getData(function(dataResponse) {
         $scope.cardFile = dataResponse;
         $scope.cardsFromFile = angular.fromJson($scope.cardFile);
      });

      //// Return a filter function tuned to each 
      //$scope.filterCards = function(playerClassName, setName, searchString) {
      //   return function(card, index) {
      //      return card.playerClass === playerClassName
      //         && card.setName === setName
      //         && card.collectible === true
      //         && (
      //            // search string present in any of these fields
      //            card.name.search(searchString) > -1
      //               || card.rarity.search(searchString) > -1
      //               || card.race.search(searchString) > -1
      //               || card.type.search(searchString)
      //         );
      //   };
      //};
   }
]);