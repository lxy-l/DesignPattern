using System;

namespace MediatorPattern;

/**
     * 
     *  中介者模式：
     *      1.用一个中介对象来封装一系列的对象交互，中介者使各对象不需要显式地相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互。
     *      2.对象与对象之间存在大量的关联关系，这样势必会导致系统的结构变得很复杂，同时若一个对象发生改变，我们也需要跟踪与之相关联的对象，同时做出相应的处理。
     *      3.对象 Colleague 之间的通信封装到一个类中单独处理。
     *      4、降低了类的复杂度，将一对多转化成了一对一、各个类之间的解耦、符合迪米特原则。
     *      5.系统中对象之间存在比较复杂的引用关系，导致它们之间的依赖关系结构混乱而且难以复用该对象。 
     *      6.想通过一个中间类来封装多个类中的行为，而又不想生成太多的子类。
     * **/
class Program
{
    static void Main(string[] args)
    {
        //User user1 = new User("狗");
        //User user2 = new User("猫");

        //user1.SendMsg("HB");
        //user2.SendMsg("HH");

        Component1 component1 = new Component1();
        Component2 component2 = new Component2();
        new ConcreteMediator(component1, component2);

        Console.WriteLine("Client triggets operation A.");
        component1.DoA();

        Console.WriteLine();

        Console.WriteLine("Client triggers operation D.");
        component2.DoD();
    }
}