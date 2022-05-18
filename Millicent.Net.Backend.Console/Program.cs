// See https://aka.ms/new-console-template for more information
using Millicent.Net.Backend.Business.Wallet;

ChainBalance chainBalance = new ChainBalance();
var balance = chainBalance.GetBalance("milli1xy0mkfa8wmxwwmvup8cz8tpcfvzwsy8eylwvmt");
Console.WriteLine(balance);
Console.ReadLine();