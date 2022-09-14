//Area of a Circle

const double pi = 3.14;

//user prompt for radius
Console.WriteLine("Please input RADIUS:");
double radius = Convert.ToDouble(Console.ReadLine());
double CircleArea = (pi * radius * radius);

//output of circle area
Console.WriteLine($"The area of a circle with your radius is {CircleArea}.");
