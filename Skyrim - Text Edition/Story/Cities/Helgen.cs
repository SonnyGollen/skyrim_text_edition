using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim___Text_Edition.Story.Cities
{
    class Helgen : BaseClass
    {
        public void Act1_Unbound()
        {
            Text("I've been captured by the Empire and been sentenced to death alongside Stormcloak rebels. " +
                 "We were being taken to Helgen, but before I could be executed Alduin appeared and attacked the town. " +
                 "I need to find a way out of the town.");
            Text("As the attack creates chaos, a few of us run for the Helgen Keep. Inside we head for the tunnels which lead out of town. " +
                 "While in the safety of the Keep, now would be a good time to prepare for whatever may come.");
            Text("In the Holds inventory I see plenty of weapons, shields, and armours. I also spot what look like mages robes. " +
                 "Do I favour physical or magical attacks? ");
            PlayerInput("1. Select a weapon, sheild, and armour.\n" +
                 "2. Select the mages robes.", 2);
        }
    }
}
