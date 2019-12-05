Feature: Login to Daraz

@mytag
Scenario Outline: Verify the error message with invalid userName and password
	Given Login page is presented
	When I enter '<email>' and '<password>'
	Then I get the expected '<errorMessage>'

	Examples: 
	| email         | password | errorMessage                    |
	|               |          | You can't leave this empty.     |
	| test@test.com |          | You can't leave this empty.     |
	|               | 123      | You can't leave this empty.     |
	| test@test.com | 123      | Incorrect username or password. |

