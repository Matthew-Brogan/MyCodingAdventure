using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure
{
    public class Enemies
    {
        public static List<Enemies> PunyLevelEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> LowLevelEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> MedLevelEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> HighLevelEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> GodLevelEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> CaveEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> ForestEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> WaterEnemys { get; set; } = new List<Enemies>();
        public static List<Enemies> EventEnemys { get; set; } = new List<Enemies>();


        public int Health { get; set; }
        public string Type { get; set; }
        public string ThreatLeval { get; set; }
        public int Damage { get; set; }
        public string Attributes { get; set; }
        public string Name { get; set; }//do i need this?


        public Enemies()
        {

        }
        public Enemies( int health, int damage, string type, string threatLeval, string attributes )
        {
            this.Health = health;
            this.Type = type;
            this.ThreatLeval = threatLeval;
            this.Damage = damage;
            this.Attributes = attributes;
            
        }
        public static void RandomPunyLeval()
        {
            Random rand = new Random();
           
            for(int i = 0; i < PunyLevelEnemys.Count; i++)
            { 
                Console.WriteLine(PunyLevelEnemys[rand.Next(PunyLevelEnemys)]);
            }
            
        } 
        public void RandomLowLeval()
        {
            Random rand = new Random();
            int index = rand.Next(LowLevelEnemys.Count);
            Console.WriteLine(LowLevelEnemys[index]);
        } 
        public void RandomMedLeval()
        {
            Random rand = new Random();
            int index = rand.Next(MedLevelEnemys.Count);
            Console.WriteLine(MedLevelEnemys[index]);
        }
        public void RandomHighLeval()
        {
            Random rand = new Random();
            int index = rand.Next(HighLevelEnemys.Count);
            Console.WriteLine(HighLevelEnemys[index]);
        }
        public void RandomGodLeval()
        {
            Random rand = new Random();
            int index = rand.Next(GodLevelEnemys.Count);
            Console.WriteLine(GodLevelEnemys[index]);
        }
        public void RandomCaveLeval()
        {
            Random rand = new Random();
            int index = rand.Next(CaveEnemys.Count);
            Console.WriteLine(CaveEnemys[index]);
        }
        public void RandomForestLeval()
        {
            Random rand = new Random();
            int index = rand.Next(ForestEnemys.Count);
            Console.WriteLine(ForestEnemys[index]);
        }
        public void RandomWaterLeval()
        {
            Random rand = new Random();
            int index = rand.Next(WaterEnemys.Count);
            Console.WriteLine(WaterEnemys[index]);
        }
        public void RandomEventLeval()
        {
            Random rand = new Random();
            int index = rand.Next(EventEnemys.Count);
            Console.WriteLine(EventEnemys[index]);
        }

    }
}
