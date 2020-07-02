using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure
{
    class Enemies
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


        public Enemies()
        {

        }
        public Enemies(int health, int damage, string type, string threatLeval, string attributes )
        {
            this.Health = health;
            this.Type = type;
            this.ThreatLeval = threatLeval;
            this.Damage = damage;
            this.Attributes = attributes;
        }


    }
}
