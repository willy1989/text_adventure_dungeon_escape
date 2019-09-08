using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class UnlockDoorNumPadAction : Action
    {
        public NumPad numPad;

        public Door door;

        public UnlockDoorNumPadAction(NumPad _numPad, Door _door)
        {
            numPad = _numPad;
            door = _door;
        }

        public override void doAction()
        {
            enterPassword();
        }

        public void enterPassword()
        {
            Console.WriteLine("Enter password.");
            // Get password input from the player
            string passW = Console.ReadLine();

            // Unlock door is password is correct
            if (passW == numPad.password)
            {
                Console.WriteLine("Right password.");
                door.unlocked = true;
                Console.WriteLine(door.name + " unlocked.");
            }

            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
    }
}
