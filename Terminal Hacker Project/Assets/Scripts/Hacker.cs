using UnityEngine;

public class Hacker : MonoBehaviour
{
    private void Start()
    {
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        Terminal.ClearScreen();

        string greeting = "Hello Hacker!";
        Terminal.WriteLine(greeting);

        Terminal.WriteLine("What would you to hack into?");
        Terminal.WriteLine("Press 1 for the local library.");
        Terminal.WriteLine("Press 2 for the police station.");
        Terminal.WriteLine("Press 3 for NASA.");
        Terminal.WriteLine("Enter the selection:");
    }
}
