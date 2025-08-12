# PowerToys For XP

This repository contains the source code for PowerToys For XP, a Windows Forms application that provides a set of tools to enhance productivity. This project is inspired by Microsoft's PowerToys and aims to bring similar functionalities to older systems, built with the .NET Framework 3.5.

## Requirements
To run this application, you will need to have the .NET Framework 3.5 installed on your system. For many older versions of Windows, this may be included, but you can download it directly from Microsoft if needed.

## Features

### 1. Color Picker
A handy tool for developers and designers to pick any color from the screen.
- **Shortcut**: `Ctrl + Shift + C`
- It displays the color in HEX, RGB, and its known name.
- Click on any of the color codes to copy it to the clipboard.

### 2. Keyboard Manager
Remap keys on your keyboard to improve your workflow.
- Enable or disable the feature with a checkbox.
- Select a key to remap `From` and the key you want it to behave as `To`.
- Prevents remapping a key to itself or to a null value.

### 3. Dark Mode
A modern dark theme for the application to reduce eye strain.
- Toggle between light and dark mode from the settings panel.
- The theme is applied across the entire application.

### 4. Simple Web Browser
A lightweight web browser is integrated into the application.
- Navigate to any URL.
- Basic controls like back, forward, and refresh are available.

## How To Use

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/ryukgod26/PowerToysForXP.git
    ```
2.  **Open the solution in Visual Studio.**
3.  **Build and run the project.**

## Code Overview

### `Home.cs`
This is the main form of the application. It handles the UI and the main logic for all the features.
- **Hotkeys**: Uses `RegisterHotKey` and `UnregisterHotKey` for the color picker shortcut.
- **Keyboard Hook**: The `KeyboarrdHook.cs` class is used to intercept and remap key presses.
- **Theming**: The `applyTheme` method handles the dark and light mode switching.

### `KeyboarrdHook.cs`
This class contains the logic for setting up a low-level keyboard hook.
- It uses `SetWindowsHookEx` to capture keyboard events.
- It can remap a specified key to another key.

### `ColorInfo.cs`
This form is used to display the information about the color picked from the screen.

### `colourPickerNativeMethods.cs`
Contains the P/Invoke signatures for the Win32 API functions required for the color picker.

## Technologies Used
- **C#**
- **.NET Framework 3.5**
- **Windows Forms**

## Author
- **Ryuk**
- **GitHub**: [ryukgod26](https://github.com/ryukgod26)



