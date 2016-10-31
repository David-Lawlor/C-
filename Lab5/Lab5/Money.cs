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

        public Money(double amount, Currency currency): this()
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public double ConvertMoney(Currency currency)
        {
            return convert(this.Amount, this.Currency, currency);
        }

        public static Money operator +(Money money1, Money money2)
        {
            double temp = convert(money2.Amount, money2.Currency, money1.Currency);
            return new Money(money1.Amount + temp, money1.Currency);
        }

        public static double convert(double amount, Currency currencyFrom, Currency currencyTo)
        {
            double convertedAmount = 0;

            if (currencyFrom.Equals(Currency.Eur))
            {
                if (currencyTo.Equals(Currency.Yen))
                {
                    convertedAmount = amount * EUR_TO_YEN;
                }
                else if (currencyTo.Equals(Currency.USD))
                {
                    convertedAmount = amount * EUR_TO_USD;
                }
            }
            else if (currencyFrom.Equals(Currency.USD))
            {
                if (currencyTo.Equals(Currency.Yen))
                {
                    convertedAmount = amount * USD_TO_YEN;
                }
                else if (currencyTo.Equals(Currency.Eur))
                {
                    convertedAmount = amount * (1 / EUR_TO_USD);
                }
            }
            else if (currencyFrom.Equals(Currency.Yen))
            {
                if (currencyTo.Equals(Currency.USD))
                {
                    convertedAmount = amount * (1 / USD_TO_YEN);
                }
                else if (currencyTo.Equals(Currency.Eur))
                {
                    convertedAmount = amount * (1 / EUR_TO_YEN);
                }
            }
            return convertedAmount;
        }
    }
}
