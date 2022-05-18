/*
!   While Loop
    - Continues to loop while a condition is true
*/

int total = 1;
while (total != 10) //if total is not equal to 10, it will execute the block of code within the cruly brackets {}
{
    //will run if total is not 10
    System.Console.WriteLine(total);
    total = total + 1; //for each iteration, we update the value of total
}

total = 0; // reset total  since its outside of the while condition
while(true) // passing a "true" will allow us to run this loop
{
    if(total == 10) // once total is equal to 10, this will execute our WriteLine and break from our loop
    {
        System.Console.WriteLine("Goal Reached");
        break;
    }

    total ++; // add 1 to the current value of our variable "total"
}

bool isOn = true; 
int time = 1;
while(isOn)
{
    System.Console.WriteLine("The light is on");
    if(time == 7)
    {
        isOn = false;
        System.Console.WriteLine("The light is off");
    }
    time++;
}

Random rando = new Random(); // C# offers a random number object based off time in miliseconds. 
int someNum;
bool keepLooping = true; 
while (keepLooping)
{
    someNum = rando.Next(1, 21); // Next() is how we call that new number from out Random object
    // - Next(min value, max value +1) - if you want the range to be 1-20 the max value would be 21. for 30-100 max value would be 101.

    if(someNum == 15 || someNum == 8)
    {
        System.Console.WriteLine("Skipped!");
        continue;
    }

    System.Console.WriteLine("RANDOM: " + someNum);
    if(someNum == 10)
    {
        keepLooping = false;
    }
}


/*
!   For Loops 
    - checks a value, compares our condition, and possibly changes the value we check against
*/

int studentCount = 21;
for(int i = 0; i < studentCount; i++) // i is our starting value, if condition is true, executes code within { }
{
    System.Console.WriteLine("For loop: " + i); // concatination 
}

for(int i = 0; i != 15; i = rando.Next(1,21))
{
    System.Console.WriteLine($"Random Number: {i}"); // interpolation 
}

string[] students = {"Deron", "Andra", "Braeden", "Connor", "Liz" };
for(int i = 0; i < students.Length; i++)
{
    System.Console.WriteLine(students[i]);
}

//! Challenge
/*
- Write a for loop that counts from 0 to 100.
        - For each iteration, If the number (i) is divisible by:
            - 3: WriteLine "Fizz"
            - 5: WriteLine "Buzz"
            - Both 3 & 5: WriteLine "Fizz Buzz"
        - Otherwise, just print the value of the number.
*/

int loopChallenge = 100;
for(int i = 0; i <= 100; i++)
{
   if(i % 5 == 0 && i % 3 == 0) // saying i % 5 == 0 is basically saying as long as the number is EQUALLY divided by 5 without a remainder the code will execute
   {
       System.Console.WriteLine("Fizz Buzz");
   }

   else if(i % 3 == 0)
   {
       System.Console.WriteLine("Fizz");
   }
   else if(i % 5 == 0)
   {
       System.Console.WriteLine("Buzz");
   }
   else
   {
       System.Console.WriteLine(i);
   }
}


/*
!   ForEach Loops
    - A simplier way to possibly write loops
    - we can cycle through an array
*/

// foreach(string student in students)
// {
//     System.Console.WriteLine($"{student} is a student in the class");
// }

// string fullName = firstName + ' ' + lastName;
// foreach(char letter in fullName)
// {
//     if(letter != ' ')
//     {
//         System.Console.WriteLine(letter);
//     }
// }

/*
!   Do While Loops
    - does at least 1 iteration of a loop and THEN checks the while condition
*/

int iterator = 0;
do{
    System.Console.WriteLine("hello");
    iterator++;
} while (iterator < 5);

if(iterator == 5)
{
    System.Console.WriteLine("its five");
}