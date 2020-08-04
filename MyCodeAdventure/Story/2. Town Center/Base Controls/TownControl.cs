using MyCodeAdventure.Story.Base_Story;
using MyCodeAdventure.Story.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story
{
    public static class TownControl
    {
        public static void TownSwitch()
        {
            string decision1 = Console.ReadLine();
            switch (decision1)
            {
                case "1":
                    PubChoices.PubCase1();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    TownSwitch();
                    break;
                case "2":
                    MarketChoices.MarketCase2();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    TownSwitch();
                    break;

                case "3":
                    ChurchChoices.ChurchScene();
                    TownSwitch();
                    break;

                default:
                    Utilities.ExitTown();
                    break;



            }

        }
       
      
    }
 }

