using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class UnlockDoorAction : Action
    {
        public Inventory inventory;

        public Door door;

        public UnlockDoorAction(Door _door, Inventory _inventory)
        {
            door = _door;
            inventory = _inventory;
        }

        public override void doAction()
        {
            unlockDoor();
        }

        public void unlockDoor()
        {
            // Check if door unlocked
            if (door.unlocked == false)
            {
                // check if the inventory contains a key
                if (inventory.entityContainer.checkIfInList("key"))
                {
                    // Remove key from inventory
                    inventory.entityContainer.removeEntitybyName("key");

                    // Open door
                    door.unlocked = true;
                    Console.WriteLine(door.name + " unlocked.");
                }

                else
                {
                    Console.WriteLine("You can't open " + door.name + " you are missing a key.");
                }
            }

            else
            {
                Console.WriteLine(door.name + " already unlocked.");
            }
        }
    }
}
