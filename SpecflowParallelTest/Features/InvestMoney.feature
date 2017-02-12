Feature: Invest money
	Check if user can invest money


@mytag
Scenario: Invest money as a unregistred user
	Given I navigate to project1
	And I click invest custom amount button
	And I enter cardholder name card number and summ
		| CardHolderName | CardNum      | Summ |
		| admin          | 3243252345   | 22   |
	And I click submit button
	Then I should see money added into Collected column