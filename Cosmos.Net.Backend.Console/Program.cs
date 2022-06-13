// See https://aka.ms/new-console-template for more information
using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Net.Client.Configuration;
using Millicent.Net.Backend.Business.Account;
using Millicent.Net.Backend.Business.Chain; 
using Millicent.Net.Grpc;
 
string ddd = "wonder original lobster horror engage puzzle wage nephew shift this sweet build pony ceiling wasp color gravity mirror pyramid absurd shed lawn april sun";
string mnemonicKey = AccountAddress.NewMnemonicKey();
string actualAddress = AccountAddress.GetActualAddress(ddd);

//hard tuna subway quote hedgehog rule book field bubble talk favorite discover feed advice coin garlic bless ordinary amused view when mandate easy flower
//milli18jtdynjrhup3phq4fsqkhpa4yhhceud6gzpzhx kepler
//milli1lc9w9gf09yfj8pnr56gz0lydhsd2pg8wxxkk2f dotnet

// komutla uretildi.
//wonder original lobster horror engage puzzle wage nephew shift this sweet build pony ceiling wasp color gravity mirror pyramid absurd shed lawn april sun
//milli1dte5q490y23n7puutlgjr87uwqpztnecd7qfsm

//MillicentGrpcClientOptions millicentGrpcClientOptions = new MillicentGrpcClientOptions("https://158.175.120.250/rpc");
MillicentGrpcClientOptions millicentGrpcClientOptions = new MillicentGrpcClientOptions("http://localhost:9090");
  //MillicentGrpcClientOptions millicentGrpcClientOptions = new MillicentGrpcClientOptions("http://158.175.120.250:26656");
 // MillicentGrpcClientOptions millicentGrpcClientOptions = new MillicentGrpcClientOptions("http://158.175.120.250:1317");
MillicentGrpcClient millicentGrpcClient = new MillicentGrpcClient(millicentGrpcClientOptions);

ChainBalance chainBalance = new ChainBalance(millicentGrpcClient);
var balance = chainBalance.GetBalance("milli1xy0mkfa8wmxwwmvup8cz8tpcfvzwsy8eylwvmt");
Console.WriteLine(balance); 

Account account = new Account(millicentGrpcClient);
var ret = account.GetAccounts();
Console.WriteLine(ret); 
 