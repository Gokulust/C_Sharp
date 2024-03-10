namespace Assessment_1_Area_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            do {
                string shapeChoice;
                Console.WriteLine("***Calculate Area***");
                Console.WriteLine("1.Rectangle");
                Console.WriteLine("2.Square");
                Console.Write("Select the Shape :");
                shapeChoice =Console.ReadLine();
                if (int.TryParse(shapeChoice, out int choice))
                {

                    if (choice == 1) {
                        Console.Write("Enter the length of the Rectangle in meters :");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the breadth of the rectangle in meters :");
                        double breadth = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square();
                        double areaOfRectangle = square.CalculateArea(length, breadth);
                        Console.WriteLine("Area of reactangle is :{0} meter square", areaOfRectangle);
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter the length of the Square in meters : ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square();
                        double areaOfSquare = square.CalculateArea(length);
                        Console.WriteLine("Area of Square is :{0} meter square", areaOfSquare);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Indput!!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input !!");
                }
                Console.WriteLine("Enter 1 to continue or press any key to exit");
                 userChoice=Convert.ToInt32(Console.ReadLine());
            } while (userChoice == 1);

        }
    }
}