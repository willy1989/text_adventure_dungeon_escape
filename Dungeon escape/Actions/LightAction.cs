using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class LightAction : Action
    {
        public Lighter lighter;

        public Inventory inventory;

        public GameManager gameManager;

        public LightAction(GameManager _gameManager, Lighter _lighter, Inventory _inventory)
        {
            lighter = _lighter;
            gameManager = _gameManager;
            inventory = _inventory;
        }

        public override void doAction()
        {
            lightRoom();
        }

        public void lightRoom()
        {
            // Check if lighter in inventory
            if (inventory.entityContainer.checkIfInList(lighter.name) == true)
            {
                // light current room
                if (gameManager.currentRoom.lit == false)
                {
                    // Light the room
                    Console.WriteLine("The room is lit");
                    gameManager.currentRoom.lit = true;


                    // Add item description action to room

                    // Change description
                    //gameManager.currentRoom.verbDict["check"].actions[0] = new ActionReadDescription (new Description("A well-lit room"));

                    //gameManager.currentRoom.verbDict["check"].actions.Add(new ReadListEntities(gameManager.currentRoom, gameManager.currentRoom.entityContainer.entities));


                    // Update the current room's description
                    gameManager.currentRoom.description.descriptionContent = " The room is now well lit. You can see everything";
                    gameManager.currentRoom.verbDict["check"].actions.Add(new ReadListItems(gameManager.currentRoom, gameManager.currentRoom.entityContainer));

                    // Reload the current room so that the items within it, which are now visible, can be loaded in the entity manager.

                    gameManager.RoomChange(gameManager.currentRoom);
                   
                }

                // Remove from inventory
                inventory.entityContainer.removeEntitybyName(lighter.name);
            }
        }

        


    }
}
