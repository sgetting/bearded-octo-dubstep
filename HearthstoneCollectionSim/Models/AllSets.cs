using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace HearthstoneCollectionSim.Models
{
   public class AllSets
   {
      public AllSets()
      {
         
      }
      [JsonProperty("Basic")]
      public Card[] Basic;

      [JsonProperty("Credits")]
      public Card[] Credits;

      [JsonProperty("Curse of Naxxramas")]
      public Card[] CurseOfNaxxramas;

      [JsonProperty("Debug")]
      public Card[] Debug;

      [JsonProperty("Expert")]
      public Card[] Expert;

      [JsonProperty("Goblins vs Gnomes")]
      public Card[] GoblinsVsGnomes;

      [JsonProperty("Missions")]
      public Card[] Missions;

      [JsonProperty("Promotion")]
      public Card[] Promotion;

      [JsonProperty("Reward")]
      public Card[] Reward;

      [JsonProperty("System")]
      public Card[] System;
   }
}