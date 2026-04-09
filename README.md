# Address Formatter - C# Console App

This is a C# console application that demonstrates fundamental Object-Oriented Programming (OOP) principles, such as encapsulation and separation of concerns.

## Description
The application interacts with the user to collect the necessary data for a complete address (Country, City, Street, Number, Entrance, Postal Code). Subsequently, the data is stored in a dedicated data model and automatically formatted to be displayed legibly.

## Features
* **Logic Separation:** The code is cleanly divided between the user interface (`AddressRequest.cs`), the data model (`PersonAddress.cs`), and the execution entry point (`Program.cs`).
* **Console-Level Validation:** Ensures that the postal code input contains exactly 6 characters, specific to the Romanian postal code format.
* **Read-Only Properties:** Uses a computed property (`FullAddress`) that generates a formatted address using string interpolation, without allowing external modification.

## Technologies Used
* C#
* .NET Framework / .NET Core

## How to Run
1. Clone this repository to your local machine.
2. Open the solution in Visual Studio.
3. Run the project (F5). Follow the instructions in the console to enter the data.
