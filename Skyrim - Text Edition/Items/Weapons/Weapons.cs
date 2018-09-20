using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim___Text_Edition.Items.Weapons
{
    public abstract class Weapon
    {
        public abstract string Name { get; }

        public abstract int Damage { get; }
    }

    public class Sword : Weapon
    {
        public override string Name => "Iron Sword";
        public override int Damage => 7;

    }

    public class Club : Weapon
    {
        public override string Name => "Club";
    
        public override int Damage => 5;
    }

    public class SomeClass
    {
        public List<Weapon> Weapons { get; set; }

        public SomeClass()
        {
            Weapons = new List<Weapon> {new Club(), new Sword()};

            var badbadbad = Weapons[0].Name + " has caused " + Weapons[1].Damage + " damage";

            var responseConcat = string.Concat(Weapons[0].Name, " has caused ", Weapons[0].Damage, " damage");

            var responseFormat = string.Format("{0} has caused {1} damage", Weapons[0].Name, Weapons[0].Damage);

            Console.WriteLine($"{Weapons[0].Name} has caused {Weapons[0].Damage} damage");
        }
    }
}
