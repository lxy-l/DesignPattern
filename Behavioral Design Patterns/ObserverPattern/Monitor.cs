using System;

namespace ObserverPattern;

public class Monitor : Observer
{
    public string Name { get; set; }

    public Monitor(string name,Subject subject)
    {
        Name = name;
        Subject = subject;
        Subject.AddObserver(this);
    }
        
    public override void Update()
    {
        if (Subject.GetState()==1)
        {
            Console.WriteLine(Name+"监控观测到移动，并记录下来了！");
        }
        else if (Subject.GetState()==0)
        {
            Console.WriteLine(Name+"监控观测到狗叫了");
        }
    }
}