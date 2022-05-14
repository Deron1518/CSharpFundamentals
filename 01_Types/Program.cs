// ! Comments 
/* 
    -Clarify Code
    -Reference
    -Communicate to other developers/future me
    -Track history
*/

//Single line 
/*
    Multi Line
*/

/*
    ! Solution File (SLN)
    When we creat a solution file, the basic implementation of the command will grab the name of the parent directory and assign it to the solution it is generating.
        - In our case: dotnet new sln = cSharpFundamentals 
        - Two ways to start it:
            - dotnew new sln -n (file name)
            - dotnet new sln (while inside folder)

    The solution will go on to froup together the bulk of our notes 

    What's in the package?
        - cproj: CSharp project file - holds the SDK (Software Dev Kit) for us to run our projects.
        - obj [folder]: various packages that help our code run (not a high concern atm
        - cs: Where we write our code
*/

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
    ! Variables 

    datatype variableName  = value; 
    - Must start with datatype and be a given name.
    - Doesn't need to be assigned a value right away.

*/

/*
!   Booleans
    - bool: 1 byte 
        - stores true/false value 
*/

bool isDeclared = true; 
bool isnotDeclared;
// Console.WriteLine(isnotDeclared); // Breaks our build bc a default is not provided 

isnotDeclared = false; 
// cw - console.writeline shortcut 
System.Console.WriteLine(isnotDeclared);

/*
!   Characters 
    - char = 2 bytes 
        - Stores sinfle character/letter, surrounded by a single quote ' '
        - DO NOT PUT MULTIPLE CHARACTERS 
*/

char character = 'a';
char symbol = '?';
char number = '7';
char whitespace = ' ';
char specialCharacter = '\n';
// \n break line

/*
!   String 
    - string: 2 bytes per character 
        - Stores a sequenece of characters, surrounded by double quotes " "

*/

string stringSample = "Sample Text";
System.Console.WriteLine(stringSample);

/*
!   Numbers
        - int: 4 bytes 
        - long: 8 bytes 
*/

byte byteExample = 255; //anything between 0 -255 due to binary code 
sbyte sByteMin = -128; // b/n -128 through 127 (128 x 2 while accounting for 0)
short shortExample = 32767; // max 
int intMin = -2147483648; // same as a Int32
Int32 intMax = 2147483647; // fits a 32 bit 
long longExample = 9223372036854775807; // same as an Int64
Int64 longMin = -9223372036854775808; // same as a long

byte numByte = 25;
System.Console.WriteLine(numByte);

//* casting:
System.Console.WriteLine((char) numByte); // translating the byte into a character. This changes the value into the list of characters 
System.Console.WriteLine((long) numByte); 

/*
!   Decimals 
        - float: 4 bytes 
            - stores fractional numbers. Sufficient for setoring 6 to 7 decimal digits
        - double: 8 bytes 
            - stores up to 15 decimal digits
*/

float floatExample = 1.0443534f; // Be sure to end with f to indicate to the program we're using a float value 
double doubleExample = 1.73245463456345d; // double the value of a float
double defaultDouble = 198271; // when referring decimal numbers, this is the default expectation and doesn't require a 'd'. For consistency, it is best to place it.
decimal decimalExample = 1.248372628472727484927328m; // highest form of a number. typically used for currency. we use a 'm' to detail that this value is meant for a deciaml

System.Console.WriteLine("Float: " + 1.248372628472727484927328f);
System.Console.WriteLine("Double: " + 1.248372628472727484927328d);
System.Console.WriteLine("Decimal: " + 1.248372628472727484927328m);

/*
!   Structs 
    Data Structures 

*/

int age = 42;
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

DateTimeOffset todayUTC = DateTimeOffset.Now; 
System.Console.WriteLine(todayUTC);

DateTime birthday = new DateTime(1997, 12, 29);
System.Console.WriteLine(birthday);