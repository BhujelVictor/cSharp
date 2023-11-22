using FacadePattern;
using System;

public class DvdPlayer
{
    private string description;
    private Amplifier amplifier;
    private string? movie;


    public DvdPlayer(string description, Amplifier amplifier)
    {
        this.description = description;
        this.amplifier = amplifier;
    }

    public void On()
    {
        Console.WriteLine($"{description} on");
    }
    public void Off()
    {
        Console.WriteLine($"{description} off");
    }
    public void Eject()
    {
        movie = null;
        Console.WriteLine($"{description} eject");
    }

    public void Play(string movie)
    {
        this.movie = movie;

        Console.WriteLine($"{description} playing \"{movie}\"");
    }
    public void Stop()
    {
        Console.WriteLine($"{description} Stopped \"{movie}\"");
    }

    public override string ToString()
    {
        return description;
    }
}