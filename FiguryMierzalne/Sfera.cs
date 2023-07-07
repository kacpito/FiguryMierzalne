namespace FiguryLib
{
    public class Sfera : Figura3D, IMierzalna2D
    {
        public Punkt3D O { get; set; }
        public double R { get; set; }

        public double Pole => 4 * Math.PI * R * R;

        public Sfera() 
        {
            O = new Punkt3D();
            R = 0;
        }

        public Sfera(Punkt3D srodek, double promien, string nazwa = "") : base(nazwa)
        {
            O = srodek;
            R = promien;
        }

        public override void Przesun(double dx, double dy, double dz)
        {
            O = new Punkt3D(O.X + dx, O.Y + dy, O.Z + dz);
        }

        public override void Przesun(Wektor3D kierunek)
        {
            O = new Punkt3D(O.X + kierunek.X, O.Y + kierunek.Y, O.Z + kierunek.Z);
        }

        public void Skaluj(double wspSkalowania)
        {
            R *= wspSkalowania;
        }

        public override string ToString() => $"Sfera({O}, {R})";

        public virtual string ToString(Format format) => (format is Format.Prosty) ? this.ToString()
                : $"Nazwa: {Nazwa}, kolor: {Kolor}, Sfera, {this.ToString()}, Pole = {Pole:0.##}";

        public static explicit operator Okrag2D(Sfera s) => new Okrag2D(new Punkt2D(s.O.X, s.O.Y), s.R);
    }
}
