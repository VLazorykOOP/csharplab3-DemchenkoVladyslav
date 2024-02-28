using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Mechanism : Detail
    {
        public int NumParts { get; set; }

        public Mechanism(string name, int weight, int numParts) : base(name, weight)
        {
            NumParts = numParts;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Кількість частин: " + NumParts);
        }
    }
}
