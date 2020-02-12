using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heron_square_root_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Heron's square-root computation method";

            // Declare variables
            double area_of_square = 10.0;
            int number_of_iterations = 10;
            
            Console.WriteLine("\nHeron's square-root computation method");
            Console.WriteLine("======================================\n");

            // Make first guess the area of the square
            double horizontal_side = area_of_square;

            // Now iterate towards better guesses
            for (int this_iteration = 0; this_iteration < number_of_iterations; this_iteration++)
            {
                Console.WriteLine($"This iteration: {this_iteration},  square-root-guess: {horizontal_side}"); // Value going into this iteration
                horizontal_side = update_horizontal_side(area_of_square, horizontal_side);  // Iterative update
            }

            // Write out the final result, and exit.
            Console.WriteLine($"\nThe calculated square root of {area_of_square} from {number_of_iterations} iterations is {horizontal_side}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        static double update_horizontal_side(double area_of_square, double horizontal_side)
        // Carries out one iteration of Heron's algorithm, to improve the guess as to the square root
        // It does this by defining a rectangle with the given area. Since one side of this rectangle will
        // be too short, and the other too long, a better next guess is the average of the two.
        {
            double vertical_side = area_of_square / horizontal_side;
            return (horizontal_side + vertical_side) / 2.0;
        }
    }
}
