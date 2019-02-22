using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class MarsRover
    {
        public int XRover { get; set; }
        public int YRover { get; set; }
        public int XRoverMax { get; set; }
        public int YRoverMax { get; set; }
        public int RoverDirection { get; set; }
        //protected char[] Directions = { 'W', 'N', 'E', 'S' }; gereksiz
        public void MoveRover(string MoveString)
        {
            //Console.WriteLine(MoveString[0]);
            //Console.WriteLine(RoverDirection);
            for (int i = 0; i < MoveString.Length; i++)
            {
               if(MoveString[i] == 'L')
                {
                    RoverDirection -= 1;
                    if(RoverDirection < 0) { RoverDirection = 3; }
                }
               else if(MoveString[i] == 'R')
                {
                    RoverDirection += 1;
                    if (RoverDirection > 3) { RoverDirection = 0; }
                }
               else if(MoveString[i] == 'M')
                {
                    switch (RoverDirection)
                    {
                        case 0:
                            if(XRover >= 0)
                                XRover -= 1;
                            break;
                        case 1:
                            if (YRover >= 0)
                                YRover -= 1;
                            break;
                        case 2:
                            if (XRover < XRoverMax)
                                XRover += 1;
                            break;
                        case 3:
                            if(YRover < YRoverMax)
                                YRover += 1;
                            break;
                    }
                }
            }
            if (XRover < 0 ) XRover = 0;
            if (YRover < 0 ) YRover = 0;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Rover'ın x=" + XRover);
            Console.WriteLine("Rover'ın y=" + YRover);
        }
        public char DirectionConverter(int a)
        {
            char drct = 'W';
            switch (a)
            {
                case 0:
                    drct = 'W';
                    break;
                case 1:
                    drct = 'N';
                    break;
                case 2:
                    drct = 'E';
                    break;
                case 3:
                    drct = 'S';
                    break;
            }
            return drct;
        }
        public int DirectionConverter(string a)
        {
            int drct = 0;
            switch (a)
            {
                case "W":
                    drct = 0;
                    break;
                case "N":
                    drct = 1;
                    break;
                case "E":
                    drct = 2;
                    break;
                case "S":
                    drct = 3;
                    break;
            }
            return drct;
        }
    }
}
