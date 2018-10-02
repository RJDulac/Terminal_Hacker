using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
       
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the community college");
        Terminal.WriteLine("Press 2 for the FBI");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");

    }

    void OnUserInput(string input)
    {
        
        print("The user typed " + input);
        if (input == "1")
        {
            print("You chose level 1");
        }
        else if (input == "2")
        {
            print("You chose level 2");
        }
        else if (input == "3")
        {
            print("You chose level 3");
        }
        else if (input == "menu")
        {
            print("Go back to menu");
            ShowMainMenu();
        }
        else if (input == "007")
        {
            print("Choose your level Mr. Bond!");
        }
        else
        {
            print("Please choose a valid level");
        }
        
    }
}
