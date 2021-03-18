using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("小狗");
            new People("一号",dog);
            new Monitor("二号",dog);
            dog.Mating();
            dog.Move();
            dog.Woof();
        }
    }
}
