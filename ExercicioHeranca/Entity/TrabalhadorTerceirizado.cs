namespace ExercicioHeranca.Entity
{
    class TrabalhadorTerceirizado : Trabalhador
    {
        public double BonusAdicional { get; set; }

        public TrabalhadorTerceirizado(string name, int hours, double valuePerHours, double bonusAdicional)
            : base(name, hours, valuePerHours)
        {

            BonusAdicional = bonusAdicional;
        }
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * BonusAdicional;
        }
    }
}