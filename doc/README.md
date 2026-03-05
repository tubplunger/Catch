Catch is a simple game where the player catches falling objects from the sky, earning a point with each object that is caught before hitting the ground. If an object does hit the ground though it'll disappear and instead change the miss counter. When the player runs out of misses the game is over and they can either restart or exit the game.

The player is restricted to moving left and right so that the game is easier to control. Above the player, balls spawn in the same area using a random interval of spawning and spread. If one of the balls collide with the player it'll disappear and the player earns a point, which is shown in the UI. On the other side, when one of the balls hit the ground instead it'll also disappear but cause the miss counter to go down. When the miss counter hits 0 that is game over, pausing spawning and player movement so the player can either restart or quit the game.

To run the game, simply open the executable file within src/game and it should open up on Linux.

For improvements I want to do: adding more interesting visuals rather than default Unity assets, adding in sound so the game isn't completely silent all the time, and overtime have the difficultly increase so that it becomes more of a challenge as time goes on.
