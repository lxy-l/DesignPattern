using StatePattern;

/*
 * 状态模式
 * 状态模式是一种行为设计模式， 让你能在一个对象的内部状态变化时改变其行为， 使其看上去就像改变了自身所属的类一样。
 */

var context = new Context(new ConcreteStateA());
context.Request1();
context.Request2();