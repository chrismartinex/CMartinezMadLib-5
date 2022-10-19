//Chris Martinez
//10/18/22
//Mad Lib - Revamp 
//GitHubChallenge 
// I re focus energy in addressing comments, from original submission during combine. 
// I did data validation, and re space my code, along with adding more psedudo code, to my program, 
//now that this program will be leaving in the github.

Console.Clear();
string vamosJugar = "yes";
while (vamosJugar != "no")
{
    Console.WriteLine("Lets play a game, call Mad Lib!");
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");
    Console.WriteLine("Rules: type in a word: will turn it into a Fairy Tale!");
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");
    Console.WriteLine("Ready, Set, Go!");
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    //user inputs for story to run!
    Console.WriteLine("Enter a Weather type:");
    string wheather = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Day of the week:");
    string day = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Time/part of the day:");
    string time = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter a National Park:");
    string natPark = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter a Celebrety name:");
    string celeb = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter a Superhero:");
    string superHero = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter a Dessert:");
    string dessert = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter a Country:");
    string country = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("Enter a Beer:");
    string beer = Console.ReadLine();
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    //the template for the story:
    Console.WriteLine("This is your fabolous little tale:");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    Console.WriteLine("");
    Console.WriteLine($"Once upon a time, on a {wheather} {day} {time}.");
    Console.WriteLine($"I was goofing off, on the {natPark} National Park. When I ran into {celeb}.");
    Console.WriteLine($"He asked what my name was?. I said my name was: {name}, and who my favorite superhero was, {superHero}.");
    Console.WriteLine($"{celeb} look at me?!!, and laughed in my face. I started to cry.");
    Console.WriteLine($"I soon realize the 5 hours of traveling to {country}, had affected my rationale, and I was Dreaming!");
    Console.WriteLine($"so instead I asked the flight attended for more {dessert} and took another hard sip of my good old {beer}.");
    Console.WriteLine("");

    Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");

    //Console.WriteLine("END OF THE ROW!\N");

    //this prompt will loop user to play once more or end game.
    Console.WriteLine("Press anywhere to RE-PLAY or type NO....");
    vamosJugar = Console.ReadLine().ToLower();
}
Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");
Console.WriteLine("FAREWELL, AMIGO!!!");
Console.WriteLine("<><><><><><><><><><><>><><>><<><><>");