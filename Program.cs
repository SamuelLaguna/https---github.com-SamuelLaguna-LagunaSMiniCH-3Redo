//Samuel Laguna
//10-19-22
//

bool playAgain = true;
bool end = false;


while(playAgain == true){
Console.WriteLine("What food do you like?");
string theFood = Console.ReadLine();
if (theFood == "Pizza"){
    Console.WriteLine("Oh I like pizza to but prefer mexican.");
}

Console.WriteLine("What is your favriote football team?");
string theTeam = Console.ReadLine();
if (theTeam == "Raiders"){
    Console.WriteLine("Oh I like that team to");
}
string ending = Console.ReadLine();
   if (ending == "end"){
    playAgain = false;
   
   }else

    {
        end = true;
    }

}