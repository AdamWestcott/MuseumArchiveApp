KGCo2e Calculator README file

Current Version 1.0 August 26th 2021


INTRODUCTION
------------

The KGCo2e Calculator takes user inputs to calculate and output the total
Kilograms of Carbon Dioxide Equivalent. This involves displaying the 
amount over different periods of time, including Weekly, Monthly, Quarterly
and Annually.


REQUIREMENTS
------------

This application requires the following framework:

.NET 5.0 (https://dotnet.microsoft.com/download/dotnet/5.0)


INSTALLATION
------------

Install as you would normally from the kgco2eCalculator.exe file.

If any errors occur during installation, please remove all files relating to
the software and install as you would normally from the kgco2eCalculator.exe
file.


Usage
-----

KgCo2e Produced: 7

Period of Measurement: Weekly

Selected Start Date: 01/08/2021

Selected End Date: 08/08/2021

Include End Date: Not Selected (False)


This input specifies that the Kilograms of Carbon Dioxide Equivalent emitted
per week, from the week 01/08/2021 - 08/08/2021 (not including the end date)
was 7.


With this input, the software will calculate:

*If the year is a leap year
	- This is done by looking at the year of the start date, and
	checking if it is divisible by 4, then 100, then 400. If it fails
	at the initial division, then the year is not a leap year. If it
	passes the initial division and the second division, then it is also
	not a leap year. If it passes the first, fails the second and passes
	the third, then it is a leap year.
*The amount emitted every week.
	- This is done by outputting the amount input as the period of
	measurement selected is weekly.
*The amount emitted every month.
	- This is done by dividing the input by 7, which represents the
	amount for a single day. Then multiplying this value by the average
	days in a month for a non leap year (365/12).
*The amount emitted every quarter.
	- This is done by dividing the input by 7, which represents the
	amount for a single day. Then multiplying this value by the average
	days in a quarter for a non leap year (365/4).
*The amount emitted every year.
	- This is done by dividing the input by 7, which represents the
	amount for a single day. Then multiplying this value by the amount
	of days in a non leap year (365).
*The total amount emitted between the two selected dates.
	- This is done by taking the start date and end date selected with
	then DatePicker tool. The total amount of days between the two
	selected dates are calculated by subtracting the day of the start
	date from the day of the end date.


It will output:
It isn't a Leap Year:
Weekly kgCo2e: 7
Monthly kgCo2e: 30.42
Quarterly kgCo2e: 91.25
Yearly kgCo2e: 365
Total between Selected Dates: 7


Maintainers
-----------

Current Maintainers:
*Adam Westcott - 
*Cameron Dennis -