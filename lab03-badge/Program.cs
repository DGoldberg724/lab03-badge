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
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
fullName = fullName.ToUpper();
string firstInitial = firstName.Substring(0, 1);
string lastInitial = lastName.Substring(0, 1);
int lastNameLength = lastName.Length;
Console.WriteLine("Name on Badge: " + fullName);
Console.WriteLine($"Username: {firstInitial}{lastName}");
Console.WriteLine("Initials: " + firstInitial.ToUpper() + "." + lastInitial.ToUpper() + ".");
Console.WriteLine("Letters in Last Name: " + lastNameLength);

//Part 2
Random rng = new Random();
int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentId}");
Console.WriteLine($"Locker: {lockerNumber}");