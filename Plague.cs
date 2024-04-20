using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exodus
{
    internal class Plague : Event
    {
        public int plagueNumber { get; set; }

        public override void Describe()
        {
            
        }
    }

    internal class WaterBlood : Plague 
    { 
        public WaterBlood()
        {
            Name = "Water turned to blood";
            Description = "All the water in Egypt, including the Nile, turned into blood.";
            plagueNumber = 1;
        }
        public override void Describe()
        {
            Console.WriteLine($"Plague: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Plague Number: {plagueNumber}");
        }
    }

    internal class Frogs : Plague 
    { 
        public Frogs()
        {
            Name = "Frogs";
            Description = "Egypt was overrun by frogs, which came up from the Nile and were found in every household.";
            plagueNumber = 2;
        }
    }

    internal class Lice : Plague
    {
        public Lice()
        {
            Name = "Lice";
            Description = "All the dust in Egypt turned into lice, covering people and animals.";
            plagueNumber = 3;
        }

        public override void Describe()
        {
            Console.WriteLine($"Plague: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Plague Number: {plagueNumber}");
        }
    }

    internal class FliesOrWildAnimals : Plague
    {
        public FliesOrWildAnimals()
        {
            Name = "Flies or wild animals";
            Description = "Egypt was overrun by swarms of flies or wild animals, causing destruction.";
            plagueNumber = 4;
        }

        public override void Describe()
        {
            Console.WriteLine($"Plague: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Plague Number: {plagueNumber}");
        }
    }

    internal class PestilenceOfLivestock : Plague
    {
        public PestilenceOfLivestock()
        {
            Name = "Pestilence of livestock";
            Description = "All the livestock of the Egyptians died from a pestilence, while those of the Israelites remained unharmed.";
            plagueNumber = 5;
        }

        public override void Describe()
        {
            Console.WriteLine($"Plague: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Plague Number: {plagueNumber}");
        }

        internal class Boils : Plague
        {
            public Boils()
            {
                Name = "Boils";
                Description = "Egyptians and their livestock were afflicted with painful boils.";
                plagueNumber = 6;
            }

            public override void Describe()
            {
                Console.WriteLine($"Plague: {Name}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Plague Number: {plagueNumber}");
            }
        }

        internal class ThunderstormOfHailAndFire : Plague
        {
            public ThunderstormOfHailAndFire()
            {
                Name = "Thunderstorm of hail and fire";
                Description = "A devastating thunderstorm accompanied by hail and fire rained down upon Egypt.";
                plagueNumber = 7;
            }

            public override void Describe()
            {
                Console.WriteLine($"Plague: {Name}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Plague Number: {plagueNumber}");
            }
        }

        internal class Locusts : Plague
        {
            public Locusts()
            {
                Name = "Locusts";
                Description = "Egypt was overrun by swarms of locusts, devouring all vegetation.";
                plagueNumber = 8;
            }

            public override void Describe()
            {
                Console.WriteLine($"Plague: {Name}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Plague Number: {plagueNumber}");
            }
        }

        internal class DarknessForThreeDays : Plague
        {
            public DarknessForThreeDays()
            {
                Name = "Darkness for three days";
                Description = "Egypt was enveloped in complete darkness for three days, but the Israelites had light in their dwellings.";
                plagueNumber = 9;
            }

            public override void Describe()
            {
                Console.WriteLine($"Plague: {Name}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Plague Number: {plagueNumber}");
            }
        }

        internal class DeathOfTheFirstborn : Plague
        {
            public DeathOfTheFirstborn()
            {
                Name = "Death of the firstborn";
                Description = "All the firstborn in Egypt, from the Pharaoh's son to the firstborn of the prisoners, were struck dead.";
                plagueNumber = 10;
            }

            public override void Describe()
            {
                Console.WriteLine($"Plague: {Name}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Plague Number: {plagueNumber}");
            }
        }

    }

}
