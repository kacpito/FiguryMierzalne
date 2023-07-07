namespace FiguryLib
{
    public class Okrag2D : Figura2D, IMierzalna1D
    {
        public double R { get; set; }
        public Punkt2D O { get; set; }

        public double Dlugosc => 2 * Math.PI * R;

        public Okrag2D() : base()
        {
            R = 0;
            O = new Punkt2D(0, 0);
        }

        public Okrag2D(Punkt2D srodek, double promien = 0, string nazwa = "") : base(nazwa)
        {
            R = promien;
            O = srodek;
        }
        

        public override void Przesun(double dx, double dy)
        {
            O = new Punkt2D(O.X + dx, O.Y + dy);
        }

        public override void Przesun(Wektor2D kierunek)
        {
            O = new Punkt2D(O.X + kierunek.X, O.Y + kierunek.Y);
        }

        public void Skaluj(double wspSkalowania)
        {
            R *= wspSkalowania;
        }

        public override string ToString() => $"Okrag2D({O}, {R})";

        public virtual string ToString(Format format) => (format is Format.Prosty) ? this.ToString()
                : $"Nazwa: {Nazwa}, kolor: {Kolor}, Figura-2D, {this.ToString()}, Długość = {Dlugosc:0.##}";
    }
}
