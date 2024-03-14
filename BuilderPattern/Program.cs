// See https://aka.ms/new-console-template for more information
using BuilderPattern;



Director _overseaseDirector = new Director(new BahriaOverseaseHouse());

House OverseaseHouse = new House()
{
    Id = 1,
    floors = 2,
    MarlaSize = 10,
    Rooms = 6    
};

_overseaseDirector.constructHouse(OverseaseHouse);
var constructedHouse = _overseaseDirector.getConstructedHouse();

Console.WriteLine("House Id: {0}\nHouse Floors: {1}\nHouse Marla: {2}\nHouse Rooms: {3}",constructedHouse.Id,constructedHouse.floors,constructedHouse.MarlaSize,constructedHouse.Rooms);
Console.ReadLine();