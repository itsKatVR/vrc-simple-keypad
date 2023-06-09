<div align="center">
    <div class="header">
        <p>
            <h1 style="display:inline;text-size:24px;"> Simple Keypad</h2>
            <span style="float:right">Using UI!</span>
        </p>
    </div>
    <!-- build status badges here thanks -->
    <hr style="width:50%" />
    <br />
    <br />
</div>

![SimpleKeypad](https://github.com/itsKatVR/vrc-simple-keypad/assets/77287432/a26c68f7-dff5-41f1-8503-ec024e4e5241)

## Introduction

Simple Keypad is designed for UdonSharp.

## Requirements
A project with the latest VRChat SDK3 Release- can be found below:

[UDON](https://vrchat.com/home/download) (Udon Worlds Latest Release)

[Udon Sharp](https://github.com/vrchat-community/UdonSharp/releases/tag/v0.20.3)

## Installation

1. Install VRChat SDK3, UdonSharp, and latest release of [Simple Keypad](https://github.com/itsKatVR/vrc-simple-keypad/releases/latest)!
2. Inside of the "SimpleKeypad" Folder you will find the Prefab.
3. Drag Simple Keypad (Prefab) into Scene.

## How it works
Set a passcode, enter passcode.

Temporary Passcode is: 1234

You can click the dropdown for "Users" to specify usernames that will automatically have access to the toggles without the need to input the passcode each time!

How do I know I've entered the correct code? - "ACCESS" will turn Green on valid input, and Red on invalid input.
![SimpleKeypad_UExample](https://github.com/itsKatVR/vrc-simple-keypad/assets/77287432/cdf051a9-43ec-4c3e-85f7-1f966abc487b)

## Customize
Can I change the color? Yes!
Inside of the prefab, after you have unpacked it. 
You can select each Parent Object named 0_Button - Enter_Button,
There should be an "Image" UI element inside each, select all of these- and then modify the color in inspector.

## Something needs fixed?
Sprite Editor! In some projects, it may require you to install 2D Sprite through your Package Manager. If this is the case, please follow steps to install.

Also, note that the Sprite used for the Borders uses a `9, 9, 9, 9` Border setting.

![SimpleKeypad_SpriteExample](https://github.com/itsKatVR/vrc-simple-keypad/assets/77287432/5097f7fa-470b-4b86-8e34-e95b7931c2ec)

```
$ ./That one time at band camp.
```
