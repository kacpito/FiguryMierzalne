namespace FiguryLib
{
    public class Kula : Sfera, IMierzalna2D, IMierzalna3D
    {
        public Kula() : base() { }
        public Kula(Punkt3D srodek, double promien = 0, string nazwa = "") : base(srodek, promien, nazwa)
        {
            R = promien;
            O = srodek;
        }
        public double Objetosc => (4.0/3.0) * Math.PI * Math.Pow(R, 3);
        public override string ToString() => $"Kula({O}, {R})";
        public override string ToString(Format format)
            => (format is Format.Prosty) ?
                  this.ToString()
                : base.ToString(format) + $", Objetosc = {Objetosc:0.##}";

        public static explicit operator Okrag2D(Kula k) => new Okrag2D(new Punkt2D(k.O.X, k.O.Y), k.R);
        public static explicit operator Kolo2D(Kula k) => new Kolo2D(new Punkt2D(k.O.X, k.O.Y), k.R);
    }
}
