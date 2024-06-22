# ![semicolon-red][logo-thumbnail] VMatch ![github-readme][app-badge]
A Windows form application that has riddles that reveal a programming problem when solved. The program is timed and records every action performed by the participants. This program is used for programming competitions with a theme of Valentine's Day.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Features
### Main Features
![screenshot-1][start-screen] &nbsp;
![screenshot-2][question-screen]
- **Timer** - Countdown for the competition time limit.
- **Riddle-Problem** - Riddle and problem to answer to proceed to the next step.
- **Upload Solution** - Submit a file with proper naming as a solution.

### Additionl Features
![screenshot-3][close-prevention]
- **Close Prevention** - Prevents program from closing to prevent cheating.
- **Folder Access Restriction** - Restrict participants from accessing the solution and log folder.
- **Action/Time Log** - Records the time of starting, answering, submitting, closing and times-up in a text file.

> [!NOTE]
> The program will create a `~` protected folder in the root directory at launch which will contain the answer files and log.

> [!TIP]
> To access the restricted folder, go to `~` folder security and delete the `Everyone` group.

> [!TIP]
> The program can only be closed by entering `/close` as an answer, ending the task in Task Manager, or waiting for the time limit to expire.

## Installation
### Framework Dependent
1. Download and install the latest version of [.NET][dotnet-framework].
2. Open the [latest release][release-page] of VMatch.
3. Download and extract `VMatch-1.0.0-framework-dependent.zip`.
4. Open the folder and launch `VMatch.exe`.

### Self-contained
1. Open the [latest release][release-page] of VMatch.
2. Download `VMatch-1.0.0-self-contained.exe`.
3. Launch `VMatch-1.0.0-self-contained.exe`.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments
- **[.NET Framework][dotnet-framework]**: For libraries and runtime.
- **[Visual Studio 2022][visual-studio-2022]**: For development environment.
- **[Windows Forms][windows-forms]**: For graphical user interface.

<!-- Reference -->
[logo-thumbnail]: https://github.com/Mindkerchief/VMatch/assets/130748576/a65c7e73-af97-4a10-8954-11e1853c02e2
[app-badge]: https://img.shields.io/badge/Windows-Programming_Competition_Management_System-FFFFFF

[start-screen]: https://github.com/Mindkerchief/VMatch/assets/130748576/3786ca8b-3bcc-4204-ad77-4bd88894f129
[question-screen]: https://github.com/Mindkerchief/VMatch/assets/130748576/2f1a77be-6cc3-4006-86c4-8f9c51a9d931
[close-prevention]: https://github.com/Mindkerchief/VMatch/assets/130748576/0ae2a5ca-fb26-4cd8-bacb-f259217c1136

[release-page]: https://github.com/Mindkerchief/README-MKC-Standard/releases
[dotnet-framework]: https://dotnet.microsoft.com/en-us/download
[visual-studio-2022]: https://learn.microsoft.com/en-us/visualstudio/ide/?view=vs-2022
[windows-forms]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0
