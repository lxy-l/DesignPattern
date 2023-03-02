using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Dog:Subject
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Woof()
        {
            Console.WriteLine(Name+"叫了");
            SetState(0);
        }

        public void Move()
        {
            Console.WriteLine(Name+"移动了");
            SetState(1);
        }

        public void Mating()
        {
            Console.WriteLine(Name+"正在交配中");
            SetState(2);
        }
    }
}
