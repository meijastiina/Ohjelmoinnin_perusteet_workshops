using System;

namespace WS7_6_Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *        A B C D E
             *      1 _ _ _ _ _
             *      2 _ * _ _ _ 
             *      3 _ * _ _ _
             *      4 _ * _ _ _
             *      5 _ _ * * *
             */
            char[,] board = new char[5, 5];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = ' '; // Let's initialise everything empty
                }
            }
            // Let's set the ships
            board[1, 1] = '*';
            board[2, 1] = '*';
            board[3, 1] = '*';
            board[4, 2] = '*';
            board[4, 3] = '*';
            board[4, 4] = '*';
            int numberOfShips = 6;
            int x, y; // Variables for coordinates
            int bodyCount = 0; // Variable for sunk ships
            int shots = 0;

            while (bodyCount < numberOfShips) // Loop for as long as there are ships to sink
            {
                Console.Write("Enter x coordinate: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter y coordinate: ");
                y = int.Parse(Console.ReadLine());

                if (x > 4 || y > 4 )
                {
                    Console.WriteLine("Input out of range. Please enter valid coordinates.");
                    continue;
                }

                if( board[x, y] == '*' )
                {
                    Console.WriteLine("You hit a ship!");
                    board[x, y] = ' '; // Hit -> let's set this to empty
                    bodyCount++; // Let's increase the number of ships hit
                } else
                {
                    Console.WriteLine("Miss!");
                }
                shots++; // Let's increase the number of shots
            }
            Console.WriteLine($"All ships down! You needed { shots } shots.");
        }
    }
}
