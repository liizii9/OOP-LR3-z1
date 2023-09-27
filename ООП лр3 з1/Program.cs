using System;

class Parent
{
    protected int Pole1;
    protected double Pole2;

    public Parent(int pole1, double pole2)
    {
        Pole1 = pole1;
        Pole2 = pole2;
    }

    public virtual void Print()
    {
        Console.WriteLine("Пасажирiв: " + Pole1);
        Console.WriteLine("Вартiсть квитка: " + Pole2);
    }

    public virtual double Metod()
    {
        return Pole1 * Pole2;
    }
}

class Child1 : Parent
{
    private double Pole3;

    public Child1(int pole1, double pole2, double pole3) : base(pole1, pole2)
    {
        Pole3 = pole3;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Середня швидкiсть: " + Pole3);
    }

    public override double Metod()
    {
        return base.Metod() + Pole1 * Pole3 * 0.05;
    }
}

class Child2 : Parent
{
    private double Pole4;

    public Child2(int pole1, double pole2, double pole4) : base(pole1, pole2)
    {
        Pole4 = pole4;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Вiдстань в км: " + Pole4);
    }

    public override double Metod()
    {
        return base.Metod() - Pole1 * Pole4 * 0.01;
    }
}

class Program
{
    static void Main()
    {
        Parent parent = new Parent(25, 180.50);
        Child1 child1 = new Child1(30, 150.0, 80.0);
        Child2 child2 = new Child2(45, 300.0, 120.0);

        Console.WriteLine("Батькiвський клас:");
        parent.Print();
        Console.WriteLine("Виручка: " + parent.Metod());

        Console.WriteLine("\nДочiрнiй клас 1:");
        child1.Print();
        Console.WriteLine("Виручка: " + child1.Metod());

        Console.WriteLine("\nДочiрнiй клас 2:");
        child2.Print();
        Console.WriteLine("Виручка: " + child2.Metod());
    }
}