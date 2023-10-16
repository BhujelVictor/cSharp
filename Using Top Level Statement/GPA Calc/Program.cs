

class Text
{
    public static void Main(string[] qwe)
    {
        // char letter = 'A';
        // char digit = '1';
        // char symbol = '@';
        // string firstName = "Saugat";
        // string lastName = "Bhujel";
        // string phoneNumber = "+977-9870923441";
        // Console.WriteLine("Name: {0} {1} and phone_number: {2}", firstName, lastName, phoneNumber);
        // Console.WriteLine("Hello\nWorld!");
        // Console.WriteLine("Hello\tWorld!");
        // Console.WriteLine("Hello \"World\"!");
        // Console.WriteLine(@"   c:\source\repos
        //                         (this is where your code goes)");// using verbatim string '@' to escape \ which also keeps whitespace
        // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");//kon'nichiwa World using \u escape sequence (UFT-16)

        // // To generate Japanese invoices:
        // // Nihon no seikyū-sho o seisei suru ni wa:
        // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // // User command to run an application
        // Console.WriteLine(@"c:\invoices\app.exe -j");

        // int value = 1;
        // value++;
        // Console.WriteLine("First: " + value);
        // Console.WriteLine($"Second: {value++}");//value is printed then incremented
        // Console.WriteLine("Third: " + value);
        // Console.WriteLine("Fourth: " + (++value));//value is incremented then printed
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        Console.WriteLine($"Student Name :{studentName}");
        Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

        int totalCreditHours = 0;
        totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

        int totalGradePoints = 0;

        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        Console.WriteLine($"{totalGradePoints} {totalCreditHours}");
        decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;
        Console.WriteLine($"Your GPA is {gradePointAverage}");
        
        int leadingDigit = (int) gradePointAverage;
        int firstDigit = (int) (gradePointAverage * 10) % 10;
        int secondDigit = (int) (gradePointAverage * 100) % 10;
        Console.WriteLine($"Your GPA is {leadingDigit}.{firstDigit}{secondDigit}");
        

    }
}