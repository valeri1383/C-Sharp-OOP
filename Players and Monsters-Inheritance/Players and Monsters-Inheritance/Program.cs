using Players_and_Monsters_Inheritance.Elfs;
using Players_and_Monsters_Inheritance.Wizard;
using System;

namespace Players_and_Monsters_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MuseElf museelf = new MuseElf("ivan", 5);
            SoulMaster soulmaster = new SoulMaster("bob", 15);

            Console.WriteLine(museelf.ToString()); 
            Console.WriteLine(soulmaster.ToString()); 
        }
    }
}
