/*
* Name: Bryce Clement
* Course: CSCI 1250, Section 002
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

// ===Part 0: The Questions===
//Asks the questions and established the constants



const int slicesPerPizza = 8;
const double taxWithheld = 18 / 100;

Console.Write("What was the round trip in miles? ");
int miles = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are driving? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas Price? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas do you need? ");
int pizzasNeeded = Convert.ToInt32(Console.ReadLine());

Console.Write("How much did each pizza cost? ");
double pizzaCost = Convert.ToDouble(Console.ReadLine());

// ===Part 1: Three Methods===
//Finds the amount of people going and how much pizza is needed and the cost.

static double fuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

static double TakeHomePay(double hoursWorked, double hourlyRate, double taxWithheld)
{
    double money = hoursWorked * hourlyRate;
    return money * taxWithheld;
}

static double HoursToCover(double costPerPerson, double takeHomePayPerHour)
{
    double hours = costPerPerson / takeHomePayPerHour;
    return hours;
}

double fuel = fuelCost(260, 28, 2.89);
double totalPizzaCost = pizzasNeeded * pizzaCost;
double tripTotal = fuel + totalPizzaCost;

System.Console.WriteLine("Fuel Cost: " + fuel.ToString("C"));
System.Console.WriteLine("Pizza Cost: " + totalPizzaCost.ToString("C"));
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));

// ===Part 2: The Group===

/*
int totalSlices = pizzasNeeded * slicesPerPizza;


// ===Part 3: Paycheck===
//Finds how much money was made the past week.

Console.Write("How many hours did you work this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("How much do you get paid an hour? ");
float hourlyRate = Convert.ToSingle(Console.ReadLine());

const double taxWithheld = 18 / 100;

double grossPay = hoursWorked * hourlyRate;

double taxTaken = grossPay * taxRate;

double moneyMade = grossPay - taxTaken;

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxTaken.ToString("C"));
Console.WriteLine("Take home pay: " + moneyMade.ToString("C"));

// ===Part 4: The Whole Trip===
//Finds total cost of the trip and how much work is needed for the trip.
*/

/*
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = moneyMade / hoursWorked;
double hoursMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover you share: " + hoursMustWork.ToString("F2"));
*/