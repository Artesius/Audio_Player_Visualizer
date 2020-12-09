# Audio Player and Visualizer

## Description

An audio player with ability to analyze any sound going out from selected output device. Written in C#, based on Windows Forms.



## Features

![Player](https://raw.githubusercontent.com/Artesius/Audio_Player_Visualizer/master/pics/MainPlayer.png?raw=true)

- Support most of Audio formats;
- Full-featured Player: Play/Pause/Stop, edit current playlist, move through playlist, change playmode (normal, random, one-song repeat);
- Also support Real-time volume and current song position changes;
- Allows you to save playlist for the next enter;
- Support Drag'n'Drop functionality;

![Visualizer](https://raw.githubusercontent.com/Artesius/Audio_Player_Visualizer/master/pics/MainAnalyzer.png?raw=true)

- Flexible Visualizer - allows you to choose any output device and supports list of visualize options;
- Advanced Visualizer catches not only player output, but anything captured on selected output device;
- Background is also modifiable;



## Usage

"executable" folder contains an .exe file that starts main application. Bass libs required for launch are included in the folder.
Other folders contain sources for both projects.
In order to make things work, you should:
1. Start the .exe file
2. Add songs through "+" button or Drag music files right into the main window
3. Control playback through other buttons.
4. Open visualizer via bottom button
5. Select your current audio output device.
    1. Set everything up to you
6. You're done!



## For Developers

In this project I used library bass.dll to work with sound outputs and to create player functionality.
Chart element and FFT algorithms were used in order to visualize frequencies info.