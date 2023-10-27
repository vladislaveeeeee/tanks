using System;
using System.Collections.Generic;

class Tank : ICloneable, IComparable<Tank>
{
    public string Name { get; set; }
    public double Speed { get; set; }

    public Tank(string name, double speed)
    {
        Name = name;
        Speed = speed;
    }

    public object Clone()
    {
        return new Tank(Name, Speed);
    }

    public int CompareTo(Tank other)
    {
        return Speed.CompareTo(other.Speed);
    }

    public override string ToString()
    {
        return $"{Name}: Speed = {Speed}";
    }
}

class Program
{
    static void Main()
    {
        Tank tankA = new Tank("TankA", 70.0);
        Tank tankB = new Tank("TankB", 85.0);
        Tank tankC = new Tank("TankC", 60.0);

        Console.WriteLine("Список танків:");
        Console.WriteLine(tankA);
        Console.WriteLine(tankB);
        Console.WriteLine(tankC);

        Tank clonedTank = (Tank)tankA.Clone();
        Console.WriteLine("\nКлонований танк:");
        Console.WriteLine(clonedTank);

        if (tankA.CompareTo(tankB) > 0)
            Console.WriteLine($"\nТанк {tankA.Name} швидший за танка {tankB.Name}");
        else if (tankA.CompareTo(tankB) < 0)
            Console.WriteLine($"\nТанк {tankA.Name} повільніший за танка {tankB.Name}");
        else
            Console.WriteLine($"\nТанк {tankA.Name} має однакову швидкість з танком {tankB.Name}");
    }
}