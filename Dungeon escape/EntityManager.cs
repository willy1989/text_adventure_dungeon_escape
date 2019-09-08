using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class EntityManager
    {
        public GameManager gameManager;

        public Dictionary<string, Entity> entityDic;

        public void updateEntityDic()
        {
            entityDic.Clear();

            addToDicList(gameManager.inventory.entityContainer.entities);
            addToDicItem(gameManager.inventory);
            addToDicItem(gameManager.currentRoom);

            // If the room is lit, the player can see and interact with all items in the room.
            // Add every entity in the room to entityDic
            if (gameManager.currentRoom.lit == true)
            {
                addToDicList(gameManager.currentRoom.entityContainer.entities);
                // Check if room has a shop
                Shop shop = null;
                foreach (Entity entity in gameManager.currentRoom.entityContainer.entities)
                {
                    if (entity is Shop)
                    {
                        shop = (Shop)entity;
                        gameManager.currentShop = shop;
                    }
                }

                // If so add the shops entities (items to sell) to the entityDic
                if (shop != null)
                {
                    addToDicList(shop.entityContainer.entities);
                }
            }

            // If it is dark, the items in the room are not visible, only the doors are.
            // If the door is not lit, only add the doors to the entityDic. 
            else
            {
                foreach (Entity entity in gameManager.currentRoom.entityContainer.entities)
                {
                    if (entity is Door)
                    {
                        addToDicItem(entity);
                    }
                }
            }
        }

        public void addToDicList(List<Entity> entityList)
        {
                foreach (Entity entity in entityList)
                {
                        entityDic.Add(entity.name, entity);
                }
        }

        public void addToDicItem(Entity entity)
        {
                entityDic.Add(entity.name, entity);
        }

        public EntityManager(GameManager _gameManager)
        {
                gameManager = _gameManager;
                entityDic = new Dictionary<string, Entity>();
        }

    }
}
