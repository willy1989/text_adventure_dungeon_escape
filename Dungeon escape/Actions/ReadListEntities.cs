using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class ReadListEntities : Action
    {
        public Entity entity;
        public List<Entity> entities;

        public override void doAction()
        {
            if (entities.Count == 0)
            {
                Console.WriteLine("The " + entity.name + " is empty.");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("The " + entity.name + " includes:");

                foreach (Entity entity in entities)
                {
                       Console.WriteLine("  >> "+ entity.name);
                }
            }

        }

        public ReadListEntities(Entity _entity, List<Entity> _entities)
        {
            entity = _entity;
            entities = _entities;
        }
    }
}
