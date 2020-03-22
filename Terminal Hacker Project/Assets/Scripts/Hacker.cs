using UnityEngine;

public class Hacker : MonoBehaviour
{
    private enum Screen { MainMenu, WaitingForPassword, WinScreen };

    private int level;
    private Screen currentScreen;
    private string password;

    private string[] level1Passwords =
    {
        "books", "aisle", "shelf", "password", "font", "borrow"
    };
    private string[] level2Passwords =
    {
        "prisoner", "handcuffs", "holster", "uniform", "arrest"
    };

    private void Start()
    {
        ShowMainMenu();
    }

    private void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.WaitingForPassword)
        {
            CheckPassword(input);
        }
    }

    private void CheckPassword(string input)
    {
        if(input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Sorry, wrong password!");
        }
    }

    private void DisplayWinScreen()
    {
        currentScreen = Screen.WinScreen;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    private void RunMainMenu(string input)
    {
        bool isValidLevelNumber = input == "1" || input == "2";
        if(isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr.Bond.");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level!");
        }
    }

    private void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("Have a book...");
                Terminal.WriteLine(@"
    _______
   /      /,
  /      //
 /______//
(______(/
"
                );
                break;
            case 2:
                Terminal.WriteLine("Have a prison key...");
                Terminal.WriteLine(@"
  ooo,    .---.
 o`  o   /    |\________________
o`   'oooo()  | ________   _   _)
`oo   o` \    |/        | | | |
  `ooo'   `---'         | | | |
"
                );
                break;
        }
    }

    private void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;

        Terminal.ClearScreen();
        Terminal.WriteLine("What would you to hack into?");
        Terminal.WriteLine("Press 1 for the local library.");
        Terminal.WriteLine("Press 2 for the police station.");
        Terminal.WriteLine("Press 3 for NASA.");
        Terminal.WriteLine("Enter the selection:");
    }

    private void StartGame()
    {
        currentScreen = Screen.WaitingForPassword;

        switch(level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number!");
                break;
        }

        Terminal.ClearScreen();
        Terminal.WriteLine("Please enter your password:");
    }
}
