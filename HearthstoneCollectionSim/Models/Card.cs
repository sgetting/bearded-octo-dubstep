namespace HearthstoneCollectionSim.Models
{
   public class Card
   {
      public Card(string name, int cost, string type, string rarity, string faction, string race,
         string playerClass, string text, string inPlayText, string[] mechanics, string flavor, string artist,
         int attack, int health,
         int durability, string id, bool collectible, bool elite, string howToGet, string howToGetGold)
      {
         Name = name;
         Cost = cost;
         Type = type;
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

      public string Name { get; private set; }
      public int Cost { get; private set; }
      public string Type { get; private set; }
      public string Rarity { get; private set; }
      public string Faction { get; private set; }
      public string Race { get; private set; }
      public string PlayerClass { get; private set; }
      public string Text { get; private set; }
      public string InPlayText { get; private set; }
      public string[] Mechanics { get; private set; }
      public string Flavor { get; private set; }
      public string Artist { get; private set; }
      public int Attack { get; private set; }
      public int Health { get; private set; }
      public int Durability { get; private set; }
      public string Id { get; private set; }
      public bool Collectible { get; private set; }
      public bool Elite { get; private set; }
      public string HowToGet { get; private set; }
      public string HowToGetGold { get; private set; }
   }
}