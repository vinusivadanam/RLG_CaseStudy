﻿namespace FictitiousInsurance.Model
{
    public class PaymentModel
    {
        public double PayoutAmount { get; set; }
        public double AnnualPremium { get; set; }
        public double CreditCharge { get; set; }
        public double TotalPremium { get; set; }
        public double AvgMonthlyPremium { get; set; }
        public double InitialMonthlyPayAmount { get ; set; }
        public double OtherMonthlyPayAmount { get; set; }
    }
}
