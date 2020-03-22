using UnityEngine;

public class Hacker : MonoBehaviour
{
    private void Start()
    {
        ShowMainMenu("Hello Hacler!");
    }

    private void OnUserInput(string input)
    {
        Debug.Log(input == "1");
    }

    private void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();

        Terminal.WriteLine(greeting);

        Terminal.WriteLine("What would you to hack into?");
        Terminal.WriteLine("Press 1 for the local library.");
        Terminal.WriteLine("Press 2 for the police station.");
        Terminal.WriteLine("Press 3 for NASA.");
        Terminal.WriteLine("Enter the selection:");
    }
}
