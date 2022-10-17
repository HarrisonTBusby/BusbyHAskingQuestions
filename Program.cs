//Harrison Busby
//10/17/2022
//Mini challenge 3 Asking questions
//Create a program that asks you questions and then uses a while loop and data validation. 

string yourName;
string dayTime;
string playAgain = "yes";

while(playAgain == "yes"){

Console.WriteLine("What's your name?");
yourName = Console.ReadLine();
Console.WriteLine("Nice to meet you, " + yourName);

Console.WriteLine("What time did you wake up today");
dayTime = Console.ReadLine();
if(dayTime == dayTime){
Console.WriteLine("So your name is " + yourName + " and you woke up at " + dayTime);
}
Console.WriteLine("Would you like to play again?");
playAgain = Console.ReadLine().ToLower();

if(playAgain == "yes"){
    Console.WriteLine("Lets play again.");
}else{
    Console.WriteLine("Go away.");
}
}