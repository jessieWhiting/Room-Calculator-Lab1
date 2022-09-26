// See https://aka.ms/new-console-template for more information

Console.WriteLine(" Ah, yes, you need the perimeter and area of this classroom taken? I should be able to assist you with that.");
Console.WriteLine(" \n First, please tell me the length of the room.");

string length = Console.ReadLine();



Console.WriteLine("Excellent. The length is " + length + " feet. What is the width of the Room?");
string width = Console.ReadLine();


Console.WriteLine(" Wonderful, the width is " + width + " feet. \n");
Console.WriteLine(" By taking the length and width of the room and multiplying the sum by two... the perimeter equals...");

double perimeter = (double.Parse(width) + double.Parse(length)) * 2;

Console.WriteLine(perimeter + " square feet in total.");
Console.WriteLine(" \n...Now, the area is quite simple as well. Especially since your room is such a perfect rectangle. \n We simply need to mutiply the length by the width.");

double area = double.Parse(width) * double.Parse(length);
Console.WriteLine(" \n This makes the area of your classroom, " + area + " square feet.");

if (area <= 250)
{
    Console.WriteLine(" This is considered a small room.");
}
else if (area <= 650 && perimeter > 250)
{
    Console.WriteLine(" This is considered a Medium room.");
}
else if (area > 650)
{
    Console.WriteLine(" This is considered a Large Room.");
}



Console.WriteLine(" As an added bonus, I will calculate the volume and the surface area of your room for you!...\n please tell me, what is the height of your room? ");
string height = Console.ReadLine();

double volume = double.Parse(width) * double.Parse(length) * double.Parse(height);
double surfaceArea = double.Parse(width) * double.Parse(height);


Console.WriteLine("The volume of your room is " + volume + " feet! and the surface area is " + surfaceArea + " . Good luck on your renovations! ");