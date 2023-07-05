namespace BuilderPattern;

/// <summary>
/// 建造接口
/// </summary>
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
}