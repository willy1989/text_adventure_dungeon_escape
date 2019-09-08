using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Text_adventure
{
    public class GameManager
    {
        public EntityManager entityManager;

        public InputReader inputReader;

        public Inventory inventory;

        public Room currentRoom;

        public Shop currentShop;

        public void gameLoop()
        {
                while (true)
                {
                        inputReader.readInput();
                }
        }

        public void RoomChange(Room nextRoom)
        {
            currentRoom = nextRoom;

            currentShop = null;

            currentRoom.verbDict["check"].execute();

            entityManager.updateEntityDic();
        }

        public GameManager(Inventory _inventory)
        {
            entityManager = new EntityManager(this);
            inventory = _inventory;
        }
    }
}
