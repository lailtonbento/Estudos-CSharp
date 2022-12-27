namespace ExercicioHeranca.Entity
{
    class Trabalhador
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHours { get; set; }

        public Trabalhador(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }
        public Trabalhador(){}

        public virtual double Pagamento()
        {
            return Hours * ValuePerHours;
        }
    }
}