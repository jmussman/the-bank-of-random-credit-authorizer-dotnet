<a name='assembly'></a>
# TheBankOfRandomCreditAuthorizer

## Contents

- [AuthorizationService](#T-TheBankOfRandomCredit-CardServices-AuthorizationService 'TheBankOfRandomCredit.CardServices.AuthorizationService')
  - [#ctor()](#M-TheBankOfRandomCredit-CardServices-AuthorizationService-#ctor 'TheBankOfRandomCredit.CardServices.AuthorizationService.#ctor')
  - [#ctor(creditCardValidator)](#M-TheBankOfRandomCredit-CardServices-AuthorizationService-#ctor-OpenCardServices-Validator-ICreditCardValidator- 'TheBankOfRandomCredit.CardServices.AuthorizationService.#ctor(OpenCardServices.Validator.ICreditCardValidator)')
  - [Submit(number,name,expires,ccv,amount)](#M-TheBankOfRandomCredit-CardServices-AuthorizationService-Submit-System-String,System-String,System-String,System-String,System-Decimal- 'TheBankOfRandomCredit.CardServices.AuthorizationService.Submit(System.String,System.String,System.String,System.String,System.Decimal)')

<a name='T-TheBankOfRandomCredit-CardServices-AuthorizationService'></a>
## AuthorizationService `type`

##### Namespace

TheBankOfRandomCredit.CardServices

##### Summary

Client interface to the credit card processing services for the Bank of Random Credit.

<a name='M-TheBankOfRandomCredit-CardServices-AuthorizationService-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create an authorizer using an instance of CreditCardValidator.

##### Parameters

This constructor has no parameters.

<a name='M-TheBankOfRandomCredit-CardServices-AuthorizationService-#ctor-OpenCardServices-Validator-ICreditCardValidator-'></a>
### #ctor(creditCardValidator) `constructor`

##### Summary

Create an authorizer using a provided credit card validator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| creditCardValidator | [OpenCardServices.Validator.ICreditCardValidator](#T-OpenCardServices-Validator-ICreditCardValidator 'OpenCardServices.Validator.ICreditCardValidator') | The ICreditCardValidator instance to use. |

<a name='M-TheBankOfRandomCredit-CardServices-AuthorizationService-Submit-System-String,System-String,System-String,System-String,System-Decimal-'></a>
### Submit(number,name,expires,ccv,amount) `method`

##### Summary

If an invalid card number is presented the card will always be rejected.
Otherwide the odds are fifty-fifty that a charge to a credit cards is approved. Randomness
is the foundation of our bank, so if we give you credit or not just depends on a roll of the dice.

##### Returns

A unique token tied to the transaction if the charge is allowed, or null if it is not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The card number to charge. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name on the card. |
| expires | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expiration mm/yyyy of the card. |
| ccv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The credit card verification code. |
| amount | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The amount to charge. |
