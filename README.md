# Space Shooter Game Enhancements

[Play the game on Itch IO](https://kg-proj.itch.io/spaceship).

<div style="display: flex;">
    <img src="https://github.com/GiniProj/HW_Week3_Part1-Spaceship-AG/blob/main/FirstLevelPicture.png" alt="FirstLevelPicture" width="400" height="200">
    <img src="https://github.com/GiniProj/HW_Week3_Part1-Spaceship-AG/blob/main/GameOverPicture.png" alt="GameOverPicture" width="400" height="200">
</div>

## Introduction
This project enhances the existing Space Shooter game by implementing the following features:
1. **Shooting Cool Down**: Added feature to any class that inherit from ClickSpawner to have a cool down before the next spawn, or not cool at all, default is 0.5 sec cool down, therefore shooting that spawn every click on backspace can shoot only every half a sec. 
2. **Player Position Transition at Next Level and Game Over Enhancements**: I added the option to change the `gotoNextLevel` position relative to the object's last position or independently. Additionally, the Game Over scene has been updated to exclude the player and include a UI score that updates according to the `game_status` class, featuring an improved UI design.
3. **Modified Spawn Position and velocity**: Changed the game property to be more exciting, enemy spawn and direction movements.

## References Implementations

### ClickSpawner.cs Update Function
The `Update` function in `ClickSpawner.cs` is responsible for spawning objects when the assigned key is pressed and handling the cooldown period. You can view the function [here](https://github.com/GiniProj/HW_Week3_Part1-Spaceship-AG/blob/main/Assets/Scripts/2-spawners/ClickSpawner.cs#L37).

### TextScoreUpdate.cs Script
The `TextScoreUpdate` script updates the displayed score in the Game Over scene. You can view the script [here](https://github.com/GiniProj/HW_Week3_Part1-Spaceship-AG/blob/main/Assets/TextScoreUpdate.cs).

### GotoNextLevel.cs Script
The `GotoNextLevel` script handles transitioning to the next level and positioning. You can view the script [here](https://github.com/GiniProj/HW_Week3_Part1-Spaceship-AG/blob/main/Assets/Scripts/4-levels/GotoNextLevel.cs).

---

## Information:

* Files and farther explanation in here:
[here](https://github.com/gamedev-at-ariel/gamedev-5782/blob/master/04-unity-triggers/homework.pdf)

A project with step-by-step scenes illustrating some of the formal elements of game development in Unity, including: 

* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.

Text explanations are available 
[here](https://github.com/gamedev-at-ariel/gamedev-5782/04-unity-triggers) in folder 04.

## Cloning
To clone the project, you may need to install git lfs first (if it is not already installed):

    git lfs install 

To clone faster, you can limit the depth to 1 like this:

    git clone --depth=1 https://github.com/<repository-name>.git

When you first open this project, you may not see the text in the score field.
This is because `TextMeshPro` is not in the project.
The Unity Editor should hopefully prompt you to import TextMeshPro;
once you do this, re-open the scenes, and you should be able to see the texts.

---

## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
