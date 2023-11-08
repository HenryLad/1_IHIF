System.Console.Write("Enter your Operator : ");
char Operator = char.Parse(Console.ReadLine()!);
System.Console.Write("Enter your first Number :");
double firstnum = double.Parse(Console.ReadLine()!);
System.Console.Write("Enter your second Number : ");
double secondnum = double.Parse(Console.ReadLine()!);
double result = 0;
switch(Operator)
{
   case '+':
   result = firstnum + secondnum;
   break;
   case '-':
   result = firstnum - secondnum;
   break;
   case '*':
   result = firstnum * secondnum;
   break;
   case '/':
   if(secondnum != 0){result = firstnum / secondnum;}
   else{System.Console.WriteLine("You can not devide by zero !");}
   break;
   case '%':
   if(secondnum != 0){result = firstnum % secondnum;}
   else{System.Console.WriteLine("You can not use Modulo with a zero !");}
   break;
   default:
   System.Console.WriteLine("You entered not a valid Operator !");
   result = 0;
   break;
   
}

System.Console.WriteLine($"Your result is : {result} ");


