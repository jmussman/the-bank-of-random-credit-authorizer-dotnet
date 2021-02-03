// BankOfRandomCreditAuthorizerTests.java
// Copyright © 2020 Joel Mussman. All rights reserved.
//

using System;
using Xunit;
using Moq;
using OpenCardServices.Validator;

namespace TheBankOfRandomCredit.CardServices {

    public class BankOfRandomCreditAuthorizerTests {

        Mock<ICreditCardValidator> moqCreditCardValidator;
        BankOfRandomCreditAuthorizer authorizer;

        private void GivenMoqCreditCardValidator() {

            moqCreditCardValidator = new Mock<ICreditCardValidator>();
            authorizer = new BankOfRandomCreditAuthorizer(moqCreditCardValidator.Object);
        }

        // Verifies the requirement that the credit card validator is actually used
        // and passed the card number by using Mockito to verify the call. We cannot
        // actually test the results of the authorization function because it is
        // random.
        //
        [Fact]
        public void UsesCreditCardValidator() {

            string cardNumber = "1234";
            Decimal amount = new decimal(100.0);

            GivenMoqCreditCardValidator();

            moqCreditCardValidator.Setup(m => m.ValidateCardNumber(cardNumber)).Returns(false);

            authorizer.Purchase(cardNumber, new Decimal(100.0));

            moqCreditCardValidator.Verify(v => v.ValidateCardNumber(cardNumber), Times.Once);
        }
    }
}
