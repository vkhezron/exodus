using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace exodus
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ExodusStory exodusStory = new ExodusStory();

            List<Plague> plagues = new List<Plague>
            {
                new WaterBlood(),
                new Frogs(),
                new Lice(),
                new FliesOrWildAnimals(),
                new PestilenceOfLivestock.Boils(),
                new PestilenceOfLivestock.ThunderstormOfHailAndFire(),
                new PestilenceOfLivestock.Locusts(),
                new PestilenceOfLivestock.DarknessForThreeDays(),
                new PestilenceOfLivestock.DeathOfTheFirstborn()
            };

            exodusStory.AddPlagues(plagues);

            List<string> allEvents = exodusStory.GetEvents();

            foreach (var eventWithNumber in allEvents.Select((item, index)=> $"{index + 1}. {item}"))
            {
                Console.WriteLine(eventWithNumber);
            }
            Console.WriteLine("\n");

            List<JewishPerson> jewishPeople = new List<JewishPerson>
            {
                new JewishPerson()
                {
                    Name="Moshe",
                    Tribe ="Levi"
                },
                new JewishPerson()
                {
                    Name="Aaron",
                    Tribe="Levi"
                },
                new JewishPerson()
                {
                    Name="Miriam",
                    Tribe="Levi"
                },
                new JewishPerson()
                {
                    Name="Yeshua ben Nun",
                    Tribe="Yehudah"
                },
                new JewishPerson()
                {
                    Name="Peres",
                    Tribe = "Yehudah"
                }
            };

            
            foreach (var jew in jewishPeople)
            {
                jew.Move();
            }
            Console.ReadKey();
        }
        
           
    }
}
