using UnaDesk.GeometryLibrary;
using UnaDesk.GeometryLibrary.Geometry2D.Triangle;

namespace ConsoleAppUnaDesk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var tngl1 = new Triangle(new Element(1), new Element(2), new Element(3));

            var type = tngl1.GetTriangleType();
            Console.WriteLine(type + " : " + type.GetDisplayName());


            var typeAngle = tngl1.OneFastMethod();
            Console.WriteLine(typeAngle + " : " + typeAngle.GetDisplayName());

        }
    }
}