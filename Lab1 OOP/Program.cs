using Lab1_OOP;

var Vlad = new GameAccount("Vlad", "Max");
Console.WriteLine($"Account was created for {Vlad.UserName} with {Vlad.CurrentRating} rating.");
var Max = new GameAccount("Max", "Vlad");
Console.WriteLine($"Account was created for {Max.UserName} with {Max.CurrentRating} rating.");

Vlad.WinGame(Max);
Max.LoseGame(Vlad);

Vlad.LoseGame(Max);
Max.WinGame(Vlad);

Console.WriteLine(Vlad.GetAccountHistory());
Console.WriteLine();
Console.WriteLine(Max.GetAccountHistory());