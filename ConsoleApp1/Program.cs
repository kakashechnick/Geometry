namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tree = new Triangle(10, 50);
            Circle cir = new Circle(12, 57);
            Printer.print(tree);
            Printer.print(cir);
        }
    }
}