using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();

            Console.WriteLine("Harita için Değer Giriniz");
            string dimensions = Console.ReadLine();

            string[] dimensionsXY = dimensions.Split(' ');
            map.XMax = int.Parse(dimensionsXY[0]);
            map.YMax = int.Parse(dimensionsXY[1]);


            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Harita Boyutu = {map.XMax} x {map.YMax}");




            Console.WriteLine("---------------------------------");
            MarsRover rover = new MarsRover();



            Console.WriteLine("Rover Değerlerini Giriniz");
            string roverLocation = Console.ReadLine();
            string[] roverLocationXYD = roverLocation.Split(' ');
            rover.XRover = int.Parse(roverLocationXYD[0]);
            rover.YRover = int.Parse(roverLocationXYD[1]);
            rover.RoverDirection = rover.DirectionConverter(roverLocationXYD[2]);
            rover.XRoverMax = map.XMax;
            rover.YRoverMax = map.YMax;

            Console.WriteLine("------------------------------");

            Console.WriteLine($"Rover Başlangıç Konumu = {rover.XRover} {rover.YRover} {rover.DirectionConverter(rover.RoverDirection)}");
            Console.WriteLine("--------------");


            Console.WriteLine("---Hareketi Giriniz-------");
            rover.MoveRover(Console.ReadLine());


            Console.ReadLine();

        }
    }
}
