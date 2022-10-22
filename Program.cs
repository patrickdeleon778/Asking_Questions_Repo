bool playAgain = true;
bool playAgainResponse = true;

string userAnswer;

while(playAgain == true)
{
    playAgainResponse = true;
    Console.Write("What is your name: "); // the user is asked what their name is

    string? userName = Console.ReadLine(); // the user inputs their name

    Console.Write("What time did you wake up today: "); // the user is then asked what time they woke up today

    string? wakeUp = Console.ReadLine(); // the user inputs what time they woke up

    Console.WriteLine($"Your name is {userName} and you woke up at {wakeUp}."); // using string interpolation a sentence was created to tell the user their name and what time they woke up
    //Console.WriteLine("Your name is " + userName + " and you woke up at " + wakeUp + "."); // this is the string concatenation version

    while(playAgainResponse == true)
        {
            Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

            userAnswer = Console.ReadLine().ToUpper();

            if(userAnswer == "Y")
            {
                playAgain = true;
                playAgainResponse = false;
            }
            else if(userAnswer == "N")
            {
                playAgain = false;
                playAgainResponse = false;
            }
            else
            {   
                playAgain = false;
                playAgainResponse = true;
                Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
            }
        }
    }