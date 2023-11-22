using System;
using FacadePattern;

public class Amplifier
{
    private readonly string description;

    public Amplifier(string description)
    {
        this.description = description;
    }

    public Tuner? Tuner { get; set; }
    public DvdPlayer? Dvd { get; set; }
    public void On()
    {
        Console.WriteLine($"{description} on");
    }
    public void Off()
    {
        Console.WriteLine($"{description} off");
    }
    public void SetVolume(int level)
    {
        Console.WriteLine($"{description} setting volume to {level.ToString()}");
    }
    public void SetDvd(DvdPlayer dvd)
    {
        Console.WriteLine($"{description} Settign DVD player to {dvd}");
        Dvd = dvd;
    }
    public void SetTuner(Tuner tuner)
    {
        Console.WriteLine($"{description} setting tuner to {tuner}");
        Tuner = tuner;
    }

    public override string ToString()
    {
        return description;
    }
}

