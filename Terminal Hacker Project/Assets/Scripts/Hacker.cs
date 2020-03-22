﻿using UnityEngine;

public class Hacker : MonoBehaviour
{
    private enum Screen { MainMenu, WaitingForPassword, WinScreen };

    private int level;
    private Screen currentScreen;

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
    }

    private void RunMainMenu(string input)
    {
        if (input == "1" || input == "2" || input == "3")
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

    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you to hack into?");
        Terminal.WriteLine("Press 1 for the local library.");
        Terminal.WriteLine("Press 2 for the police station.");
        Terminal.WriteLine("Press 3 for NASA.");
        Terminal.WriteLine("Enter the selection:");
        currentScreen = Screen.MainMenu;
    }

    private void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password:");
        currentScreen = Screen.WaitingForPassword;
    }
}
