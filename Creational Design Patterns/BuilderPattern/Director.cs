namespace BuilderPattern;

/// <summary>
/// 指导者（可选）
/// 根据规则顺序建造
/// 也可自定义建造
/// </summary>
public class Director
{
    private IBuilder? _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildMinimalViableProduct()
    {
        this._builder?.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        this._builder?.BuildPartA();
        this._builder?.BuildPartB();
        this._builder?.BuildPartC();
    }
}