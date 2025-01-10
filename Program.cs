
//Die Text variable "correctPassword" wird auf 2002 festgelegt
string correctPassword = "2002";
//Die Ganzzahlen variable "maxAttempts" wird auf 3 festgelegt 
int maxAttempts = 3;
//Die Ganzzahlen variable "remainingAttempts" wird auf maximale Versuche festgelegt
int remainingAttempts = maxAttempts;
//Der bool für die Überprüfung des Passworts wird auf false festgelegt
bool isSuccessful = false;

//Konsolen Design
Console.Title = "PasswordChecker coded by Nassim Berkia";
Console.ForegroundColor = ConsoleColor.Cyan;

//Konsole gibt den Benutzer Informationen über eine Abfrage des Passworts
Console.WriteLine("Welcome to my PasswordChecker!");
Console.WriteLine("Please enter the password (maximum 3 attempts):");

//Die while Schleife läuft solange bis die oben gennante "remainingAttempts" variable null ist
while (remainingAttempts > 0)
{
    //Konsolenschriftfarbe wird für Übersichtlichkeit auf Blau gesetzt
    Console.ForegroundColor = ConsoleColor.Blue;

    //Die Konsole fragt den Benutzer nach der Eingabe des Passworts
    Console.Write("\nPassword: ");
    //Das eingegebende Passwort wird daraufhin in "enteredPassword" als Text abgespeichert
    string enteredPassword = Console.ReadLine();

    //Mit der If-Abfrage prüfen wir ob das eingegebende Passwort richtig ist
    if (enteredPassword == correctPassword)
    {
        //Wenn das Passwort richtig eingegeben wurde wird es vom bool "isSuccessful" auf true festgelegt
        isSuccessful = true;
        //Mit "break" brechen wir aus der while Schleife raus
        break;
    }
    //Wenn das Passwort oben falsch eingegeben wurde wird ein Versuch abgezogen und für den Benutzer kenntlich gemacht
    else
    {
        remainingAttempts--;
        if (remainingAttempts > 0)
        {
            Console.WriteLine($"Incorrect password! You have {remainingAttempts} attempt(s) left.");
        }
    }
}

//Konsolenfarbe wieder auf Türkis für die Übersichtlichkeit
Console.ForegroundColor = ConsoleColor.Cyan;

//Mit dieser If Bedingung wird außerhalb der Schleife geprüft ob der bool "isSuccessful" true ist
if (isSuccessful)
{
    Console.Clear();
    Console.WriteLine("Access granted!");
    Console.ReadKey();
}
else
{
    Console.Clear();
    Console.WriteLine("Access denied! You have used all attempts.");
    Console.ReadKey();
}
