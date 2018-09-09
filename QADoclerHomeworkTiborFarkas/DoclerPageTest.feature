Feature: DoclerPageTest
	This test set verifies all of the 12 requirement

@REQ-UI-01
Scenario Outline: The Title should be - UI Testing Site - on <Site> site
	Given Docler webpage is opened
	When I open "<Site>" site
	Then The title should be: UI Testing Site
	Examples:
	| Site |
	| Form |
	| Home |

@REQ-UI-02
Scenario Outline: The Company Logo should be visible on <Site> site
	Given Docler webpage is opened
	When I open "<Site>" site
	Then Company logo is visible
	Examples:
	| Site |
	| Form |
	| Home |

@REQ-UI-03
@REQ-UI-04
Scenario: Home button navigates to the Home site and menu item became active
	Given Docler webpage is opened
	When I open "Form" site
	And I open "Home" site
	Then The "Home" page is opened
	And The "Home" menu item is active

@REQ-UI-05
@REQ-UI-06
Scenario: Form button navigates to the Form site and menu item became active
	Given Docler webpage is opened
	When I open "Form" site
	Then The "Form" page is opened
	And The "Form" menu item is active

@REQ-UI-07
Scenario: When I click on the Error button, I should get a 404 HTTP response code
	Given Docler webpage is opened
	When I open "Error" site
	Then Got 404 HTTP response code

@REQ-UI-08
Scenario: When I click on the UI Testing button, I should get navigated to the Home page
	Given Docler webpage is opened
	When I open "Form" site
	And I click on the UI Testing button
	Then The "Home" page is opened

@REQ-UI-09
Scenario: Text should be visible in H1 tag at Home page
	Given Docler webpage is opened
	When I open "Home" site
	Then "Welcome to the Docler Holding QA Department" text visible in "H1" tag

@REQ-UI-10
Scenario: Text should be visible in P tag at Home page
	Given Docler webpage is opened
	When I open "Home" site
	Then "This site is dedicated to perform some exercises and demonstrate automated web testing." text visible in "p" tag

@REQ-UI-11
Scenario: On the Form page, a form should be visible with one input box and one submit button
	Given Docler webpage is opened
	When I open "Form" site
	Then A form is visible with one input field and a submit button

@REQ-UI-12
Scenario Outline: Open the form page and submit a name from the given list
	Given Docler webpage is opened
	When I open "Form" site
	And I enter "<Name>" and click on the submit button
	Then The "Hello" page is opened
	And "<Message>" text visible in "H1" tag
	And The title should be: UI Testing Site
	And Company logo is visible

	Examples: 
	| Name    | Message        |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |