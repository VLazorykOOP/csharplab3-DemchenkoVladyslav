using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Product : Detail
    {
        public string Material { get; set; }

        public Product(string name, int weight, string material) : base(name, weight)
        {
            Material = material;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Матеріал: " + Material);
        }
    }
}
