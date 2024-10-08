using prog2interfaceUpg;
using System;
using System.Security.Cryptography.X509Certificates;

bool active = true;
bool failSafeChoice;
int userChoice = 0;

int width;
int height;

while (active != false)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Ange önskad bredd");
        width = int.Parse(Console.ReadLine());
        Console.WriteLine("\nAnge önskad höjd");
        height = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    catch 
    { 
        Console.WriteLine("Något gick fel, försök igen.");
        continue;
    }

    do
    {
        failSafeChoice = false;
        Console.WriteLine("Vilken form vill du beräkna Area och Omkrets på?");
        Console.WriteLine("1. Cirkel");
        Console.WriteLine("2. Rektangel");
        Console.WriteLine("3. Sfär");
        Console.WriteLine("4. Cylinder");
        Console.WriteLine("5. Triangel");
        Console.WriteLine("\n6. Avsluta programmet");
        try
        {
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        catch
        {
            Console.WriteLine("Något gick fel, försök igen.");
            failSafeChoice = true;
            Console.Clear();
        }
    } while (failSafeChoice != false);

    switch (userChoice)
    {
        case 1:
            IShape circle = new Circle(width);
            Print(circle);
            break;

        case 2:
            IShape rectangle = new Rectan(width, height);
            Print(rectangle);
            break;

        case 3:
            IShape sphere = new Sphere(width);
            Print(sphere);
            break;

        case 4:
            IShape cylinder = new Cylinder(width, height);
            Print(cylinder);
            break;

        case 5:
            IShape triangle = new Triangle(width, height);
            Print(triangle);
            break;

        case 6:
            Console.Clear();
            Console.WriteLine("Programmet avslutas.");
            active = false;
            break;


        default:
            Console.WriteLine("Något gick fel, försök igen");
            break;
    }

}

void Print(IShape shape)
{
    Console.WriteLine("Area: "  + shape.Area() + " area enheter");
    Console.WriteLine("Omkrets: " + shape.Circumferance() + " längd enheter");
    Console.ReadLine();
    Console.Clear();
}

