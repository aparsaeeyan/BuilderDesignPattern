using BuilderDesignPattern;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var director = new SandwichMaker();
        var builder = new Recepie();
        director.Builder = builder;

        Console.WriteLine("Make normal Falafel:");
        director.MakeFalafel();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Make Falafel with salad:");
        director.MakeFalafelWithSalad();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Make Hamburger:");
        director.MakeHamburger();
        Console.WriteLine(builder.GetProduct().ListParts());



        // Remember, the Builder pattern can be used without a Director(SandwichMaker)
        // class.
        Console.WriteLine("Custom Falafel:");
        builder.TakeBread();
        builder.AddMainFood("Falafel");
        builder.AddTopping("Tomato");
        Console.Write(builder.GetProduct().ListParts());
    }
}