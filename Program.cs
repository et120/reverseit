// Name: Elizabeth Trotter 

// Date Revised: 9/14/2023

// Exercise: Mini Challenge # 7 - Reverse It 

// Brief Description: Create a brand new console project that takes a sequence of numbers and reverses them. The user will enter the numbers. 
// Display the original number before the reversed. Validation Required.
// Extra Credit: string values and number values

// Peer Reviewer: Bainan Menchaca-Ortiz
// Peer Comments: Code runs good and well organized with the format. The flow chart is great as well very descriptive and i can see what the code in the specific order is going to use.

Console.Clear();

string title = "Mini Challenge # 7 - Reverse It";
Console.WriteLine(title);
string breakPoint = "--------------------------------";
Console.WriteLine(breakPoint);

Console.WriteLine("INSTRUCTIONS: Today, we're playing a game called Reverse It. Please follow the prompts below.");
Console.WriteLine(breakPoint);

bool playAgain = true;
while (playAgain)
{
    Console.WriteLine("Please enter in a combination of some numbers below: **BONUS - Try letters as well!**");

    string userInput = Console.ReadLine() ?? "";
    int index = userInput.Length - 1;

    Console.WriteLine(breakPoint);
    Console.WriteLine("Here are your characters in order and then reversed: ");

    for (int i = index; i >= 0; i--)
    {
        userInput += userInput[i];
    }
    Console.WriteLine(userInput);

    bool formatAns = true;
    while (formatAns)
    {
        Console.WriteLine(breakPoint);
        Console.WriteLine("Would you like to play again? (Enter yes or no)");
        string? playerAns = Console.ReadLine()?.ToLower();
        if (playerAns == "yes")
        {
            formatAns = false;
        }
        else if (playerAns == "no")
        {
            playAgain = false;
            formatAns = false;
            Console.WriteLine("Okay, sounds good.");
            Console.WriteLine(breakPoint);
        }
        else
        {
            Console.WriteLine(breakPoint);
            Console.WriteLine("I didn't get that...");
        }
    }
}

// EXTRA CREDIT
Console.WriteLine("EXTRA CREDIT");
Console.WriteLine("Before you go though... Let's try the game one more time to show that I can do math with integers!");
bool playAgain2 = true;
while (playAgain2)
{
    Console.WriteLine("Please enter a number: ");
    string? input = Console.ReadLine();
    int userNum;
    int reverse = 0;
    bool success = Int32.TryParse(input, out userNum);

    if (success)
    {
        Console.WriteLine($"Thanks, you entered: {userNum}");
        while (userNum != 0)
        {
            reverse = reverse * 10;
            reverse = reverse + userNum % 10;
            userNum = userNum / 10;
        }
        Console.WriteLine($"Your reversed number is: " + reverse);

        bool formatAns2 = true;
        while (formatAns2)
        {
            Console.WriteLine(breakPoint);
            Console.WriteLine("Would you like to play again? (Enter yes or no)");
            string? playerAns2 = Console.ReadLine()?.ToLower();
            if (playerAns2 == "yes")
            {
                formatAns2 = false;
            }
            else if (playerAns2 == "no")
            {
                playAgain2 = false;
                formatAns2 = false;
                Console.WriteLine("Have a good day!");
                Console.WriteLine(breakPoint);
            }
            else
            {
                Console.WriteLine(breakPoint);
                Console.WriteLine("I didn't get that...");
            }
        }
    }
    else
    {
        Console.WriteLine(breakPoint);
        Console.WriteLine("I didn't get that...");
    }
}

