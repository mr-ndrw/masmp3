namespace Logic.Core.Overlapping
{
    public class IncomeProtectionInsurance
    {
        public int ForHowManyYears { get; set; }
        public int CurrentIncome { get; set; }

        public IncomeProtectionInsurance(int forHowManyYears, int currentIncome)
        {
            
        }

        public int Amount
        {
            get { return (int) ((CurrentIncome/3.55)*ForHowManyYears); }
        }
    }
}