/*
 * 命令模式
 * 命令是一种行为设计模式， 它可将请求或简单操作转换为一个对象。
 */
using CommandPattern;

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();