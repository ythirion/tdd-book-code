using System.Runtime.Serialization;

namespace money_problem.Domain
{
    [Serializable]
    public class MissingExchangeRatesException : Exception
    {
        protected MissingExchangeRatesException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MissingExchangeRatesException(params string[] missingExchangeRates)
            : base($"Missing exchange rate(s): [{string.Join(",", missingExchangeRates)}]")
        {
        }
    }
}