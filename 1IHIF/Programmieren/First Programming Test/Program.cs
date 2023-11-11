using System.Drawing;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


const decimal OilReplacementPrice = 59.99m;
const decimal BrakePrice = 682.5m;
const decimal OilFilterPrice = 97.43m;
const decimal HourlyRate = 120.00m;
const decimal BrakeTime = 3.5m;
const decimal OilReplacementTime = 0.5m;
const decimal OilFilterTime = 1m; 

System.Console.Write("Enter license plate : ");
string Licenseplate = Console.ReadLine()!;
System.Console.Write("Enter serivce code : ");
string Servicecode = Console.ReadLine()!;
// 1 23
int Brake = int.Parse(Servicecode) / 100;
   int OilReplacement = (int.Parse(Servicecode) / 10) % 10;
int OilFilter = int.Parse(Servicecode) % 10;

decimal price = 90;

switch(Brake){

      case 2:
      {
         price += BrakePrice + (HourlyRate * BrakeTime);
      }
      break;
      case 3:
      {
         price += BrakePrice + (HourlyRate * (BrakeTime * 1.5m));
      }
      break;
}
switch(OilReplacement){

      case 2:
      {
         price += OilReplacementPrice + (HourlyRate * OilReplacementTime);
      }
      break;
      case 3:
      {
         price += OilReplacementTime + (HourlyRate * (OilReplacementTime * 1.5m));
      }
      break;
}
switch(OilFilter){

      case 2:
      {
         price +=  OilFilterPrice + (HourlyRate * OilFilterTime);
      }
      break;
      case 3:
      {
         price += OilFilterPrice + (HourlyRate * (OilFilterTime * 1.5m));
      }
      break;
}

System.Console.Write($"Your car with license plate {Licenseplate} was repaired and the total price is € ");
Console.ForegroundColor = ConsoleColor.Red;
System.Console.Write($"{price:c2}");
Console.ForegroundColor = ConsoleColor.White;