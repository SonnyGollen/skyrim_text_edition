using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim___Text_Edition.Items.MagicSpells
{
    public abstract class MagicSpells
    {
        public abstract string Name { get; }

        public abstract int Damage { get; }
    }

    public class Flames : MagicSpells
    {
        public override string Name => "Flames";
        public override int Damage => 8;
    }

    public class Sparks : MagicSpells
    {
        public override string Name => "Sparks";
        public override int Damage => 8;
    }

    public class SomeClass
    {
        public List<MagicSpells> Weapons { get; set; }

        public SomeClass()
        {
            Weapons = new List<MagicSpells> {new Flames(), new Sparks()};

            var badbadbad = Weapons[0].Name + " has caused " + Weapons[1].Damage + " damage";

            var responseConcat = string.Concat(Weapons[0].Name, " has caused ", Weapons[0].Damage, " damage");

            var responseFormat = string.Format("{0} has caused {1} damage", Weapons[0].Name, Weapons[0].Damage);

            Console.WriteLine($"{Weapons[0].Name} has caused {Weapons[0].Damage} damage");
        }
    }
}
