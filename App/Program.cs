// C# Exercises from the Microft Certification

// Dice Game

// Here we create a new instance of the System.Random class and store a reference to the object in a variable name dice.
// Then we call the Random.Next() Method three times, proving both lower and upper bounds to restrict the possible values between 1 and 6


Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
 
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if( (roll1 == roll2 ) || (roll2 == roll3) || (roll1 == roll3)){

    if ((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}else{
     Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
   
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

// Subscription 
Console.WriteLine("Subscription")
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
};

// Implement the foreach statement

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach ( int items in inventory ){
    sum += items
};

Console.WriteLine($"We have {sum} items in inventory.")


// Fraudulent Challenge

Console.WriteLine("Fraudulent Challange")
string[] IDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach( string id in IDs ){
    if (id.StartsWith("B")){
        Console.WriteLine("The name starts with 'B'! ");
    }
};

// Score Arrays Challenge 

int[] examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentsNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

foreach (string name in studentsNames){
    string currentStudent = name;

    if ( currentStudent == "Sophia" ){
        studentScores = sophiaScores;

        else if( currentStudent == "Andrew" ){
            studentScores = andrewScores;
        }
        else if( currentStudent == "Emma" ){
            studentScores = emmaScores;
        }
        else if( currentStudent == "Logan" ){
            studentScores == loganScores;
        }
        
    }

    int sumAssignmentScores = 0;
    decimal currentStudentGrade ;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

       
    int gradedAssignments = 0;

    foreach (int score in studentScores){
            // sum up all the scores Sophia
        gradedAssignments += 1;
        if( gradedAssignments <= examAssignments){
            sumAssignmentScores += score
        }
        else{
            sumAssignmentScores += score / 10;
        }
        
    };

        currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{currentStudent}: \t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

    }


// ADDING LOGIC TO CONSOLE APPLICATIONS

    // Random coin toss - practising conditional operator

        Random coin = new Random();
        int flip = coin.Next(0, 2);
        Console.WriteLine((flip == 0) ? "heads" : "tails");

        // OR

        Random coin = new Random();
        Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");


    // DECISION LOGIC CHALLENGE

        string permission = "Admin|Manager";
        int level = 55;

        if ( permission.Contains("Admin")){
            if(level > 55){
                Console.WriteLine("Welcome, Super Admin user.")
            }else{
                Console.WriteLine("Welcome, Admin user.")
            }

        }elseif (permission.Contains("Manager")){
            if(level >= 20){
                Console.WriteLine("Contact an Admin for access.")
            }else{
                Console.WriteLine("You do not have sufficient priviledges")
            }
        }else(
                Console.WriteLine("You do not have sufficient priviledges")
            )
// Variable scope challenge

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach ( int number in numbers )
    int total;
    total += number;
    if ( number == 42 )
        bool found = true;
    


if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {totals}")


// Implementing the switch statement

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel){
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;

}
Console.WriteLine($"{employeeName}, {title}");

// Using the for loop 

for (int i = 0; i < 10; i++){
    Console.WriteLine(i)
}
    // loop through each element of an array

    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = names.Length - 1; i >= 0;  i--){
        Console.WriteLine(names[i]);
    }

// FizzBuzz challenge

for (int i = 0; i <= 100; i++)
    if(i % 3 == 0 && i  % 5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    elseif(i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    elseif(i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine(i);

// do-while

// This loop will continue to generate random numbers between 1, 10 as long the number is not 7. If its 7, it breaks

Random random = new Random();
int current = 0;
 
do{
    current = random.Next(1, 11);
    Console.WriteLine(current);

} while ( current != 7 );



// while loop

Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3){
    Console.WriteLine(current);
    current = random.Next(1, 11);

}

// Role Playing game battle challenge

int hero = 10;
int monster = 10;

Random random = new Random();

do{
    int roll = random.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} and now has {monster} health.");

    if ( monster <= 0 ) continue;

    roll = random.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while ( hero > 0 && monster > 0);

Console.WriteLine( hero > monster ? "Hero wins!" : "Monster wins!" );


// PROJECT 1

// Differentiate between do and while statements
// Validate user input

int value?;
bool validEntry = false;
Console.WriteLine("Enter a number between 5 and 10")

do{
    value = Console.ReadLine():
    if( value != null)
        if ( ( value >= 5 ) && ( value <= 10 ) )
            validEntry = true;
            Console.WriteLine($"Your input value ({value}) has been accepted")
        else 
                Console.WriteLine("Your input is incorrect, make sure you enter a value between 5 and 10");
}while (validEntry == false);


// PROJECT 2 
// Validate a string

string? readResult;
string roleName = "";
bool validEntry = false;

do{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();

    if ( readResult != null ){
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }
}while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
    


// PROJECT 3
// Process a string array 


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

for ( int myString = 0; myString < myStrings.Length - 1; myString++ )
    int period = myString.indexOf(".");
    if ( period != null )
        Console.WriteLine(period);
    else   
        Console.WriteLine(-1);

    


Console.WriteLine("Press the enter key to continue");
Console.ReadLine()

// 


