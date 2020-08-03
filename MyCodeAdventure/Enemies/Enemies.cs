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

        public static void EnemiesList()
        {

            Enemies drunk = new Enemies(1, 1, "human", "very low", "He smells really bad");
            PunyLevelEnemys.Add(drunk);
            Enemies angryGoat = new Enemies(1, 2, "animal", "very low", "You must've done something to his lady goat to make him this mad!");
            PunyLevelEnemys.Add(angryGoat);
            //Low Leval Enemys
            Enemies bandit = new Enemies(3, 4, "human", "low", "They want your loot!");
            LowLevelEnemys.Add(bandit);
            Enemies zombie = new Enemies(2, 6, "undead", "low", "It wants your brains!");
            LowLevelEnemys.Add(zombie);
            Enemies imp = new Enemies(3, 3, "demon", "low", "Its a clever little fool! ");
            LowLevelEnemys.Add(imp);
            Enemies goblin = new Enemies(3, 4, "humanoid", "low", "It want's your gold!");
            LowLevelEnemys.Add(goblin);
            //Medium level enemies
            Enemies soldier = new Enemies(6, 8, "human", "medium", "Has a chip on his shoulder");
            MedLevelEnemys.Add(soldier);
            Enemies hornnedDevil = new Enemies(7, 9, "demon", "medium", "Pretty much just wants you dead.");
            MedLevelEnemys.Add(hornnedDevil);
            Enemies succubus = new Enemies(5, 8, "demon", "medium", "She wants you...dead. Dont fall for it bro.");
            MedLevelEnemys.Add(succubus);
            Enemies orc = new Enemies(8, 8, "humanoid", "medium", "Better watch out. He'll break your bones!.");
            MedLevelEnemys.Add(orc);
            //High level enemies
            Enemies knight = new Enemies(12, 10, "human", "high", "Honor above ALL!!");
            HighLevelEnemys.Add(knight);
            Enemies fireDragon = new Enemies(15, 20, "creature", "high", "He'll make you fried chicken. That is you will be the chicken...");
            HighLevelEnemys.Add(fireDragon);
            Enemies blueDragon = new Enemies(20, 15, "creature", "high", "No fire, but he's got a mean bite!");
            HighLevelEnemys.Add(blueDragon);
            Enemies chainDevil = new Enemies(10, 22, "demon", "high", "I hope you like whips and chains...");
            HighLevelEnemys.Add(chainDevil);
            //god level enemies
            Enemies goldDragon = new Enemies(35, 45, "creature", "very high", "Don't touch his stach. You probably wont live.");
            GodLevelEnemys.Add(goldDragon);
            Enemies leviathan = new Enemies(45, 35, "creature", "very high", "Best start running.");
            GodLevelEnemys.Add(leviathan);
            //Cave enemies
            Enemies vampire = new Enemies(10, 11, "undead", "high", "they want your blood! They also don't sparkle...");
            CaveEnemys.Add(vampire);
            Enemies ghoul = new Enemies(6, 9, "undead", "med", "A less decayed zombie, cool.");
            CaveEnemys.Add(ghoul);
            Enemies giantSpider = new Enemies(7, 8, "insect", "med", "Don't get bit! Poison!");
            CaveEnemys.Add(giantSpider);
            Enemies giantRat = new Enemies(3, 5, "low", "creature", "Hopefully it doesn't have the black plague!");
            CaveEnemys.Add(giantRat);
            Enemies bat = new Enemies(1, 3, "very low", "creature", "Probably has Covid.");
            CaveEnemys.Add(bat);
            Enemies caveTroll = new Enemies(12, 12, "high", "humanoid", "Do you hear the drums?");
            CaveEnemys.Add(caveTroll);
            //Water enemies
            Enemies shark = new Enemies(7, 12, "med", "creature", "Dun Dun....Dun Dun...Dun, Dundundundundun!!");
            WaterEnemys.Add(shark);
            Enemies giantSquid = new Enemies(15, 8, "high", "creature", "It'll squeeze you tell you pop!");
            WaterEnemys.Add(giantSquid);
            //forest enemies
            Enemies fox = new Enemies(1, 2, "very low", "creature", "What does the fox say?");
            ForestEnemys.Add(fox);
            Enemies bear = new Enemies(8, 10, "med", "creature", "Just do better than Leonardo.");
            ForestEnemys.Add(bear);
            Enemies boar = new Enemies(5, 3, "low", "creature", "Oink");
            ForestEnemys.Add(boar);
            Enemies wolf = new Enemies(3, 5, "low", "creature", "Thye travel in packs, watch out.");
            ForestEnemys.Add(wolf);
            Enemies giantFrog = new Enemies(3, 7, "med", "creature", "It has a huge maw!");
            ForestEnemys.Add(giantFrog);
            Enemies unicorn = new Enemies(5, 10, "med", "creature", "Look! A magical skewer!");
            ForestEnemys.Add(unicorn);
            //event enemy   
            Enemies stoneGolum = new Enemies(12, 12, "high", "Construct", "Hes got thicker skin than the clay one...got to find the creator!");
            EventEnemys.Add(stoneGolum);
            Enemies clayGolum = new Enemies(5, 7, "low", "Construct", "Somoen must've made this dude!");
            EventEnemys.Add(clayGolum);
            Enemies evilWizard = new Enemies(8, 15, "med-high", "human", "He is the contoller! Kill em quick before he makes more!");
            EventEnemys.Add(evilWizard);
        }
    }
}
