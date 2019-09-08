using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class GoRoom:Action
    {
        public Door door;

        public GameManager gameManager;

        public override void doAction()
        {
            if (door.unlocked == false)
            {
                Console.WriteLine("You can't go through " + door.name + ". It is locked.");
            }

            else
            {
                Console.WriteLine("You go through " + door.name + ".");
                gameManager.RoomChange(door.connectedRoom);
            }
        }

        public GoRoom(Door _door, GameManager _gameManager)
        {
            door = _door;
            gameManager = _gameManager;
        }

        

    }
}
