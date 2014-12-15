using Newtonsoft.Json;

namespace HearthstoneCollectionSim.Models
{
   public class Card
   {
      public Card(string name, string id, string type, string setName, int? cost = null, string rarity = null, string faction = null, string race = null,
         string playerClass = "Neutral", string text = null, string inPlayText = null, string[] mechanics = null, string flavor = null, string artist = null,
         int? attack = null, int? health = null,
         int? durability = null, bool collectible = false, bool elite = false, string howToGet = null, string howToGetGold = null)
      {
         Name = name;
         Cost = cost;
         Type = type;
         SetName = setName;
         Rarity = rarity;
         Faction = faction;
         Race = race;
         PlayerClass = playerClass;
         Text = text;
         InPlayText = inPlayText;
         Flavor = flavor;
         Mechanics = mechanics;
         Artist = artist;
         Attack = attack;
         Health = health;
         Durability = durability;
         Id = id;
         Collectible = collectible;
         Elite = elite;
         HowToGet = howToGet;
         HowToGetGold = howToGetGold;
      }

      [JsonProperty("name")]
      public string Name { get; private set; }
      [JsonProperty("cost")]
      public int? Cost { get; private set; }
      [JsonProperty("type")]
      public string Type { get; private set; }
      [JsonProperty("rarity")]
      public string Rarity { get; private set; }
      [JsonProperty("faction")]
      public string Faction { get; private set; }
      [JsonProperty("race")]
      public string Race { get; private set; }
      [JsonProperty("playerClass")]
      public string PlayerClass { get; private set; }
      [JsonProperty("text")]
      public string Text { get; private set; }
      [JsonProperty("inPlayText")]
      public string InPlayText { get; private set; }
      [JsonProperty("mechanics")]
      public string[] Mechanics { get; private set; }
      [JsonProperty("flavor")]
      public string Flavor { get; private set; }
      [JsonProperty("artist")]
      public string Artist { get; private set; }
      [JsonProperty("attack")]
      public int? Attack { get; private set; }
      [JsonProperty("health")]
      public int? Health { get; private set; }
      [JsonProperty("durability")]
      public int? Durability { get; private set; }
      [JsonProperty("id")]
      public string Id { get; private set; }
      [JsonProperty("collectible")]
      public bool Collectible { get; private set; }
      [JsonProperty("elite")]
      public bool Elite { get; private set; }
      [JsonProperty("howToGet")]
      public string HowToGet { get; private set; }
      [JsonProperty("howToGetGold")]
      public string HowToGetGold { get; private set; }
      public string SetName { get; set; }
   }
}