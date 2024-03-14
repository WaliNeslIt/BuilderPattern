using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        private readonly IHouseBuilder _houseBuilder;
        public Director(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void constructHouse(House house)
        {
            _houseBuilder.setId(house.Id);
            _houseBuilder.setRooms(house.Rooms);
            _houseBuilder.setFloors(house.floors);
            _houseBuilder.setMarla(house.MarlaSize);
        }

        public House getConstructedHouse()
        {
            return _houseBuilder.GetHouse();
        }

    }
}
