// BankOfRandomCreditAuthorizer.cs
// Copyright © 2020-2021 Joel Mussman. All rights reserved.
//

using System;
using OpenCardServices.Validator;

namespace TheBankOfRandomCredit.CardServices {

    /// <summary>Client interface to the credit card processing services for the Bank of Random Credit.</summary>
    public class AuthorizationService {

        ICreditCardValidator creditCardValidator;

        /// <summary>Create an authorizer using an instance of CreditCardValidator.</summary>
        public AuthorizationService() {

            creditCardValidator = new CreditCardValidator();
        }

        /// <summary>Create an authorizer using a provided credit card validator.</summary>
        /// <param name="creditCardValidator">The ICreditCardValidator instance to use.</param>
        public AuthorizationService(ICreditCardValidator creditCardValidator) {

            this.creditCardValidator = creditCardValidator;
        }

        /// <summary>
        /// If an invalid card number is presented the card will always be rejected.
        /// Otherwide the odds are fifty-fifty that a charge to a credit cards is approved. Randomness
        /// is the foundation of our bank, so if we give you credit or not just depends on a roll of the dice.
        /// </summary>
        /// <param name="number">The card number to charge.</param> 
        /// <param name="name">The name on the card.</param> 
        /// <param name="expires">The expiration mm/yyyy of the card.</param> 
        /// <param name="ccv">The credit card verification code.</param> 
        /// <param name="amount">The amount to charge.</param>
        /// <returns>A unique token tied to the transaction if the charge is allowed, or null if it is not.</returns>
        public string Submit(string number, string name, string expires, string ccv, Decimal amount) {

            string result = null;

            try {

                if (creditCardValidator.ValidateCardNumber(number) && (new Random()).Next(0, 2) < 0.5) {

                    result = System.Guid.NewGuid().ToString();
                }
            }

            catch (NullReferenceException) {

                // Do nothing, null will be returned as a failure to purchase.
            }

            return result;
        }

    }
}