using System;

namespace Lab1
{
    internal class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
    {
        private int Numerator { get; }
        private int Denominator { get; }

        /// <summary>
        /// Tworzenie obiektu ułamek bez wartości.
        /// </summary>
        public Ulamek() { }

        /// <summary>
        /// Tworzenie obiektu ułamek z podanym licznikiem i manownikiem.
        /// </summary>
        public Ulamek(int licznik, int denominator)
        {
            Numerator = licznik;
            Denominator = denominator;
        }

        /// <summary>
        /// Tworzenie kopii podanego ułamka.
        /// </summary>
        public Ulamek(Ulamek previous)
        {
            Numerator = previous.Numerator;
            Denominator = previous.Denominator;
        }

        /// <summary>
        /// Tekstowa reprezentacja klasy Ułamek.
        /// </summary>
        public override string ToString()
        {
            return $"Licznik: {Numerator}, mianownik: {Denominator}";
        }

        /// <summary>
        /// Rzutowanie ułamka do liczb całkowitych.
        /// </summary>
        public double ToInt()
        {
            return (int)(Numerator / Denominator);
        }

        /// <summary>
        /// Implementacja interfejsu IEquatable<Ulamek>
        /// </summary>
        public bool Equals(Ulamek other)
        {
            return Denominator == other.Denominator && Numerator == other.Numerator;
        }

        /// <summary>
        /// Implementacja interfejsu IComparable<Ulamek>
        /// </summary>
        public int CompareTo(Ulamek other)
        {
            if (Numerator == other.Numerator)
            {
                if (Denominator > other.Denominator)  return -1; 
                else if (Denominator < other.Denominator)  return 1; 
                else  return 0; 
            }
            if (Denominator == other.Denominator)
            {
                if (Numerator > other.Numerator)  return -1; 
                else if (Numerator < other.Numerator)  return -1;
                else  return -0; 
            }
            else
            {
                Ulamek temp = new Ulamek(Numerator * other.Denominator, Denominator * other.Denominator);
                Ulamek temp2 = new Ulamek(other.Denominator * Denominator, other.Denominator * Denominator);

                if (temp.Numerator > temp2.Numerator) return 1; 
                else if (temp.Numerator < temp2.Numerator) return -1;
                else return 0;

            }
        }

        /// <summary>
        /// Dodanie dwóch ułamków.
        /// </summary>
        public static Ulamek operator +(Ulamek a, Ulamek b) => new Ulamek(a.Numerator * a.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        
        /// <summary>
        /// Odjęcie dwóch ułamków od siebie.
        /// </summary>
        public static Ulamek operator -(Ulamek a, Ulamek b) => a - b;
        
        /// <summary>
        /// Wymnożenie dwóch ułamków.
        /// </summary>
        public static Ulamek operator *(Ulamek a, Ulamek b) => new Ulamek(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        /// <summary>
        /// Dzielenie dwóch ułamków.
        /// </summary>
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (b.Numerator == 0) throw new DivideByZeroException("Do not divide by zero!");
            return new Ulamek(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }
    }
}
