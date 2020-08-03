using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace MyCodeAdventure
{
    class Program
    {
        static void Main(string[] args)
        {




            /*TODO 
             *Story
                    /*Basic story line: Starts with the king hiring you, 
                    a great adventurer, to find the lost princess. 
                        *here we can have choices with the king, 
                        *encounters with the people in the square, 
                        *a fight with a drunkerd at the pub*
                    this take you to the time square. through clues discoved 
                    there you are led to the dark enchanted forest of dumblewood. 
                           *here we can have an encpunter with low 
                           *level badies, gain some stats, and loot.*
                    while in the woods you come upon a well know gem cave
                    (tied to the gems the princess had), you now begone your 
                    journey into the cave.
                         *here we can have more choices and battles with low-med enemies*
                    buried deep in the cave is a secret dungeon held by 
                    a group of heritic cult members.
                            *here we can have more battles. here is where the
                            *choices of good and bad can really pick up.*
                    You find the princess in the dungeon and take her out of the 
                    jail cell and return to the king.
                            *here we can have the choice to take her to the king, 
                            *sacrafice her to the dark lord dagon"probably need a dif name to not rip of Skyrim"*

         
                    *same story line (come up iwht a story line)
                    *Dan E. Idea:"You, a great adventurer, come home after a long journey to find the 
                    *princess has been missing for weeks. Being as famous as you are, 
                    *the king employs your help after all his resources seemingly have been exhausted. 
                    *The only clues that you have are a bag of uncut gems that were found hidden in her 
                    *closet and her last known location - the town square. - 
                    *Just an idea for an opener - working on the town square scene."
                        *town
                        *dungeon
                        *quest
                    *class has effects on the story(class effect npc interactions and quest choice)
                    *stats effects on the story line
                            *you have to have certian stats to do sertian things
                            *if your stats are too low you cant do some options
                    *choiced
                           *effects of the choices (see effects)
                    *Objects
                           *weapons (up damage)
                           *potions (heal and boost mana)
                           *Armor (take less damage/ some lowers dex./incumerance?/stamina)
                           *trophies (Helps honor & Charisma)
             *classes
                    *different classes ( honor system effects class. 3 classes per class)
                            (3 honor levels : Knight(good) - citizen(middle 5%) - Heretic(bad))
             
                            *striker
                            *Rouge
                            *Wizard
                            *Monk
                    *different stats
                            *health
                                *effected by damage and potions
                            *strength 
                                *effected by damage and potions
                            *dexterity
                                *effected by specific damage(leg injury) 
                            *intelegence
                                *effected by choices(read book...)
                            *honor
                                *effected by choices
                            *charisma
                                *effected by honor level
                            *mana
                                *effected by intellegence and stamina
                            *stamina
                                *effected by health
                            *virtue 
                                *effected by honor
             *effects
                    *hit/strength points(buffs and boons)
                    *health points
                    *honor points
                    *charisma points
                    *mana points
                    *dexterity points
                    *intellegence points
                    *
               *develop ideas for the enemy and classes(minions and adds vs boss/elite)
             */
            ConsoleLogging.OpenAdventure();
            //Just an idea for an opener -working on the town square scene.

            ConsoleLogging.ChooseCharacter();

            string[] yesOrNo = { "yes", "no" };
            string[] sAttack = { "Light", "A light attack 4-6hp", "Heavy", "A Heavy attack 5-8hp", "Special", "Special attack, powerful but limited use: Charge at the enemy with a furious howl swinging wildly for 10hp to all nearby enemies" };//striker attacks

            ConsoleLogging.CharacterSelected();

        }
    }
}
