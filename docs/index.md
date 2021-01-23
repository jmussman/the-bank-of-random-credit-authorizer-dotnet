<a name='assembly'></a>
# The-Bank-of-Random-Credit-Authorizer

## Contents

- [BankOfRandomCreditAuthorizer](#T-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer 'com.thebankofrandomcredit.cardservices.BankOfRandomCreditAuthorizer')
  - [#ctor()](#M-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer-#ctor 'com.thebankofrandomcredit.cardservices.BankOfRandomCreditAuthorizer.#ctor')
  - [#ctor(creditCardValidator)](#M-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer-#ctor-com-wonderfulwidgets-retail-ICreditCardValidator- 'com.thebankofrandomcredit.cardservices.BankOfRandomCreditAuthorizer.#ctor(com.wonderfulwidgets.retail.ICreditCardValidator)')
  - [Purchase(cardNumber,amount)](#M-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer-Purchase-System-String,System-Decimal- 'com.thebankofrandomcredit.cardservices.BankOfRandomCreditAuthorizer.Purchase(System.String,System.Decimal)')

<a name='T-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer'></a>
## BankOfRandomCreditAuthorizer `type`

##### Namespace

com.thebankofrandomcredit.cardservices

##### Summary

Client interface to the credit card processing services for the Bank of Random Credit.

<a name='M-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create an authorizer using an instance of CreditCardValidator.

##### Parameters

This constructor has no parameters.

<a name='M-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer-#ctor-com-wonderfulwidgets-retail-ICreditCardValidator-'></a>
### #ctor(creditCardValidator) `constructor`

##### Summary

Create an authorizer using a provided credit card validator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| creditCardValidator | [com.wonderfulwidgets.retail.ICreditCardValidator](#T-com-wonderfulwidgets-retail-ICreditCardValidator 'com.wonderfulwidgets.retail.ICreditCardValidator') | The ICreditCardValidator instance to use. |

<a name='M-com-thebankofrandomcredit-cardservices-BankOfRandomCreditAuthorizer-Purchase-System-String,System-Decimal-'></a>
### Purchase(cardNumber,amount) `method`

##### Summary

If an invalid card number is presented the card will always be rejected.
Otherwide the odds are fifty-fifty that a charge to a credit cards is approved. Randomness
is the foundation of our bank, so if we give you credit or not just depends on a roll of the dice.

##### Returns

A unique token tied to the transaction if the charge is allowed, or null if it is not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cardNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The card number to charge. |
| amount | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The amount to charge. |
