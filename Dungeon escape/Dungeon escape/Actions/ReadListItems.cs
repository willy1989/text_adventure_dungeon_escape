using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class ReadListItems : Action
    {
        public Entity entityContainerOwner;

        public EntityContainer entityContainer;

        public override void doAction()
        {
            if (entityContainer.entities.Count == 0)
            {
                Console.WriteLine("The " + entityContainerOwner.name + " is empty.");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("The " + entityContainerOwner.name + " includes:");

                foreach (Entity entity in entityContainer.entities)
                {
                    if (!(entity is Iweight) && !(entity is Iprice))
                    {
                        Console.WriteLine("  >> " + entity.name);
                    }

                    else
                    {
                        Iweight iweight = (Iweight)entity;
                        Iprice iprice = (Iprice)entity;

                        Console.WriteLine("  >> " + entity.name + " price :" + iprice.getPriceValue() + " weight:" + iweight.getWeightValue());
                    }
                }
            }
        }

        public ReadListItems(Entity _entityContainerOwner, EntityContainer _entityContainer)
        {
            entityContainerOwner =_entityContainerOwner;
            entityContainer = _entityContainer;
        }
    }
}
