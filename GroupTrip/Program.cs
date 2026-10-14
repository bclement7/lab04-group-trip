/*
* Name: Bryce Clement
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, The Group Trip
* Date: October 7th, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it reports on a whole group instead of one person.
*/

// ===Part 0: The Questions===
//Asks the questions and established the constants

const int slicesPerPizza = 8;
const double taxPercent = 0.18;

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
//Creates the methods

double fuel = fuelCost(260, 28, 2.89);
double totalPizzaCost = pizzasNeeded * pizzaCost;
double tripTotal = fuel + totalPizzaCost;

System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel Cost: " + fuel.ToString("C"));
System.Console.WriteLine("Pizza Cost: " + totalPizzaCost.ToString("C"));
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
System.Console.WriteLine();

// ===Part 2: The Group===
//Establishes the arrays of people and their hours worked and rates

string[] names = { "Ada", "Grace", "Alan", "Katerine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

double slicesEach = pizzasNeeded * slicesPerPizza / names.Length;
double costPerPerson = tripTotal / names.Length;

System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine("People Going: " + names.Length);
System.Console.WriteLine("Slices each: " + slicesEach.ToString("F1"));
System.Console.WriteLine("Cost Per Person: " + costPerPerson.ToString("C"));
System.Console.WriteLine();

// ===Part 3: The Report
//Determines everyones take home pay, how much they worked, how much paid per hour, and how much they need to work

System.Console.WriteLine("=== Part 3: Who Works How Long ===");
double totalHours = 0;
double longest =0;
double totalTakeHomePay = 0;

for (int i = 0; i < names.Length; i++)
{
    double eachTakeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxPercent);
    double takeHomePayPerHour = eachTakeHomePay / hoursWorked[i];
    double hoursMustWork = HoursToCover(costPerPerson, takeHomePayPerHour);
    System.Console.WriteLine(names[i] + ": takes home " + eachTakeHomePay.ToString("C") + " for " + hoursWorked[i] + " hours, " + takeHomePayPerHour.ToString("C") + " per hour, must work " + hoursMustWork.ToString("F2") + " hours");
    totalHours += hoursWorked[i];
    longest = Math.Max(longest, hoursMustWork);
    totalTakeHomePay += eachTakeHomePay;
}

System.Console.WriteLine();
System.Console.WriteLine("Total hours worked: " + totalHours.ToString("F0"));
System.Console.WriteLine("Total take home pay: " + totalTakeHomePay.ToString("C"));
System.Console.WriteLine("Longest anyone must work: " + longest.ToString("F2"));

// ===Methods===

//Determines the fuel cost
static double fuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

//Determines how much money a person actually makes
static double TakeHomePay(double hours, double hourlyRate, double taxPercent)
{
    double money = hours * hourlyRate;
    double taxWithheld = money * taxPercent;
    return money - taxWithheld;
}

//Determines how many hours a person needs to work to afford their part of the trip
static double HoursToCover(double costPerPerson, double takeHomePayPerHour)
{
    double hours = costPerPerson / takeHomePayPerHour;
    return hours;
}