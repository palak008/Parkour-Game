# Parkour-Game
A 3D game where the player has to reach a final goal by overcoming the obstacles that come along the way and on reaching the checkpoints the player is allowed to continue the game from the last reached state.

Game Objects used:
* Player (Unity Chan) with movements like jump , walk and body gestures.
* The platform(plane) with tile texture
* A locality is created using sketchup for buildings with appropriate textures. 
* Checkpoints: capsules with additive materials so that the player returns to the check marked position on falling.
* Fall Zone Prefab: plane on which the player falls after collision.
* Trees and water bodies from Standard Assets.
* Goal: A green capsule which marks the end of the scene and gets destroyed on finish.
* Audio source : journey.mp3

Scripts Used:

1. Player.cs: This is script is used for the player movement with the help of arrow keys.
2. Respawn.cs: This script detects the fallzones, and respawns the player on reaching any checkpoint.
3. Background.cs: It is used to display the menu.

