# Wesktop

![Wesktop](https://github.com/Lion-Craft/Wesktop/assets/78223634/4a86e467-fb26-457c-aafa-b80247dadf2e)

A simple Desktop Environment for the WINE Virtual Desktop written in C# using .NET Framework 4.7.2 and Windows Forms.
It is currently just a proof-of concept so its functionality is very limited and/or broken.

Tested under: 
- Linux Mint 20.3 Una using WINE 8.13 Staging
- Fedora Workstation 38 using WINE 8.13 Staging
- Windows 10 22H2

## Building Wesktop

### Requirements:
- Microsoft Visual Studio (VS 2022 recommended) or Monodevelop (UNTESTED)
  - Compatible and up-to-date Windows (W10 22H2 recommended), Linux or MacOS (Linux and Mac UNTESTED) Versions
- .NET Framework 4.7.2 with Windows Forms
### Starting the Build
0. (On Windows when .zip download was chosen) Open the folder containing the .csproj file in Explorer, select all .resx files, open file properties and select the "Unblock" option
1. Open the .sln file in your IDE
2. - (Visual Studio) Click "Build Solution" under the "Build" tab or click on "Start" to enable debugging
   - (Other IDEs like Monodevelop) Click "Build Solution" under the "Build" tab
