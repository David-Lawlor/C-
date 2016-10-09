using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Currency
{
    Eur, USD, Yen
}

namespace Lab5
{
    struct Money
    {
        const double EUR_TO_USD = 1.11482;
        const double EUR_TO_YEN = 116.055;
        const double USD_TO_YEN = 104.107;



        public double Amount { get; set; }

        public Currency Currency { get; set; }

        public Money(double amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public Money ConvertMoney(Currency currency)
        {
            return convert(this.Amount, this.Currency, currency);
        }

        public Money operator +(Money money1, Money money2)
        {
            Money temp = convert(money2.Amount, money2.Currency, money1.Currency);
            return new Money(money1.Amount + temp.Amount, money1.Currency);
        }

        private Money convert(double amount, Currency currencyFrom, Currency currencyTo)
        {
            double convertedAmount = 0;

            if (currencyFrom.Equals("Eur"))
            {
                if (currencyTo.Equals("Yen"))
                {
                    convertedAmount = this.Amount * EUR_TO_YEN;
                }
                else if (currencyTo.Equals("USD"))
                {
                    convertedAmount = this.Amount * EUR_TO_USD;
                }
            }
            else if (currencyFrom.Equals("USD"))
            {
                if (currencyTo.Equals("Yen"))
                {
                    convertedAmount = this.Amount * USD_TO_YEN;
                }
                else if (currencyTo.Equals("Eur"))
                {
                    convertedAmount = this.Amount * (1 / EUR_TO_USD);
                }
            }
            else if (currencyFrom.Equals("Yen"))
            {
                if (currencyTo.Equals("USD"))
                {
                    convertedAmount = this.Amount * (1 / USD_TO_YEN);
                }
                else if (currencyTo.Equals("Eur"))
                {
                    convertedAmount = this.Amount * (1 / EUR_TO_YEN);
                }
            }
            return new Money(convertedAmount, currencyTo);
        }
    }
}
