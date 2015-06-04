using System;

namespace Logic.Core.Overlapping
{
    public class Insurance
    {
        public HealthInsurance HealthInsurance { get; private set; }
        public IncomeProtectionInsurance ProtectionInsurance { get; private set; }

        private string _insuranceIdentifier;
        private int _forHowManyYears;

        private Insurance(string insuranceIdentifier, int forHowManyYears)
        {
            _insuranceIdentifier = insuranceIdentifier;
            _forHowManyYears = forHowManyYears;
        }

        public int Amount
        {
            get
            {
                var result = 0;
                if (this.IsHealthInsurance)
                {
                    result += HealthInsurance.Amount;
                }
                if (this.IsIncomeProtectionInsurance)
                {
                    result += ProtectionInsurance.Amount;
                }
                return result;
            }
        }

        public bool IsHealthInsurance { get { return HealthInsurance != null; }}
        public bool IsIncomeProtectionInsurance { get { return ProtectionInsurance != null; } }

        public Insurance CreateHealthInsurance(string insuranceIdentifier, int forHowManyYears, int amount, bool includesLifeInsurance)
        {
            var insurance  = new Insurance(insuranceIdentifier, forHowManyYears);
            insurance.HealthInsurance = new HealthInsurance(includesLifeInsurance, amount);

            return insurance;
        }

        public static Insurance CreateIncomeProtectionInsurance(string insuranceIdentifier, int forHowManyYears, int currentIncome)
        {
            var insurance = new Insurance(insuranceIdentifier, forHowManyYears);
            insurance.ProtectionInsurance = new IncomeProtectionInsurance(forHowManyYears, currentIncome);

            return insurance;
        }

        public Insurance CreateHealthAndIncomeInsurance(string insuranceIdentifier, int forHowManyYears, int currentIncome,
            bool includesLifeInsurance, bool isLifeInsurance, int healthAmount)
        {
            var insurance=  new Insurance(insuranceIdentifier, forHowManyYears);
            insurance.AddToCurrentIncomeProtectionInsurance(currentIncome);
            insurance.AddToCurrentHealthInsurance(healthAmount, isLifeInsurance);

            return insurance;
        }

        public void AddToCurrentHealthInsurance(int amount, bool includesLifeInsurance)
        {
            if (IsHealthInsurance)
            {
                throw new Exception("Is already a health insurance");
            }
            this.HealthInsurance = new HealthInsurance(includesLifeInsurance, amount);
        }

        public void AddToCurrentIncomeProtectionInsurance(int currentIncome)
        {
            if (IsIncomeProtectionInsurance)
            {
                throw new Exception("Is already an income protection insurance.");
            }
            this.ProtectionInsurance  = new IncomeProtectionInsurance(_forHowManyYears, currentIncome);
        }
    }
}