using System;
using Test;

while (true)
{
    // create a new instance of the Menu class
    Menu menu = new Menu();
    // call the ShowMenu method and store the result in a variable
    string menuChoice = menu.ShowMenu();

    // if the user pressed the spacebar, start the game against the computer
    if (menuChoice == "Computer")
    {
        string difficulty = menu.difficultyComputer();
        if (difficulty == "escape") return;
        else if(difficulty == "Easy")
        {
            ComputerEasy computerEasy = new ComputerEasy();
            computerEasy.playAgainstEasyComputer();
        }
        else if(difficulty == "Hard")
        {

        }
    }
    // if the user pressed the enter key, start the game against a friend
    else if (menuChoice == "Friend")
    {
        FriendPlay friendPlay = new FriendPlay();
        friendPlay.PlayAgainstFriend();
    }
}
