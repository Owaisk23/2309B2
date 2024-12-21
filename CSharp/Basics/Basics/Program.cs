// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string firstname = "luqman";
//string lastname = "aslam";

//Console.WriteLine("student of the month for the month of january" +
//" is " + firstname + " " + lastname);

//DATATYPES
//NUMBERS
//byte age = 26;

//short salary = 26000;

//int price = 2147483647;

//long largeNum = 4836472147483647L;

//float deciNum = 75.35F;

//double num = 123.654D;

//decimal price2 = 75999.255M; 

////STRING

//char alpha = 'A';

//string car = "Supra";

//bool isAffordable = false;

//Console.WriteLine("Age is " + age + "\nSalary is " + salary + "\nPrice is " + price
//    + "\nLarge Number is " + largeNum + "\nDeci Number is " + deciNum + "\nDouble Num is "
//    + num + "\nPrice2 is " + price2 + "\nCharacter is " + alpha + "\nString is " + car
//    + "\nBool is isAffordable " + isAffordable);

////Arithmatic Operator

//Console.WriteLine(77 + 90);
//Console.WriteLine(717 - 90);
//Console.WriteLine(77 * 90);
//Console.WriteLine(100 / 100);
//Console.WriteLine(5 % 2);

//// SHORTCUT 

//int number = 10;

//Console.WriteLine(number += 5); //number = number + 5 
//Console.WriteLine(number -= 5); //number = number + 5 
//Console.WriteLine(number *= 5); //number = number + 5 
//Console.WriteLine(number /= 5); //number = number + 5

////COMPARISION Operator

//int num1 = 50; int num2 = 70;

//Console.WriteLine(num1 == num2);//F
//Console.WriteLine(num1 >= num2);//F
//Console.WriteLine(num1 <= num2);//T
//Console.WriteLine(num1 != num2);//T
//Console.WriteLine(num1 < num2);//T
//Console.WriteLine(num1 > num2);//F

//LOGICAL OPERATOR
//int a = 35, b = 75;

//////AND &&
////Console.WriteLine(a >= b && a <= b);
//////                  F           T
////Console.WriteLine(a <= b && a < b);

////OR ||
//Console.WriteLine(a >= b || a <= b);
////                  F           T
//Console.WriteLine(a >= b || a == b);

////NOT !
//Console.WriteLine(!(a == b));

//CONDITIONAL STATEMENTS

//Console.WriteLine("Enter Salary..");

//int salary = Int32.Parse(Console.ReadLine());

//if(salary > 50000 && !(salary >= 80000))
//{
//    Console.WriteLine("Good salary...");
//}
//else if(salary < 50000)
//{
//    Console.WriteLine("Do you get fuel allowance?");
//    string answer = Console.ReadLine();

//    answer = answer.ToLower();// yes  or y

//    if (answer == "yes" || answer == "y")
//    {
//        Console.WriteLine("Sounds Goood!!");
//    }
//    else if (answer == "no" || answer == "n")
//    {
//        Console.WriteLine("Try to switch your job ASAP!!");
//    }
//    else
//    {
//        Console.WriteLine("Please enter yes or no.");    
//    }
//}
//else
//{
//    Console.WriteLine("Great!! MASHALLAH");
//}
// SWITCH CASE

//Console.WriteLine("Enter number to find Day b/w 1 to 7.");
//int num = Convert.ToInt32(Console.ReadLine());

//switch (num)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;    
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Chutti Day");
//        break;

//}

//STRING INTERPOLATION

int number = 55;

Console.WriteLine($"This is string interpolation. {105 + number}");





















































