using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите адрес здания: ");
                string addressBuilding = Console.ReadLine();
                Console.Write("Введите длину здания: ");
                int lengthBuilding = int.Parse(Console.ReadLine());
                Console.Write("Введите ширину здания: ");
                int widthBuilding = int.Parse(Console.ReadLine());
                Console.Write("Введите высоту здания: ");
                int heightBuilding = int.Parse(Console.ReadLine());
                Console.Write("Введите Кол-во этажей в здании: ");
                int floorsBuilding = int.Parse(Console.ReadLine());
                Building building = new Building(addressBuilding, lengthBuilding, widthBuilding, heightBuilding);
                Console.WriteLine(building.Print());
                MultiBuilding multiBuilding = new MultiBuilding(addressBuilding, lengthBuilding, widthBuilding, heightBuilding, floorsBuilding);
                Console.WriteLine(multiBuilding.Print());
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
