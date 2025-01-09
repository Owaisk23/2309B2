// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections;

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

//int number = 55;

//Console.WriteLine($"This is string interpolation. {105 + number}");

//FOR LOOP

//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}


//for (int i = 1; i <= 101; i++)
//{
//    if(i % 2 != 0)
//    {
//        Console.WriteLine(i);

//    }
//}

//WHILE LOOP

//int x = 5;

//while(x <= 50)
//{
//    Console.WriteLine("K");
//    x++;
//}

//int y = 46;

//do
//{
//    Console.WriteLine("Y");
//    y++;
//}
//while (y <= 45);

//EVEN ODD NUMBER

//int num;
//char ans;

//do
//{
//    Console.WriteLine("Enter any number.");
//    num = Convert.ToInt32(Console.ReadLine());

//    if(num % 2 == 0)
//    {
//        Console.WriteLine("Even Number");
//    }
//    else
//    {
//        Console.WriteLine("Odd Number");
//    }
//    Console.WriteLine("Do you want to continue? Press Y");
//    ans = Convert.ToChar(Console.ReadLine());

//} while (ans == 'Y' || ans == 'y');


// ARRAY WITH FIXED SIZE

//int[] numbers = new int[5];

//numbers[0] = 23;
//numbers[1] = 13;
//numbers[2] = 33;
//numbers[3] = 43;
//numbers[4] = 53;

//Console.WriteLine(numbers[4]);
////Console.WriteLine(numbers[5]);

//int[] itemPrice = { 45, 77, 80, 90, 55 };

//foreach (var item in itemPrice)
//{
//    Console.WriteLine(item);
//}

//string[] countries = { "Pakistan", "Iran", "Iraq", "Pakistan" ,"China", "India", "Afghanistan","Pakistan" };


////Array.Sort(countries);
//Array.Reverse(countries);

//foreach (var country in countries)
//{
//    Console.WriteLine(country);
//};


//Console.WriteLine(Array.IndexOf(countries, "India"));
//Console.WriteLine(Array.LastIndexOf(countries, "Pakistan"));

//MultiDimentional Array

//int[,] OldNewPrices =
//{
//    {77, 100 },
//    //00   01
//    {110, 220 },
////    10   11  
//    {750, 800 },
//    //20    21
//    {707, 1000 },
//    {257, 430 },
//    {177, 300 },
//    {77, 100 }
//};

////Console.WriteLine(OldNewPrices[2, 1]);


//for (int i = 0; i < OldNewPrices.GetLength(0); i++)
//{
//    for (int j = 0; j < OldNewPrices.GetLength(1); j++)
//    {
//        Console.WriteLine(OldNewPrices[i, j]);
//    }
//}

//JAGGED ARRAY
//string[][] skillSet =
//{
//    new string[3] {"Html", "CSS", "Javascript"},
//    new string[5] {"ES6", "MySQL", "PHP", "LARAVEL", "Freelancing"},
//    new string[2] {"SQL SERVER", "DotNET"}
//};


//Console.WriteLine(skillSet[1][4]);

//for(int i = 0; i < skillSet.Length; i++)
//{
//    for(int j = 0; j < skillSet[i].Length; j++)
//    {
//        Console.WriteLine($"Elements in JaggedArray[{i}, {j}] = {skillSet[i][j]}");
//    }
//}

//foreach (var skills in skillSet)
//{
//    foreach (var skill in skills)
//    {
//        Console.WriteLine(skill);
//    }
//}

//FUNCTIONS

//NO PARAMETERS,NO RETURN

//void Greet()
//{
//    Console.WriteLine("Welcome! In our company..!!");
//}

////calling
//Greet();

////With PARAMETERS,NO RETURN

//void GreetUser(string uname)
//{
//    Console.WriteLine($"Welcome {uname}! In our company..!!");
//}

////calling
//GreetUser("Luqman");
//GreetUser("Sami");
//GreetUser("Ayan");
//GreetUser("Hanzala");
//GreetUser("Daniyal");


//NO PARAMETER, RETURN TYPE

//string Greet()
//{
//    return "Welcome! In our company..!!";
//}

////Greet();
////Console.WriteLine(Greet());

//string messg = Greet();

//Console.WriteLine(messg.ToUpper());

//float stdWeight()
//{
//    return 55.43f;
//}

//float fNum = stdWeight();

//Console.WriteLine(fNum);

//RETURN TYPE WITH PARAMETER

//string empDetails(string empName, string empDesig)
//{
//    return ($"Welcome to our company Mr.{empName} as a {empDesig}");
//}

//string messg = empDetails("Ahsan", "Accountant");

//Console.WriteLine(messg);

//DATA STRUCTURES
//COLLECTIONS = GENERIC, Non GENERIC
//GENERIC COLLECTION
//LIST, STACK, QUEUE, DICTIONARY

//LIST Add, Remove, Contains, Count
//using System.Collections;
//List<string> SuperCars = new List<string>();
//SuperCars.Add("Ferrari");
//SuperCars.Add("Supra");
//SuperCars.Add("Bugati");
//SuperCars.Add("Lamborghini");
//SuperCars.Add("Mclaren");

//List<string> Cars = new List<string>();

//Cars.Add("BMW");//0
//Cars.Add("Mercedes");
//Cars.Add("Haval");
//Cars.Add("BRV");
//Cars.Add("Accord");//4

////Console.WriteLine(Cars.Count);
////Console.WriteLine(Cars.Contains("BMW"));

//Cars.Insert(1, "Revo");
////Console.WriteLine(Cars[1]);

//Cars.AddRange(SuperCars);

////foreach (var supercar in SuperCars)
////{
////    Console.WriteLine(supercar);
////}
//Cars.Remove("BMW");

//Cars.RemoveAt(4);
////          length
////Cars.RemoveRange(1, 4);
////              index, length
//foreach (var car in Cars)
//{
//    Console.WriteLine(car);
//}

// QUEUE (FIFO: First In First Out) 
//Enqueue: For add item || Dequeue: For Remove item
//Queue<string> stdNames = new Queue<string>();

//stdNames.Enqueue("Hussain");
//stdNames.Enqueue("Sami");
//stdNames.Enqueue("Huzaifa");
//stdNames.Enqueue("Ayan");
//stdNames.Enqueue("Luqman");
//stdNames.Enqueue("Hanzala");
//stdNames.Enqueue("Daniyal");


//stdNames.Dequeue();//Hussain
//stdNames.Dequeue();//Sami
//stdNames.Dequeue();//Huzaifa

//stdNames.Clear();


//foreach(string name in stdNames)
//{
//    Console.WriteLine(name);
//}

//STACK (LIFO: LAST IN FIRST OUT)
//(PUSH || POP)
//Stack<string> fruits = new Stack<string>();
//fruits.Push("Mango");
//fruits.Push("Apple");
//fruits.Push("Kiwi");
//fruits.Push("Banana");
//fruits.Push("Peach");

//fruits.Pop();//Peach
//fruits.Pop();//Banana

//fruits.Clear();

//foreach (var name in fruits)
//{
//    Console.WriteLine(name);
//}

//Dictionary(Generic)
//Dictionary<string, string> employee = new Dictionary<string, string>();
//employee.Add("empName", "Ammad Ali");
//employee.Add("empEmail", "ammad@gmail.com");
//employee.Add("empPass", "Pakistan555");
//employee.Add("empRole", "Admin");
//employee.Add("empImg", "ammadpic.jpg");

////Console.WriteLine(employee["empRole"]);
////employee.Remove("empImg");

//////Console.WriteLine(employee["empEmail"]);

//foreach (var item in employee)
//{
//    string[] test = (item.ToString()).Split(',');
//    //string key = test[0];
//    //string value = test[1];
//    string key = test[0].Trim('['); //[
//    string value = test[1].Trim(']'); //]
//    //Console.WriteLine(key);
//    //Console.WriteLine(value);
//    //Console.WriteLine(item);

//    Console.WriteLine($"The employee has key propety:{key} and " +
//        $"value property is:{value}");
//    //Console.WriteLine(test[0]);
//}

//Hashtables(Non-Generic Collection && No fixed datatype)

//Hashtable students = new Hashtable();
//students.Add("stdname", "Abdullah");
//students.Add("stdMarks", 88);
//students.Add("stdExamStatus", true);
//students.Add("stdImg", "abdullah.jpg");


////Console.WriteLine(students["stdname"]);
////Console.WriteLine(students.Contains("stdMarks"));
////Console.WriteLine(students.ContainsValue(98));

//foreach (DictionaryEntry item in students)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}

//Console.WriteLine(students.GetHashCode());

//ArrayList (None-Generic Collection & No fix datatype)

//ArrayList Cars = new ArrayList();
//Cars.Add("Revo");
//Cars.Add("Camery");
//Cars.Add("Civic");
//Cars.Add("Elantra");
//Cars.Add("Mehran");
//Cars.Add(24007);
//Cars.Add(.70f);

////Console.WriteLine(Cars.Count);
////Console.WriteLine(Cars.Contains("Mehran"));
////Cars.RemoveAt(3);
////Cars.Remove("Revo");
////Cars.RemoveRange(5, 2);

//foreach (var car in Cars)
//{
//    Console.WriteLine(car);
//}



//String Methods

//string test = """{ "name": "John Doe"}""";

//using System.Collections;

//string test = "we are  Learnnig \"C#\"";
////Console.WriteLine(test);
////Console.WriteLine(test.Replace("Learnnig", "Mastering"));
//Console.WriteLine(test.Replace("C#", "Java"));
//Objects
Aeroplane WestlandLemo = new Aeroplane(); //Default Constructor
Console.WriteLine(WestlandLemo.AirLine);
WestlandLemo.Name = "Westland limo";
WestlandLemo.takeOff();

//Paramterized Constructor
Aeroplane f16 = new Aeroplane("PAF");
f16.Landing();

public class Aeroplane
{
    public string? AirLine;
    public string? Name;
    public int Seats;
    public int Crew;
    public string? Power;

    //Constructors
    public Aeroplane()
    {
        this.AirLine = "Not Specified";
        this.Name = "unknown";
        this.Seats = 0;
        this.Crew = 0;
        this.Power = null;
    }    
    //Parameterized Constructors
    public Aeroplane(string Airline)
    {
        this.AirLine = Airline;
        this.Name = "unknown";
        this.Seats = 0;
        this.Crew = 0;
        this.Power = null;
    }

    public void takeOff()
    {
        Console.WriteLine($"{this.Name} is taking Off From 2nd run way.. Best Wishes!!");
    }
    public void Landing()
    {
        Console.WriteLine($"{this.AirLine} is Landing at 4th run way.. ! ");
    }
}


































































































































