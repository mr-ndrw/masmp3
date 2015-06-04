namespace Logic.Core.Overlapping
{
    public class HealthInsurance
    {
        private bool IsLifeInsurance;
        private int amount;

        public HealthInsurance(bool isLifeInsurance, int amount)
        {
            IsLifeInsurance = isLifeInsurance;
            this.amount = amount;
        }

        public int Amount
        {
            get
            {
                return (int) (IsLifeInsurance ? amount * 1.2 : amount);
            }
        }
    }
}