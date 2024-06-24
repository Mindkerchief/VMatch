# ![semicolon-red][logo-thumbnail] VMatch ![github-readme][app-badge]
A Windows forms application that gives question problems and lets users upload their solution files. The questions are composed of riddles that reveal a programming problem when solved. A timer is active during the runtime and records every action performed by the participants. This program is used for programming competitions with a theme of Valentine's Day.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Features
### Main Features
![screenshot-1][start-screen] &nbsp;
![screenshot-2][question-screen]
- **Timer** - Displays the time left during competition.
- **Riddle-Problem** - Reveals the riddles and problems to answer.
- **Upload Solution** - Let the participant submit their solution file.

### Additionl Features
![screenshot-3][close-prevention]
- **Close Prevention** - Prevents program from closing to prevent cheating.
- **Folder Access Restriction** - Restrict participants from accessing the solution and log folder.
- **Action/Time Log** - Records the time of starting, answering, submitting, closing and times-up in a text file.

> [!IMPORTANT]
> The program will create a `~` protected folder in the root directory at launch, which will contain the answer files and time log.

> [!IMPORTANT]
> To access the restricted folder, go to `~` folder security property and delete the `Everyone` group.

> [!NOTE]
> The program can only be closed by entering `/close` as the answer, ending the task in Task Manager, or waiting for the time limit to expire.

> [!TIP]
> Let the participants know that they have to name their answer based on problem number before submitting.

## Installation
### Framework Dependent
1. Download and install the latest version of [.NET][dotnet].
2. Go to the [latest release][release-page] page of VMatch.
3. Download and extract `VMatch-1.0.0-framework-dependent.zip`.
4. Open the folder and launch `VMatch.exe`.

### Self-contained
1. Go to the [latest release][release-page] page of VMatch.
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
[dotnet]: https://dotnet.microsoft.com/en-us/download
[visual-studio-2022]: https://learn.microsoft.com/en-us/visualstudio/ide/?view=vs-2022
[windows-forms]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0
