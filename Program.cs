using System;

namespace RotatingPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            Border("== == == == == == == == ==");
            Title("Planetary Rotation(s) App");
            Border("== == == == == == == == ==\n");

            Console.Write("How many days do you want to measure? ");
            string result = Console.ReadLine();
            double days = Convert.ToDouble(result);
            

            double MercuryRotations = MercuryDaysToRotations(days);
            double VenusRotations = VenusDaysToRotations(days);
            double EarthRotations = EarthDaysToRotations(days);
            double MarsRotations = MarsDaysToRotations(days);
            double JupiterRotations = JupiterDaysToRotations(days);
            double SaturnRotations = SaturnDaysToRotations(days);
            double UranusRotations = UranusDaysToRotations(days);
            double NeptuneRotations = NeptuneDaysToRotations(days);


            Console.WriteLine($"In {days} days on Mercury...   the planet will have rotated the Sun {MercuryRotations} time(s).");
            Console.WriteLine($"In {days} days on Venus.....   the planet will have rotated the Sun {VenusRotations} time(s).");
            Console.WriteLine($"In {days} days on Earth.....   the planet will have rotated the Sun {EarthRotations} time(s).");
            Console.WriteLine($"In {days} days on Mars......   the planet will have rotated the Sun {MarsRotations} time(s).");
            Console.WriteLine($"In {days} days on Jupiter...   the planet will have rotated the Sun {JupiterRotations} time(s).");
            Console.WriteLine($"In {days} days on Saturn....   the planet will have rotated the Sun {SaturnRotations} time(s).");
            Console.WriteLine($"In {days} days on Uranus....   the planet will have rotated the Sun {UranusRotations} time(s).");
            Console.WriteLine($"In {days} days on Neptune...   the planet will have rotated the Sun {NeptuneRotations} time(s).");
        }

        static double MercuryDaysToRotations(double days) => Math.Round((days / 87.97),4);
        static double VenusDaysToRotations(double days) => Math.Round((days / 225),4);
        static double EarthDaysToRotations(double days) => Math.Round((days / 365),4);
        static double MarsDaysToRotations(double days) => Math.Round((days / 686.97),4);
        static double JupiterDaysToRotations(double days) => Math.Round((days / 4333),4);
        static double SaturnDaysToRotations(double days) => Math.Round((days / 10756),4);
        static double UranusDaysToRotations(double days) => Math.Round((days / 30687),4);
        static double NeptuneDaysToRotations(double days) => Math.Round((days / 60190),4);


        static void Title(string title) => Console.WriteLine($"Welcome to the {title}!");
        static void Border(string border) => Console.WriteLine($"{border}");

    }
}
