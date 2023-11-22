using System;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        Projector projector;
        TheaterLights lights;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, Projector projector, TheaterLights lights)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.projector = projector;
            this.lights = lights;
        }


        public void WatchMovie(string movie)
        {

            Console.WriteLine("Get ready to watch a movie...");
            lights.Dim(10);
            projector.On();
            amp.On();
            amp.SetDvd(dvd);
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            lights.On();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }
    }


        public class HomeTheaterTestDrive
        {
            public static void Main(string[] args)
            {
                var amp = new Amplifier("Over The Horizon Amplifier");
                var tuner = new Tuner("OverPowered AM/Fm Tuner", amp);
                var dvd = new DvdPlayer("Straight to Mars DvdPlayer", amp);
                var projector = new Projector("Holy Light Projector", dvd);
                var lights = new TheaterLights("Ambient Warm light");


                HomeTheaterFacade homeTheater = new(amp, tuner, dvd, projector, lights);
                homeTheater.WatchMovie("Inception");
                homeTheater.EndMovie();
            }
        }
}
