using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HearthstoneCollectionSim.Models
{
   public class CardSet
   {
      public CardSet(string nameOfSet, List<Card> listofCards)
      {
         NameOfSet = nameOfSet;
         ListofCards = listofCards;
      }

      public string NameOfSet {get; private set;}

      public List<Card> ListofCards { get; private set; }

   }

}