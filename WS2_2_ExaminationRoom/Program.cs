using System;

namespace WS2_2_ExaminationRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a program with three double variables; roomHeight, roomWidth and roomLength.
            double roomHeight, roomWidth, roomLength;
            // 2. Set the values of the variables to be 2,80, 4,07 and 3,21.
            roomHeight = 2.80;
            roomLength = 4.07;
            roomWidth = 3.21;
            // 3. Calculate the volume of the room and print it out on the screen.
            Console.WriteLine($"Volume of the room is { roomHeight * roomLength * roomWidth }");
        }
    }
}
