/*
* Name: Your Desmond Goldberg
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

//Part 1
Console.WriteLine("Please state your name: ");
string? fullName = Console.ReadLine();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
fullName = fullName.Trim();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
fullName = fullName.ToUpper();
string firstInitial = firstName.Substring(0, 1);
string lastInitial = lastName.Substring(0, 1);
string username = $"{firstInitial}{lastName}";
int lastNameLength = lastName.Length;
Console.WriteLine("Name on Badge: " + fullName);
Console.WriteLine($"Username: {username}");
Console.WriteLine("Initials: " + firstInitial.ToUpper() + "." + lastInitial.ToUpper() + ".");
Console.WriteLine("Letters in Last Name: " + lastNameLength);

// //Part 2
Random rng = new Random();
int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentId}");
Console.WriteLine($"Locker: {lockerNumber}");

//Part 3
Console.WriteLine();
Console.WriteLine("What is the dorms x coordinate?");
double dormXCoordinate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the dorms y coordinate?");
double dormYCoordinate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the classrooms x coordinate?");
double classroomXCoordinate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the classrooms y coordinate?");
double classroomYCoordinate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the students walking speed in feet per second?");
double studentWalkSpeed = Convert.ToDouble(Console.ReadLine());
double x1 = dormXCoordinate;
double x2 = classroomXCoordinate;
double y1 = dormYCoordinate;
double y2 = classroomYCoordinate;
double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
double timeWHoleSeconds = distance / studentWalkSpeed;
timeWHoleSeconds = Math.Round(timeWHoleSeconds, 0);
int timeMinutes = Convert.ToInt32( timeWHoleSeconds / 60);
int timeSeconds = Convert.ToInt32( timeWHoleSeconds % 60);
Console.WriteLine("Distance: " + distance.ToString("F1"));
Console.WriteLine($"Walk Time: {timeMinutes} minutes {timeSeconds} seconds");

//Part 4
int checkDigit = studentId % 9;
string finalID = $"{studentId}-{checkDigit}";
char idBarsChar = '=';
int barCharRepeat = 34;
string idBars = new string(idBarsChar, barCharRepeat);
string space = "";
Console.WriteLine();
Console.WriteLine(idBars);
Console.WriteLine($"{space.PadRight(8)}ETSU STUDENT BADGE");
Console.WriteLine(idBars);
Console.WriteLine($"NAME{space.PadRight(6)}{fullName}");
Console.WriteLine($"USERNAME{space.PadRight(2)}{username}");
Console.WriteLine($"ID{space.PadRight(8)}{finalID}");
Console.WriteLine($"LOCKER{space.PadRight(4)}{lockerNumber}");
Console.WriteLine($"WALK{space.PadRight(6)}{timeMinutes} min {timeSeconds} sec");
Console.WriteLine(idBars);
Console.WriteLine();