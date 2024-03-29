# DesignPattern
>*[设计模式学习文档](https://www.runoob.com/design-pattern/design-pattern-intro.html)*
---
  
## 设计模式六大原则（SOLID）
>用抽象构建框架，用实现扩展细节，具体到每一条设计原则
1. 开闭原则
   >对扩展开放，对修改封闭
    1. 抽象约束：通过接口或抽象类可以约束一组可能变化的行为，并且能够实现对扩展开放 * 拓展类不应该出现接口中不存在的 public 方法 * 参数、引用对象类型尽量使用接口或抽象类 * 抽象层尽量保持稳定 
    2. 元数据（metadata）控制模块行为
元数据：用来描述环境和数据的数据。如：可以通过配置文件来完成业务更改。 
    3. 制定项目章程（制定和遵守规则）
    4. 封装变化
2. 里氏替换原则
   >所有引用基类的地方，必须能够使用其子类直接替换
   1. 子类必须实现父类的所有方法 （继承的特性，子类拥有父类的所有方法）
   2. 子类可以有自己的个性 （重写）
   3. 覆盖或实现父类的方法时，入参可以放大（如：父类的参数 HashMap , 子类参数可以为 Map); 输出可以被缩小（如父类 return Map, 子类 return HashMap
3. 依赖倒置原则
   >抽象不应该依赖细节，细节应该依赖抽象。通过依赖倒置，可以减少类与类之间的耦合性，提高系统的稳定性，提高代码的可读性和可维护性，并且能够降低修改程序所造成的风险。
   1. 高层模块不应该依赖低层模块，两者都应该依赖其抽象. 不可分割的原子逻辑就是低层模式，原子逻辑组装成的就是高层模块。
   2. 抽象不应该依赖细节 java 中，抽象 -> 接口或抽象类；细节 -> 实现类
   3. 细节应该依赖抽象
4. 接口隔离原则
   >客户端不应该依赖它不需要的接口。
   1. 接口尽量小
   2. 接口要高内聚 高内聚：提高接口、类、模块的处理能力，减少对外的交互，要求在接口中尽少公布 public 方法，减少对外承诺也有利于降低成本
   3. 定制服务，针对不同的用户提供优良的服务，只提供访问者需要的方法。如不同权限的用户给于不同的操作接口。
   4. 接口设计有限度的 接口粒度越小，越灵活，但是结构却越复杂，所以要有个度
5. 迪米特原则
   >一个对象应该对其他对象有最少的了解。对类的低耦合提出了明确的要求
   1. 只和朋友交流。
例：老师叫班长清点学生，老师应该只和班长有耦合，而不应该和学生有耦合。
   1. 朋友之间也是有距离的。
耦合的类不要把太多方法暴露给其它类，否则改动要修改的地方太多。（高内聚）
   1. 自己的就是自己的
如果一个方法放在本类中，既不增加类间关系，也对本类不产生负面影响，那就放置在本类中。
6. 单一职责原则  
   >类的职责应该单一，一个方法只做一件事。职责划分清晰了，每次改动到最小单位的方法或类。尽量做到只有一个原因引起变化。

    1. 两个完全不一样的功能不应该放一个类中
    2. 一个类中应该是一组相关性很高的函数、数据的封装
    3. 应该不断审视自己的代码，根据具体业务、功能对类进行拆分，优化代码

## 创建型
>创建型模式提供了创建对象的机制， 能够提升已有代码的灵活性和可复用性。

1. 工厂方法

2. 抽象工厂

3. 生成器

4. 原型模式

5. 单例模式


## 结构型
>结构型模式介绍如何将对象和类组装成较大的结构， 并同时保持结构的灵活和高效。
1. 适配器模式  

2. 桥接模式

3. 组合模式

4. 装饰模式

5. 外观模式

6. 享元模式

7. 代理模式


## 行为型
>行为模式负责对象间的高效沟通和职责委派。
1. 责任链模式

2. 命令模式

3. 迭代器模式

4. 中介者模式

5. 备忘录模式

6. 观察者模式

7. 状态模式

8. 策略模式

9. 模板方法模式

10. 访问者模式
