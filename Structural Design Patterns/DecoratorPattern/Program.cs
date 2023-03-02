using System;

namespace DecoratorPattern
{

    /**
     * 
     * 装饰器模式:
     *      1.动态地给一个对象添加一些额外的职责。就增加功能来说，装饰器模式相比生成子类更为灵活。
     *      2.一般的，我们为了扩展一个类经常使用继承方式实现，由于继承为类引入静态特征，并且随着扩展功能的增多，子类会很膨胀
     *      3.装饰类和被装饰类可以独立发展，不会相互耦合，装饰模式是继承的一个替代模式，装饰模式可以动态扩展一个实现类的功能。
     *      4.扩展一个类的功能、动态增加功能，动态撤销。
     * 
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            Car benz = new BenzCar();
            Car bmw = new BMWCar();

            CarDecorator autorun = new AutoCarDecorator(benz);
            CarDecorator flycar = new FlyCarDecorator(bmw);

            autorun.Run();
            flycar.Run();


        }
    }
}
