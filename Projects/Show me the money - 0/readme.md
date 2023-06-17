## Show me the money

This project is a simple loan calculator. The user inputs the loan amount, interest rate, and term in years. The program then calculates the monthly payment amount and generates an amortization schedule.

The main logic of the program is contained in the `Program.cs` file. Here's a brief overview of the code:

- The program starts by checking if the correct number of arguments have been provided. If not, it displays an error message and exits.
- It then parses the arguments to get the loan amount, interest rate, and term in years.
- The monthly interest rate is calculated by dividing the annual rate by 1200.
- The monthly payment amount is calculated using the formula for the monthly payment on a loan.
- The program then generates an amortization schedule, which shows the payment number, payment amount, interest paid, principal paid, and remaining balance for each payment.

The code is well-structured and easy to follow. It makes good use of loops and conditional statements to handle different scenarios. The use of string interpolation to format the output is also a nice touch.
