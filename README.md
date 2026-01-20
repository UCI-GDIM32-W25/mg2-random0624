[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
I reviewed the Week 2 slides, revisited the Main scene, and traced how Player, Coin, and PlayerUI class interact with each other. Player handles movement input plus collision checks that trigger OnTriggerEnter2D() to tally coins. Coin controls each object_coin prefab’s behavior, while PlayerUI updates the point UI text. My initial plan emphasized making hard-coded spawn points and a single coin sprite work properly. After examining the professor’s reference plan and experimenting, I was able to figure out how to clone coins properly and delete its instance when picked up by the player.  I also made sure GameObjects with Rigidbody2D and CapsuleCollider2D components have consistent collisions. The coin and penguin both uses a capsule collider to make collisions more accurate and precise. I also made sure IsTrigger is on for the coin prefab, because it has to interact with the player.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites