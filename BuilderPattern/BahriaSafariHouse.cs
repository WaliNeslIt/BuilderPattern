using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BahriaSafariHouse : IHouseBuilder
    {
        House house = new House();
        public House GetHouse()
        {
            return house;
        }

        public bool setFloors(int NumberOfFloors)
        {
            house.floors = NumberOfFloors;
            return true;
        }

        public bool setId(int Id)
        {
            house.Id = Id;
            return true;
        }

        public bool setMarla(float Marla)
        {
            house.MarlaSize = Marla;
            return true;
        }

        public bool setRooms(int NumberOfRooms)
        {
            house.Rooms = NumberOfRooms;
            return true;
        }
    }
}
