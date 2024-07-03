# ![vmatch thumbnail][vmatch-thumbnail] VMatch ![vmatch badge][vmatch-badge]
A Windows forms application that gives question problems and lets users upload their solution files. The questions are composed of riddles that reveal a programming problem when solved. A timer is active during the runtime and records every action performed by the participants. This program is used for programming competitions with a theme of Valentine's Day.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Features
### Main Features
![main screen][main-screen] &nbsp;
![problem screen][problem-screen]
- **Timer** - Displays the time left during competition.
- **Riddle-Problem** - Reveals the riddles and problems to answer.
- **Upload Solution** - Let the participant submit their solution file.

### Additionl Features
![riddle screen][riddle-screen]
- **Close Prevention** - Prevents program from closing to prevent cheating.
- **Folder Access Restriction** - Restrict participants from accessing the solution and log folder.
- **Action/Time Log** - Records the time of starting, answering, submitting, closing and times-up in a text file.

> [!IMPORTANT]
> The program will create a restricted folder named `answers` inside the `~` folder. This contains the uploaded solution files and time log. To access the restricted folder, go to `answers` folder advance security property, then click continue and remove the `Everyone` group.

> [!TIP]
> The program can only be closed by entering `/close` as the answer, ending the task in Task Manager, or waiting for the time limit to expire.

## Installation
1. Download the latest version of [VMatch][release-page].
2. Install [VMatch-1.0.0.exe][latest-release].

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments
- **[Visual Studio 2022][visual-studio-2022]**: For development environment.
- **[Windows Forms][windows-forms]**: For graphical user interface.
- **[Advanced Installer][advanced-installer]**: For installer.

<!-- Reference -->
[vmatch-thumbnail]: https://github.com/Mindkerchief/VMatch/assets/130748576/c873fee9-611d-4b7c-ac9f-6e61c0fac6a5
[vmatch-badge]: https://img.shields.io/badge/Windows-Programming_Competition_Management-B93931

[main-screen]: https://github.com/Mindkerchief/VMatch/assets/130748576/efac8a7b-9e9c-4051-a664-fed02e86f228
[problem-screen]: https://github.com/Mindkerchief/VMatch/assets/130748576/901b8a48-d7a8-43b8-a897-4902916c6f5c
[riddle-screen]: https://github.com/Mindkerchief/VMatch/assets/130748576/2e1121d9-2e2d-44f0-a2e7-a4711dee75d8

[release-page]: https://github.com/Mindkerchief/VMatch/releases
[latest-release]: https://github.com/Mindkerchief/VMatch/releases/download/v1.0.0/VMatch-1.0.0.exe
[visual-studio-2022]: https://learn.microsoft.com/en-us/visualstudio/ide/?view=vs-2022
[windows-forms]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0
[advanced-installer]: https://www.advancedinstaller.com/user-guide/using.html
