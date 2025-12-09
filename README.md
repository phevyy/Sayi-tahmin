# 🎯 Enemy Target Game (Number Guessing)

This project is a **C# Windows Forms Application** that implements a fun number guessing game themed as "Hitting the Enemy". The goal is to guess the randomly generated enemy ID number (1-100) to win.

## 📝 Description

The application generates a random "Enemy Number" between **1 and 100** when the game starts. The user enters a guess into the text box and clicks the **"Vur"** (Hit) button.
* **If the guess is correct:** The enemy is defeated.
* **If the guess is wrong:** The enemy escapes, and the user is asked if they want to try again.

## 📂 Project Structure

The project files are located in the main directory:

| File Name | Description |
| :--- | :--- |
| **`Form1.cs`** | Contains the main game logic (Random number generation, button click events). |
| **`Form1.Designer.cs`** | Contains the auto-generated code for the GUI (Labels, Buttons, TextBoxes). |
| **`Program.cs`** | The entry point of the application. |

## 🚀 How It Works

1.  **Start:** The `YeniOyunBaslat()` function runs on startup, picking a random number.
2.  **Input:** User enters a number in the `TextBox`.
3.  **Logic:**
    * The program checks if the input is numeric and between 1-100.
    * It compares the input with the hidden enemy number.
4.  **Feedback:** Uses `MessageBox` to inform the user of the result (Success or Failure).

## 🛠️ How to Run

1.  Clone or download this repository.
2.  Open the solution file (usually inside the folder named "Sayı tahmin ederek düşman öldürme...") in **Visual Studio**.
3.  Click **Start** or press **F5** to build and run the application.

## 📸 UI Guide (Turkish to English)

Since the interface is in Turkish, here is a quick translation guide:
* **"Hedef Düşman Numaranızı Girin"**: Enter Target Enemy Number.
* **"Vur"**: Hit / Shoot.
* **"Düşman kaçtı! Tekrar denemek ister misiniz?"**: Enemy escaped! Do you want to try again?

## ⚠️ Requirements
* .NET Framework
* Visual Studio (Recommended)
