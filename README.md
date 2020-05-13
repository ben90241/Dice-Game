# dice_game
Summary: Dice Rolling, Forms, Menus, AI

This is a two player game, each player takes turns rolling a single six sided die.

When a player's turn starts. They should only have one option, to click the Roll button. The Stand button should be disabled. Upon clicking the Roll button, a random value between 1 and 6 inclusively needs to be created and displayed to the user.
If the roll is a 1, the players turn is over and the turn passes, no score for the round..
If the roll is 2 - 6, the player addes the value of the die to the turn total. After adding the die to the turn total, the player can then choose to roll again or stand.
If they roll again, repeat the check above and continue adding to the turn total.
If they choose to stand, add the turn total to the game total for the player and pass the turn to the next player.

A rough mock-up is attached and shows about what the game could look like.

The game needs to support a menu with the following options.
Exit - Closes the form.
New Game - Resets the game to the beginning.

A players menu with Set player 1 name, set player 2 name, and set number of players. The number of players can be 1 or 2.

In a two player game, two human players will play against each other.
In a one player game, the AI will play for the second player, the behavior of the AI is to roll until their turn ends on a 1, or their turn total is 20 or more.

When the AI is playing, the game needs to pause for a second or two between roles so that the human player can see what is happening.

The game ends at 100 or more, when the game ends, show a message box that indicates the game is over and which player that won.
