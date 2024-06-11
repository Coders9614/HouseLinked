using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseLinked
{
    internal class HouseList
    {
        private House head;

        public void AddHouse(int houseId, string address, string type)
        {
            House newHouse = new House(houseId, address, type);
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                House current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHouse;
            }
        }

        public House SearchHouse(int houseId)
        {
            House current = head;
            while (current != null)
            {
                if (current.houseId == houseId)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void DisplayHouseDetails(int houseId)
        {
            House house = SearchHouse(houseId);
            if (house != null)
            {
                Console.WriteLine($"House Number: {house.houseId}");
                Console.WriteLine($"Address: {house.Address}");
                Console.WriteLine($"Type: {house.Type}");
            }
            else
            {
                Console.WriteLine("House not found.");
            }
        }



        public static void Main(string[] args)
        {
            HouseList houseList = new HouseList();
            houseList.AddHouse(1, "1234 Main St", "Ranch");
            houseList.AddHouse(2, "4567 MapleTree Ave", "Apartment");
            houseList.AddHouse(3, "78910 OakTree Dr", "Townhouse");

            Console.WriteLine("Enter house number to search:");
            int houseId = int.Parse(Console.ReadLine());

            houseList.DisplayHouseDetails(houseId);
            Console.ReadKey();
        }
    }
}   

