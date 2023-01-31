using System;

namespace newFlooring
{
    class Program
    {
        const double COSTPERHOUR = 22.00;
        const int SQUAREFEETPERHOUR = 20;

        static void Main(string[] args)
        {
            double hourlyCost = COSTPERHOUR;
            IntroMessage();

            int amountOfCorners = UserCorners();

            while (amountOfCorners != 3 && amountOfCorners != 4)
            {
                amountOfCorners = UserCorners();
            }

            double area = 0;
            double costPerUnit = UserCostPerUnit();

            if (amountOfCorners == 3)
            {
                area = AreaOfTriangle();
            }
            if (amountOfCorners == 4)
            {
                area = AreaOfSquare();
            }

            OutputMessage(area);
        }

        static void IntroMessage()
        {
            Console.WriteLine("Hello User, this program can calculate the cost of flooring work when given a few inputs.");
            Console.WriteLine("It can only be used with the following shapes: triangle and rectangle (square/ parallelogram)");
        }

        static void OutputMessage(double area)
        {
            Console.WriteLine("Please enter the cost of labour per hour, if you dont know, an average will be used: ");
            double hourlyCost = Convert.ToInt32(Console.ReadLine());

            if (hourlyCost.Equals(null))
            {
                double cost = area / SQUAREFEETPERHOUR * COSTPERHOUR;
                Console.WriteLine($"The total cost is: {cost}.");
            }
            else
            {
                double cost = area / SQUAREFEETPERHOUR * hourlyCost;
                Console.WriteLine($"The total cost is: {cost}.");
            }
        }

        static int UserCorners()
        {
            Console.WriteLine("Please enter a valid number of corners in the room: ");
            int corners = Convert.ToInt32(Console.ReadLine());
            return corners;
        }

        static double UserCostPerUnit()
        {
            Console.WriteLine("Please enter the cost pr. unit of flooring: ");
            double costPerUnit = Convert.ToDouble(Console.ReadLine());
            return costPerUnit;
        }

        static double AreaOfTriangle()
        {
            Console.WriteLine("Input length of base: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input length of height: ");
            double h = Convert.ToInt32(Console.ReadLine());

            double a = 0.5 * b * h;
            return a;
        }

        static double AreaOfSquare()
        {
            Console.WriteLine("Please enter the width of the floor: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the length of the floor: ");
            double h = Convert.ToInt32(Console.ReadLine());

            double a = b * h;
            return a;
        }
    }
}