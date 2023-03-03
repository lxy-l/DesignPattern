/*
 * 适配器模式
 * 适配器模式是一种结构型设计模式， 它能使接口不兼容的对象能够相互合作。
 */

using AdapterPattern;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());
