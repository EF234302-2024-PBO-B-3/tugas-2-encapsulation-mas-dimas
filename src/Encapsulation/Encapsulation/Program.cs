using Encapsulation.Invoicing;
using Encapsulation.Employment;
using System;
using Encapsulation.Calendar;
using Encapsulation.Banking;
using Encapsulation.Extra;

namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        // Invoicing
        Invoice invoice1 = new Invoice("001", "Palu Gada", 5, 75.0);
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Part Description: {invoice1.PartDescription}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Price per item: {invoice1.Price}");
        Console.WriteLine($"Total Invoice Amount: {invoice1.GetInvoiceAmount()}");

        // Employee
        Employee employee1 = new Employee("Arya", "Wiguna", 3000.0);
        Employee employee2 = new Employee("Supra", "Natural", 3500.0);

        Console.WriteLine($"Yearly Salary of {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary of {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Raise salary 
        employee1.RaiseSalary(10);
        employee2.RaiseSalary(10);

        Console.WriteLine($"Yearly Salary after 10% raise for {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary after 10% raise for {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Date
        Date validDate = new Date(12, 15, 2021);
        Date invalidDate = new Date(13, 32, 2021);

        validDate.DisplayDate();
        invalidDate.DisplayDate();

        // Banking

        BankAccount account = new BankAccount("123456789", "Arya Wiguna", 1000.0);
        Console.WriteLine($"Initial balance: {account.GetBalance()}");

        account.Deposit(500.0);
        Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

        account.Withdraw(200.0);
        Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        // Extra

        List<SpotifySong> tracks = new List<SpotifySong>
        {
            new SpotifySong("Sudden Shower", "ECLIPSE", 200, true),
            new SpotifySong("All I Ask", "Adele", 300, false),
            new SpotifySong("The Scientist", "Coldplay", 250, true),
            new SpotifySong("Cartel", "Whisnu Santika", 150, false),
            new SpotifySong("", "", -3, false)
        };

        Console.WriteLine("All Songs...");
        foreach (var song in tracks)
        {
            song.DisplaySong();
            Console.WriteLine();
        }

        Console.WriteLine("Favorite Songs...");
        SpotifySong.DisplayFavoriteSong(tracks);

    }
}
