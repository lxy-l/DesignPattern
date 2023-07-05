using System.Collections;

namespace IteratorPattern;

public abstract class IteratorAggregate:IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}