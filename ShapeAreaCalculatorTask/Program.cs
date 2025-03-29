namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon

            Console.WriteLine("What do you want to find the area of?:);
            Console.WriteLine("1 - Circle");
            Console.WriteLine("2 - Triangle");
            Console.WriteLine("3 - Rectangle");
            Console.WriteLine("4 - Pentagon");
            Console.WriteLine("5 - Octagon");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("What is the radius of the circle? (in cm please)");
                int radius = Convert.ToInt32(Console.ReadLine());
                double area1 = π*(radius*radius);
                Console.WriteLine("Your area is " + area1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("What is the length of the base of the triangle? (in cm please)");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of the triangle? (in cm please)");
                int height = Convert.ToInt32(Console.ReadLine());
                int area2 = 0.5*length*height;
                Console.WritreLine("Your area is " + area2);
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the width of the rectangle? (in cm please)");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of the rectangle? (in cm please)");
                int length2 = Convert.ToInt32(Console.ReadLine());
                int area3 = length*width;
                Console.WriteLine("Your area is " + area3);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the length of one side of the pentagon? (in cm please)");
                int side = Convert.toInt32(Console.ReadLine());
                Console.WriteLine("What is the distance from one side to the centre of the pentagon? (in cm please)");
                int distance = Convert.toInt32(Console.ReadLine());
                int area4 = 0.5*5*side*distance;
                Console.WriteLine("Your area is " + area4);
            }
            else if (choice == 5)
            {
                Console.WriteLine("What is the length of one of the sides of the octagon? (in cm please)");
                int length3 = Convert.ToInt32(Console.ReadLine());
                int area5 = 2*(1+2^1/2)*(length3*length3);
                Console.WriteLine("Your area is " + area5);
            }
    }
}
