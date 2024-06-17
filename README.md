# ![semicolon-red](https://github.com/Mindkerchief/VMatch/assets/130748576/a65c7e73-af97-4a10-8954-11e1853c02e2) VMatch
A Windows Form application that has riddles which reveals a programming problem when solved. The program is timed and records every action performed by the participants. This program is used for programming competition with a theme of Valentines Day.

## Table of Contents
- [Installation](#installation)
- [Features](#features)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Installation
### Pre-requisite
- [.NET 8.0](https://dotnet.microsoft.com/en-us/download)

### Steps
1. Download the latest release
2. Install the installer

## Features
### Navigation

<div>
  <img src="https://github.com/Mindkerchief/VMatch/assets/130748576/3786ca8b-3bcc-4204-ad77-4bd88894f129" alt="start-screen">
  &nbsp;
  <img src="https://github.com/Mindkerchief/VMatch/assets/130748576/2f1a77be-6cc3-4006-86c4-8f9c51a9d931" alt="question-screen">
</div>

- **Timer** - Countdown for the competition time limit.
- **Riddle/Question** - Riddle and questions to answer to proceed to next step.
- **Upload Solution** - Submit file with proper naming as solution.

### Monitoring
![close-prevention](https://github.com/Mindkerchief/VMatch/assets/130748576/0ae2a5ca-fb26-4cd8-bacb-f259217c1136)
- **Close Prevention** - Prevents program from closing to prevent cheating.
- **Folder Access Restriction** - Restrict participants from accessing the solution and log folder.
- **Action/Time Log** - Records the time of starting, answering, submitting, closing and times-up.

> [!NOTE]
> The program will create `~` folder in the root directory at launch.

> [!TIP]
> To access restricted folder, go to `~` Folder Security and delete Everyone group.

> [!TIP]
> Program can only be close by entering /close as answer, ending the task in Task Manager or waiting for time limit to expire.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments
- **[Visual Studio 2022](https://learn.microsoft.com/en-us/visualstudio/ide/?view=vs-2022)**: The offial IDE for Windows Form Application by Microsoft.
