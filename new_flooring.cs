//TODO Make user input own area or ask to help calculate.
//TODO Include (almost) all common shapes, use dictionary like slot machine?
//TODO Change ui, dont focus on rooms, but surfaces.
//TODO Use square meter in ui
//TODO User costpersquremeter in calculation

using new_flooring;

namespace newFlooring
{
    class Program
    {
        const double COSTPERHOUR = 22.00;
        const int SQUAREFEETPERHOUR = 20;

        static void Main(string[] args)
        {
            double hourlyCost = COSTPERHOUR;
            double area = 0;
            UIMethods.IntroMessage();

            //Take corners
            int amountOfCorners = UIMethods.AskForCorners();

            while (amountOfCorners != 3 && amountOfCorners != 4)
            {
                amountOfCorners = UIMethods.AskForCorners();
            }

            //Take cost per unit of flooring
            double costPerUnit = UserCostPerUnit();

            if (amountOfCorners == 3)
            {
                area = AreaOfTriangle();
            }
            if (amountOfCorners == 4)
            {
                area = AreaOfSquare();
            }

            OutputMessage(area, hourlyCost, SQUAREFEETPERHOUR);
        }

        /// <summary>
        /// Calculates and prints the total cost to the user after asking if they want an average hourly cost or use their own
        /// </summary>
        /// <param name="area">Area of room</param>
        /// <param name="hourlycost">Labour cost per hour</param>
        /// <param name="squarFeetPerHour">Amount of flooring per hour done by workers</param>
        static void OutputMessage(double area, double costPerHour, int squarFeetPerHour)
        {
            Console.WriteLine("Please enter the cost of labour per hour: ");
            
            if (double.TryParse(Console.ReadLine(), out costPerHour))
            {
                double cost = area / squarFeetPerHour * costPerHour;
                Console.WriteLine($"The total cost is: {cost}.");
            }
            else
            {
                OutputMessage(area, costPerHour, squarFeetPerHour);
            }

        }

        /// <summary>
        /// Asks the user to input the price of a single unit of flooring
        /// </summary>
        /// <returns>User input as integer</returns>
        static double UserCostPerUnit()
        {
            double costPerUnit;
            Console.WriteLine("Please enter the cost pr. unit of flooring: ");
            if (double.TryParse(Console.ReadLine(), out costPerUnit))
            {
                
            }
            else
            {
                UserCostPerUnit();
            }
            return costPerUnit;
        }

        /// <summary>
        /// Asks user for measurements and calculates area
        /// </summary>
        /// <returns>Area as integer</returns>
        static double AreaOfTriangle()
        {
            Console.WriteLine("Input length of base: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input length of height: ");
            double h = Convert.ToInt32(Console.ReadLine());

            double a = 0.5 * b * h;
            return a;
        }

        /// <summary>
        /// Asks user for measurements and calculates area
        /// </summary>
        /// <returns>Area as integer</returns>
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