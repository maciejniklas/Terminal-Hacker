using UnityEngine;

public class Hacker : MonoBehaviour
{
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
        else if(input == "007")
        {
            Terminal.WriteLine("Please select a level Mr.Bond.");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level!");
        }
    }

    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you to hack into?");
        Terminal.WriteLine("Press 1 for the local library.");
        Terminal.WriteLine("Press 2 for the police station.");
        Terminal.WriteLine("Press 3 for NASA.");
        Terminal.WriteLine("Enter the selection:");
    }
}
