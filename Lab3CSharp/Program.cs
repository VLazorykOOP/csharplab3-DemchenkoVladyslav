using System.Collections.Immutable;
using System.Text;

namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            //Romb r = new Romb(4, 4, 0);
            //r.DisplayLengths();
            //Console.WriteLine($"Периметр ромба: {r.CalculatePerimeter()}");
            //Console.WriteLine($"Площа ромба: {r.CalculateArea()}");
            //Console.WriteLine($"Чи є ромб квадратом: {r.IsSquare()}");
            //Console.WriteLine($"Колір ромба: {r.Color}");

            Detail detail = new Detail("Болт", 10);
            detail.Show();
            Mechanism mechanism = new Mechanism("Годинник", 100, 50);
            mechanism.Show();
            Product product = new Product("Стіл", 2000, "Дерево");
            product.Show();
            Node node = new Node("Електрод", 5, "Провід");
            node.Show();
            Detail[] arr = { detail, mechanism, product, node };
            foreach (Detail s in arr)
            {
                s.Show();
                Console.WriteLine();
            }
            Array.Sort(arr, (a, b) => { return a.Weight > b.Weight ? 1 : a.Weight == b.Weight ? 0 : -1; });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (Detail s in arr)
            {
                s.Show();
                Console.WriteLine();
            }
        }
    }
}