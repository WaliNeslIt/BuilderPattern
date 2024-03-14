using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        public bool setId(int Id);
        public bool setRooms(int NumberOfRooms);
        public bool setFloors(int NumberOfFloors);
        public bool setMarla(float Marla);
        public House GetHouse();
    }
}
