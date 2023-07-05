namespace BuilderPattern;

/// <summary>
/// 生成器
/// 提供构建步骤具体实现
/// </summary>
public class ConcreteBuilder : IBuilder
{
    private Product product=new();

    public ConcreteBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        product=new Product();
    }

    public Product GetProduct() 
    {
        Product result = product;
        Reset();
        return result;
    }

    public void BuildPartA()
    {
        product.Add("PartA1");
    }

    public void BuildPartB()
    {
        product.Add("PartB1");
    }

    public void BuildPartC()
    {
        product.Add("PartC1");
    }
}