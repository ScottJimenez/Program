using System;

namespace random
{
    class Program
    {
        public static object Const { get; private set; }

        static void Main(string[] args)
        {

            //Declaration
            double _lengteGazon, _breedteGazon, _breedteGrasmaaier, _aantalStroken, _TijdUur, _TijdMinuut;
            const double SNELHEID = 0.8;

            //Input 
            Console.WriteLine("Wat is de lengte van het gazon?");
            _lengteGazon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is de breedte van het gazon?");
            _breedteGazon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is de breedte van de grasmaaier?");
            _breedteGrasmaaier = Convert.ToDouble(Console.ReadLine());

            //Omzetten naar meter
            _breedteGrasmaaier /= 100;
            //Aantal stroken
            _aantalStroken = _breedteGazon / _breedteGrasmaaier;
            //Tijd per strook
            _TijdUur = _lengteGazon / SNELHEID;
            //Tijd voor gazon
            _TijdUur *= _aantalStroken;
            //Tijd omzetten naar uur
            _TijdUur /= 3600;
            //Minuten
            _TijdMinuut = _TijdUur % 3600;
            _TijdMinuut *= 60;
            if (_TijdMinuut > 60)
            {
                _TijdMinuut -= _TijdUur * 60;
            }
            //Output
            Console.WriteLine("Het zal " + _TijdUur.ToString("0 uur") + " en " + _TijdMinuut.ToString("0 minuten") + " duren.");
            Console.ReadLine() ;


            }

        }
    }
