

// CountTo(5);

// void CountTo(int max) 
// {
// 	for (int i = 0; i < max; i++)
// 	{
// 		Console.Write($"${i}, ");
// 	}
// }

// int[] schedule = { 800, 1200, 1600, 2000 };

// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;

//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }

//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }

//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// // testing varaible scope

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


// // Creating methods to calculate area and circumference 
// decimal pi = 3.14159m;

// PrintCircleInfo(9);
// PrintCircleInfo(18);

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// void PrintCircleArea(int radius)
// {
//     decimal area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     decimal circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// //********pass by value

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// //*********pass by reference

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }


// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

//***** RSVP to an event(confirm attendence)

// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);// named parameter, arguement are passed by name so order doesnt matter
// RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);// tony is a positional argument but other named arguments dont have to be in order
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Dragon fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)// optional parameter
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (found == false)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }
//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }


// Variable params using keyword "parmas" 
string my1stLine = "This is my first Line";  
string my2ndLine = "This is my second Line";  
string my3rdline = "This is my Third Line";  
string my4thline = "This is my fourth Line";  
PrintPassedList(my1stLine, my2ndLine, my3rdline, my4thline); 


void PrintPassedList(params string[] listToPrint)
{
  foreach(var item in listToPrint)
  {
    Console.WriteLine(item);
  }
}