// ! IF

bool userIsHungry = true;

if ( userIsHungry ) // value within parans need to equal true 
{
    System.Console.WriteLine("Eat Something"); // bc userIsHungry is true itll run this writeline. if false it would skip this If conditional
}

// ! Using operators 
int hoursWorking = 1;
if (hoursWorking < 8)
{
    System.Console.WriteLine("Are you even working?");
}

// ! Else 
bool choresAreDone = false;
if(choresAreDone)
{
    System.Console.WriteLine("Have fun at the movies");
}
else
{
    System.Console.WriteLine("You need to stay home and finish your chores");
    // When the If is false it runs the else. An else is a great way to catch various errors through user input
}

string input = "3";
int totalHours = int.Parse(input); // if the string connot be read as an int, an error will be thrown

if(totalHours >= 8)
{
    System.Console.WriteLine("You should be well rested");
}
else {
    System.Console.WriteLine("You might be tired this afternoon...");

    if(totalHours < 4)
    {
        System.Console.WriteLine("You need to get some sleep!");
    }
}

/*
    A person's age
        <18: You're just a kid
        18: Adult 
        21: Drinking Age
        25: Insurance lowers
*/

int age = 23; 
if (age >= 25)
{
    System.Console.WriteLine("Insurance lowers AND you can rent a car!");
}
else if (age >= 21)
{
    System.Console.WriteLine("Drinking age woooo!");
}
else if (age >= 18)
{
    System.Console.WriteLine("You're an adult");
}
else
{
    System.Console.WriteLine("You're just a kid");
}

/*
!   Switch Cases
    - Allow us to check against a case depending on the value passed, and returns a result.
*/

int intInput = 4;
string order;

switch(intInput)
{
    case 1: 
        order = "burger and fries";
        break;
    case 2:
        order = "chicken sandwich";
        break;
    case 3: 
        order = "tacos";
        break;
    case 4: 
        order = "bean burrito";
        break;
    default:
        order = "cup of water";
        break;
}
System.Console.WriteLine(order);
// in this case bc the input is already entered in as 4 it comes up as bean burrito 

string today = "Saturday";

switch(today)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        System.Console.WriteLine("Office is open");
        break;
    case "Saturday":
    case "Sunday":
        System.Console.WriteLine("Office is closed"); // if we were using user input
        break;
    default:
        System.Console.WriteLine("Please input a valid day.");
        break;
    // always take into account that with user input the user will always use things incorrectly 
}

// ! Switch Expression
order = intInput switch
{
    1 => "burger and fries",
    2 => "chicken sandwich",
    3 or 4 => "burrito",
    _ => "cup of water"
};
System.Console.WriteLine(order);

// ! Ternary Expression
/*
    - shorthand for if and if/else conditional 
    - meant to assign a value to a variable
*/

int userAge = 71;
bool isAdult = (userAge > 17) ? true : false;

string ticketType = (userAge >= 18) ? "Adult" : "Child";
System.Console.WriteLine(ticketType);

// * Compound Ternary
string otherTicketType = userAge >= 18 ? userAge > 65 ? "Senior" : "Adult" : "Child";
System.Console.WriteLine(otherTicketType);