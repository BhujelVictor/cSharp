using System;
using FacadePattern;

public class Projector
{
    private string description;
    private readonly DvdPlayer dvdPlayer;

    public Projector(string description, DvdPlayer dvdPlayer)
    {
        this.description = description;
        this.dvdPlayer = dvdPlayer;
    }

    public void On()
    {
        Console.WriteLine($"{description} on");
    }
    public void Off()
    {
        Console.WriteLine($"{description} off");
    }

    public override string ToString()
    {
        return description;
    }

}