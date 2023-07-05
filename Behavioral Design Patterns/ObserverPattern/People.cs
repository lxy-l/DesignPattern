using System;

namespace ObserverPattern;

public class People : Observer
{

    public string Name { get; set; }

    public People(string name,Subject subject)
    {
        Name = name;
        Subject = subject;
        Subject.AddObserver(this);
    }
    public override void Update()
    {
        if (Subject.GetState()==2)
        {
            Console.WriteLine(Name+"人观察到交配,并打了他一顿");
        }
        else if (Subject.GetState() == 0)
        {
            Console.WriteLine(Name + "人观察到狗叫了");
        }
    }
}