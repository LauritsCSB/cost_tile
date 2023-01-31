using System;

namespace newFlooring
{
    class Program
    {
        const double COSTPERHOUR = 86.00;
        const int SQUAREFEETPERHOUR = 20;

        static void Main(string[] args)
        {
            IntroMessage();

            int amountOfCorners = UserCorners();

            while (amountOfCorners != 3 && amountOfCorners != 4)
            {
                Console.WriteLine("That is not a valid input");
                Console.WriteLine("Please enter the number of corners in the room: ");
                amountOfCorners = Convert.ToInt32(Console.ReadLine());
            }

            double costPerUnit = UserCostPerUnit();

            double area = 0;

            if (amountOfCorners == 3)
            {
                Console.WriteLine("Please enter the length of the base: ");
                double baseLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the vertical length from the base: ");
                double vertHeight = Convert.ToInt32(Console.ReadLine());

                area = 0.5 * baseLength * vertHeight;
            }
            if (amountOfCorners == 4)
            {
                Console.WriteLine("Please enter the width of the floor: ");
                double widthLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the length of the floor: ");
                double heightLength = Convert.ToInt32(Console.ReadLine());

                area = widthLength * heightLength;
            }
            double cost = area / SQUAREFEETPERHOUR * COSTPERHOUR;
            Console.WriteLine($"The total cost is: {cost}.");
        }

        static void IntroMessage()
        {
            Console.WriteLine("Hello User, this program can calculate the cost of flooring when given a few inputs.");
            Console.WriteLine("It can only be used with the following two shapes: triangle and rectangle.");
        }

        static int UserCorners()
        {
            Console.WriteLine("Please enter the number of corners in the room: ");
            int corners = Convert.ToInt32(Console.ReadLine());
            return corners;
        }

        static double UserCostPerUnit()
        {
            Console.WriteLine("Please enter the cost pr. unit of flooring: ");
            double costPerUnit = Convert.ToDouble(Console.ReadLine());
            return costPerUnit;
        }
    }
}