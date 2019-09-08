using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class CheckPurseAction : Action
    {
        Inventory inventory;

        public CheckPurseAction(Inventory _inventory)
        {
            inventory = _inventory;
        }

        public override void doAction()
        {
            displayMoney();
        }

        public void displayMoney()
        {
            Console.WriteLine("The purse contains: " +inventory.money + " gold coins.");
        }
    }
}
