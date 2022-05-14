/*
!   Value Types vs Reference Types 
    - Value types: have a specific size, and stored in stack memory
    - Reference Types: have a variable size, and stored in heap memory 

*/

//! Strings 
string someString;
string intialized = "this is initialized";

string firstName = "Joe";
string lastName = "Schmoe";

string fullname = firstName + ' ' + lastName; // '  ' basically acts like a space
System.Console.WriteLine(fullname);

//* interpolation
string interpolationFullName = $"{firstName} {lastName}";
System.Console.WriteLine(interpolationFullName);

/*
!   Collections
    A string is technically a collection (of character)
*/

//* Array
char firstLetter = firstName[0]; // the 0 targets the J in Joe. 1 would be the O.
System.Console.WriteLine(firstLetter);

string extraItem = "another string";
//                          0       1       2       3       4           5               6
string[] stringArray = {"Hello", "World", "why", "is it", "always", "Hello World?", extraItem};
System.Console.WriteLine(stringArray[1]);
// by saying stringArray[1] that targets the World in the code above. first word counts as 0.

/*
     We define the type with square brackets. The only brackets will detail the information within that array. Arrays do have a fixed sized determined on how they are created.
    
    Targeting index within an array we always start with the posistion of zero
*/
System.Console.WriteLine(stringArray[6]);
int lengthValue = stringArray.Length;
System.Console.WriteLine(lengthValue); // comes out as 7 here
System.Console.WriteLine(stringArray[stringArray.Length - 1]); // was able to target the last item in the array 

//* List
List<string> listOfStrings = new List<string>();
listOfStrings.Add("Hello");
listOfStrings.Add("World");
/*
    A list is part of a class that is built into C# which allows us various methods to manipulate it
*/

List<int> listOfInts;

/*
* Queue
    - First in / First out
*/

Queue<string> firstInFirstOut = new Queue<string>();
firstInFirstOut.Enqueue("Im first");
firstInFirstOut.Enqueue("Im next");
System.Console.WriteLine(firstInFirstOut.Peek()); //Peek() is a method that allows us to view what item is first in a queue.
firstInFirstOut.Dequeue(); //We are using this method to remove the item currently in the first position.
System.Console.WriteLine(firstInFirstOut.Peek()); //The second string was shown as the first was removed.

/*
*  Dictionaries
    - A collection where we are assigning a key to a value pair.
*/
Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

keyAndValue.Add(21, "legal drinking age");
keyAndValue.Add(18, "legal voting age");
keyAndValue.Add(19, "legal voting age");
System.Console.WriteLine(keyAndValue[21]); // we can target a key just like we target an index value in an array.
// The values can be the same; however you cannot use the same key for different values

Dictionary<string, string> stringDictionary = new Dictionary<string, string>();
stringDictionary.Add("Triangle", "the set of all points in a plane defined by the area within three points.");