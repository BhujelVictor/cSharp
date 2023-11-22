using System;
using FacadePattern;

public class Tuner
{
    private readonly string description;
    private readonly Amplifier amplifier;

    public Tuner(string description, Amplifier amplifier)
    {
        this.description = description;
        this.amplifier = amplifier;
    }
    public void On()
    {
        Console.WriteLine($"{description}  on");
    }
    public void Off()
    {
        Console.WriteLine($"{description}  off");
    }
    public void SetAm()
    {
        Console.WriteLine($"{description}  Setting Am mode.");
    }
    public void SetPm()
    {
        Console.WriteLine($"{description}  Setting Pm mode");
    }
    public void SetFrequency(double frequency)
    {
        Console.WriteLine($"{description}  Setting frequency to {frequency.ToString()}");
    }
    public override string ToString()
    {
        return description;
    }
}