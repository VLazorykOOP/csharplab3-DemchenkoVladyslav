using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    public class Detail
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Detail(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public virtual void Show()
        {
            Console.WriteLine("Назва: " + Name);
            Console.WriteLine("Вага: " + Weight + " г");
        }
    }
}
