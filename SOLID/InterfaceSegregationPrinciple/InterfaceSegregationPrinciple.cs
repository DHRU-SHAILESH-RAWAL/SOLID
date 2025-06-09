namespace SOLID.InterfaceSegregationPrinciple
{
    class BrokeInterfaceSegregationPrinciple
    {
        interface IPayment
        {
            bool ProcessCreditCardPayment(decimal amount);
            bool ProcessUPIPayment(decimal amount);

            bool ProcessGiftCardPayment(decimal amount);
        }

        // This class violates the Interface Segregation Principle because it forces the implementation of methods that are not relevant to all payment types.
        class CreaditCardPayment : IPayment
        {
            public bool ProcessCreditCardPayment(decimal amount)
            {
                // Logic to process credit card payment
                return true;
            }

            /// <summary>
            /// This method is not applicable for credit card payment, but it is required by the interface.
            /// Itforces a class to implement methods that are not relevant to its functionality, which violates the Interface Segregation Principle.
            /// voilates the abstraction.
            /// </summary>
            /// <param name="amount"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public bool ProcessUPIPayment(decimal amount)
            {
                // Not applicable for credit card payment
                throw new NotImplementedException();
            }
            public bool ProcessGiftCardPayment(decimal amount)
            {
                // Not applicable for credit card payment
                throw new NotImplementedException();
            }
        }
    }

    class InterfaceSegregationPrinciple
    {
        interface ICreditCardPayment
        {
            bool ProcessCreditCardPayment(decimal amount);
        }
        interface IUPIPayment
        {
            bool ProcessUPIPayment(decimal amount);
        }
        interface IGiftCardPayment
        {
            bool ProcessGiftCardPayment(decimal amount);
        }
        // This class adheres to the Interface Segregation Principle because it only implements the methods relevant to credit card payments.
        class CreditCardPayment : ICreditCardPayment
        {
            public bool ProcessCreditCardPayment(decimal amount)
            {
                // Logic to process credit card payment
                return true;
            }
        }
    }
}