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


Console.WriteLine("Press the enter key to continue");
Console.ReadLine()

// 


