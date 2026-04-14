# MILKTEA ORDERING SYSTEM

## Description
A multi-form Windows Applications developed in VB.NET. This project features a professional entry point (Form2) that navigates into a functional Milk Tea Ordering System (Form1). The application demonstrates form-to-form navigation, data validation, and automated pricing logic for retail environments.

## Features
- **Splash Screen (Form2):** Provides a clean entry point with "Start" and "Exit" functionality.
- **Main Ordering Interface (Form1):** Handles customer names, quantities, and order customization.
- **Size Selection:** Small (49.00), Medium (69.00), and Large (89.00).
- **Add-on Options:** Pearls (10.00), Nata de Coco (10.00), and Cream Cheese (20.00).
- **Navigation Logic:** Transitions from the splash screen to the ordering form while hiding the background process.

## Concepts Used
- **Multi-Form Navigation:** Uses Form.Show() and Me.Hide() to transition from a Splash Screen (Form2) to the main system.
- **Conditional Statements (If-ElseIf):** Evaluates selected RadioButtons to assign specific prices for cup sizes and add-ons.
- **Input Validation:** Uses IsNumeric and Val to verify that the customer name is provided and the quantity is a valid positive number.
- **Variables and Data Types:** Implements Double and Integer types to handle currency calculations and item counts.
- **UI Event Handling:** Manages user interactions through Click and TextChanged events.

## How to Run
```bash
1. Open the project file ProjectOrderingSys.sln in Visual Studio.
2. Press F5 or click the Start button to compile and run the application.
3. Use the Splash Screen to enter the system.
```

## Sample Output 
<img width="1336" height="889" alt="image" src="https://github.com/user-attachments/assets/8d461aaf-aa20-4c0a-86f0-0bec9fd7ea84" />
<img width="1399" height="889" alt="image" src="https://github.com/user-attachments/assets/fb930124-baf2-476b-8fa1-4823f7ac233b" />

## Author
April Lyne T. Salmasan
