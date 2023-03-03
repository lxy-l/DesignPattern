/*
 * 桥接模式
 * 桥接是一种结构型设计模式， 可将业务逻辑或一个大类拆分为不同的层次结构， 从而能独立地进行开发。
 */


using BridgePattern;

Client client = new Client();

Abstraction abstraction;
// The client code should be able to work with any pre-configured
// abstraction-implementation combination.
abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);

Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);