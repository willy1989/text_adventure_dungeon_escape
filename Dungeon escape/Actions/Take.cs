using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{ 
    public class Take:Action
    {
        public Entity entity;

        public GameManager gameManager;

        public Inventory inventory;

        public override void doAction()
        {
            if (inventory.checkWeightLimit((Iweight)entity) == true && gameManager.currentRoom.entityContainer.checkIfInList(entity.name) == true)
            {
                inventory.add(entity);
                gameManager.currentRoom.entityContainer.removeEntitybyName(entity.name);
            }
        }

        public Take(Entity _entity, Inventory _inventory, GameManager _gameManager)
        {
            entity = _entity;
            gameManager = _gameManager;
            inventory = _inventory;
        }
        
    }
}

