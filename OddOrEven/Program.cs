

Console.WriteLine("Enter a number");
int userNum = Convert.ToInt32(Console.ReadLine());//Console.ReadLine() tagastab stringi ja seda ei saa salvestada int tüüpi muutujasse, järelikult vaja konverteerida Convert.ToInt32 (eelmine kord oli Int32.Parse, see ka ok)

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

if(result != 0) // != - ei ole võrdne
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("User number is even");
}