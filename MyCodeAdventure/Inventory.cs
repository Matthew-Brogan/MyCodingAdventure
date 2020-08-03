using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure
{
    public class Inventory
    {
        public static List<string> inventoryList = new List<string>();
        public string Items { get; set; }
        public string Moneys { get; set; }

        public string Armours { get; set; }
        public string Weapons { get; set; }
        public string QuestItems { get; set; }
        
        
        public static void AddToInventory(string items)
        {
            
            inventoryList.Add(items)
        }
    }
    
}
