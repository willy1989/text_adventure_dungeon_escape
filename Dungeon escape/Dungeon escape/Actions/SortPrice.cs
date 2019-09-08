using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{ 
     public class SortPrice : Action
     {
        public List<Entity> entityList;

        public override void doAction()
        {

            // Convert the items in the player's inventory to Iprices, so that they can be sorted. 
            // This is because, the Entity base class doesn't have a price variable.
            List<Iprice> iprices = new List<Iprice>();

            foreach (Iprice iprice in entityList)
            {
                iprices.Add(iprice);
            }

            entityList.Clear();

            // Sort by price
            iprices = mergeSplit(iprices);


            // Convert the items back to Entities and store them back in the inventory.
            foreach (Iprice iprice in iprices)
            {
                entityList.Add((Entity)iprice);
                Console.WriteLine(" price = " + iprice.getPriceValue());
            }

        }

        public static List<Iprice> sort2Lists(List<Iprice> list1, List<Iprice> list2)
        {
            List<Iprice> sortedList = new List<Iprice>();

            while (list1.Count > 0 || list2.Count > 0)
            {

                Console.WriteLine("Iterating sort2List");
                if (list1.Count > 0 && list2.Count > 0)
                {
                    if (list1[0].getPriceValue() >= list2[0].getPriceValue())
                    {
                        sortedList.Add(list1[0]);
                        list1.RemoveAt(0);
                    }

                    else if (list1[0].getPriceValue() < list2[0].getPriceValue())
                    {
                        sortedList.Add(list2[0]);
                        list2.RemoveAt(0);
                    }
                }

                else if (list1.Count > 0)
                {
                    sortedList.Add(list1[0]);
                    list1.RemoveAt(0);
                }

                else if (list2.Count > 0)
                {
                    sortedList.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }

            return sortedList;
        }

        public static List<Iprice> mergeSplit(List<Iprice> numList)
        {
            Console.WriteLine("Merge sort");

            if (numList.Count == 1)
            {
                //Console.WriteLine("Array of length 1");
                return numList;
            }

            List<Iprice> left = new List<Iprice>();

            List<Iprice> right = new List<Iprice>();

            bool leftListBool = true;

            while (numList.Count > 0)
            {
                if (leftListBool == true)
                {
                    left.Add(numList[0]);
                }

                else
                {
                    right.Add(numList[0]);
                }

                numList.RemoveAt(0);
                leftListBool = !leftListBool;
            }


            left = mergeSplit(left);

            right = mergeSplit(right);


            return sort2Lists(left, right);
        }

        public SortPrice(List<Entity> _entityList)
        {
            entityList = _entityList;
        }
    }
}
