# UI tests for Docler test page
All of 12 requirements are covered by at least 1 test. Lots of tests can be merged together.
The scenarios are tagged with the requirement number that they cover.

## Prerequisites
- Visual Studio (2017)
- latest Chrome

## Running the tests
1) Open the solution file with Visual Studio
2) Build solution
3) Open Test explorer
4) Select and run test(s)

## Obersvations
- HTTP response cannot be accessed by Selenium webdriver -> so in this requirement I used the title of the page
- "Go!" button on the form page cannot be clicked by Selenium -> so I used the parent <span> element as "the button" (otherwise REQ11 test will fail)
