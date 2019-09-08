using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class EntityContainer
    {
        public Entity entityContainerOwner;

        public List<Entity> entities = new List<Entity>();

        public EntityContainer(Entity _entityContainerOwner)
        {
            entityContainerOwner = _entityContainerOwner;
        }

        public void AddEntity(Entity entityToAdd)
        {
            entities.Add(entityToAdd);
        }

        public void removeEntitybyName(string entityToRemoveName)
        {
            Entity entityToFind = null;

            // Get entity by name
            foreach (Entity entity in entities)
            {
                if (entity.name == entityToRemoveName)
                {
                    entityToFind = entity;
                    break;
                }
            }

            if (entityToFind == null)
            {
                Console.WriteLine(entityToRemoveName + " not in " + entityContainerOwner.name + ".");
                return;
            }

            // Get position
            int index = entities.IndexOf(entityToFind);

            // Removing the entity from the entity list
            entities.RemoveAt(index);

            // Adding the entity to the current room
            //gameManager.currentRoom.entities.Add(entityToFind);

            //Console.WriteLine(entityToRemoveName + " removed from " + entityContainerOwner.name + ".");
        }

        public bool checkIfInList(string entityToFind)
        {
            foreach (Entity entity in entities)
            {
                if (entityToFind == entity.name)
                {
                    return true;
                }
            }

            Console.WriteLine(entityToFind + " not in " + entityContainerOwner.name + ".");
            return false;
        }

    }
}
