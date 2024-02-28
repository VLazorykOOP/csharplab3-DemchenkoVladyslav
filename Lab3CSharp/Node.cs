using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Node : Detail
    {
        public string Type { get; set; }

        public Node(string name, int weight, string type) : base(name, weight)
        {
            Type = type;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Тип: " + Type);
        }
    }
}
