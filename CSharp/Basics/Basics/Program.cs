﻿// See https://aka.ms/new-console-template for more information
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
//Aeroplane WestlandLemo = new Aeroplane(); //Default Constructor
//Console.WriteLine(WestlandLemo.AirLine);
//WestlandLemo.Name = "Westland limo";
//WestlandLemo.takeOff();

////Paramterized Constructor
//Aeroplane f16 = new Aeroplane("PAF");
//f16.Landing();

//Aeroplane f17 = new Aeroplane("PAF", "F-17 Thunder", 2, 2, "8500hp");
//f17.takeOff();
//Console.WriteLine(f17.Power);
////f17.land();

//public class Aeroplane
//{
//    public string? AirLine;
//    public string? Name;
//    public int Seats;
//    public int Crew;
//    public string? Power;

//    //Constructors
//    public Aeroplane()
//    {
//        this.AirLine = "Not Specified";
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }    
//    //Parameterized Constructors
//    public Aeroplane(string Airline)
//    {
//        this.AirLine = Airline;
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }

//    //    //    //Paremeterized constructor (Overloading)
//    public Aeroplane(string ALine, string name, int seat, int crew, string pow)
//    {
//        this.AirLine = ALine;
//        this.Name = name;
//        this.Seats = seat;
//        this.Crew = crew;
//        this.Power = pow;
//    }

//    public void takeOff()
//    {
//        Console.WriteLine($"{this.Name} is taking Off From 2nd run way.. Best Wishes!!");
//    }
//    public void Landing()
//    {
//        Console.WriteLine($"{this.AirLine} is Landing at 4th run way.. ! ");
//    }
//}


//OOP (OBJECT ORIENTED PROGRAMMING)
//it is an approach to code cleaner and better.
//readable
//reusable
//optimize
//proper structure of the code is maintained.

//Main Pillars of OOP

//1. Interitance
// i . Single level inheritance  Vehicle -> Car
// ii . Multi level inheritance  Vehicle -> Car -> Ecar
// iii. Heirarchical inheritance Vehicle ->Car , Vehicle-> Bike
// iv. Multiple inheritance  
// v. Hybrid inheritance    Vehicle -> CAR , Vehicle -> Car -> Ecar, Car-> Ecar

//2. Polymorphism
// Method Overloading
// Method Overriding
//3. Abstraction
//4. Encapsulation

//Inheritance
//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();

//Car mercedez = new Car("TZ-8908", "Black", "Mercedez", "Benz C-Class", 20000000);
////mercedez.Run();
//mercedez.Run(500);

//////// Parent class | Base Class | Super Class
//public class Vehicle
//{
//    public string regNo;
//    public string color;

//    public Vehicle(string regno, string color)
//    {
//        this.regNo = regno;
//        this.color = color;
//    }
//    public void Run()
//    {
//        Console.WriteLine($"{this.regNo} vehicle started running");
//    }
//}
////// Child class | Derived Class | Sub Class
//public class Car : Vehicle
//{
//    public string brand;
//    public string model;
//    public int price;

//    public Car(string regno, string color, string brand, string model, int price)
//        : base(regno, color)
//    {
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//    }

//    //method overriding
//    public void Run()
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
//    }
//    //method overloading
//    public void Run(int speed)
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} " +
//            $"MPH.");
//    }

//}

//Access  Modifiers
//1. Public     | anyone can access from any where in the program.
//2. Private    | only owner class can access .
//3. Protected  | only owner class and child class can access .

//Products neckBand = new Products(1500, "Lenovo Neckband", "good quality product with extra base and long range connectivity.");
//neckBand.name="Lenovo Neckband";
//neckBand.price;
//neckBand.description;
//Console.WriteLine(neckBand.price);
//Console.WriteLine(neckBand.name);

//neckBand.showPrice();
//neckBand.callShowPrice();

//Gadgets iphone = new Gadgets(230000, "iphone 15 pro max", "acha phone ha", "phones");
//iphone.ShowGadget();

////base class
//public class Products
//{
//    public string name;
//    private int price;
//    protected string description;

//    public Products(int price, string name, string description)
//    {
//        this.name = name;
//        this.price = price;
//        this.description = description;
//    }

//    private void showPrice()
//    {
//        Console.WriteLine(this.price);
//    }
//    public void callShowPrice()
//    {
//        this.showPrice();
//    }
//}
////child class
//public class Gadgets : Products
//{
//    public string category;

//    public Gadgets(int price, string name, string description, string category) : 
//        base(price, name, description)
//    {
//        this.category = category;
//    }

//    public void ShowGadget()
//    {
//        Console.WriteLine(this.name);
//        this.callShowPrice();
//        Console.WriteLine(this.description);
//        Console.WriteLine(this.category);
//    }
//}


//Interfaces
//FrontEndDeveloper ashar = new FrontEndDeveloper();
//ashar.ComplexDesign("Ashar Ahmed");
//ashar.SimpleDesign();

//FullStackDeveloper usama = new FullStackDeveloper();
//usama.SimpleDesign();
//usama.ComplexAPIs();

//interface topics
//{

//Interfaces,
//        Static,
//       Abstract
//} 
//interface FrontEndDevelopment
//{
//    public void SimpleDesign();
//    public void ComplexDesign(string name);

//}


//interface BackEndDevelopment
//{
//    public void SimpleCrud();
//    public void ComplexAPIs();
//    public void Authentication();

//}

//public class FrontEndDeveloper : FrontEndDevelopment
//{
//    //method implementation
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS and JS.");
//    }
//    public void ComplexDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you animated and responsive design using HTML, CSS, JS, " +
//            $"React, " +$"Nextjs.");
//    }
//}



//Multiple Inheritance
//public class FullStackDeveloper : FrontEndDevelopment, BackEndDevelopment
//{
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS and JS.");
//    }
//    public void ComplexDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you animated and responsive design using HTML, CSS, " +
//            $"JS, React, Nextjs.");
//    }
//    public void SimpleCrud()
//    {
//        Console.WriteLine("We will provide you simple crud operations.");
//    }
//    public void ComplexAPIs()
//    {
//        Console.WriteLine($"We will provide you complex APIs.");
//    }
//    public void Authentication()
//    {
//        Console.WriteLine($" We will provide you Authentication.");
//    }
//}

//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();

//Car MarkX = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car a = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car b = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car bv = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car g = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car MadrkX = new Car("2008", "Black", "Toyota", "Mark X", 3500000);


//MarkX.Run();
//MarkX.Run(300);

//Math abc = new Math();
//abc.Sqrt(49);

//static function examples:
//Math.Sqrt(49);
//Console.WriteLine("dkf");

//Console.WriteLine(Car.totalCars);
//Car.paytax();



//abstract public class Vehicle
//{
//    public string regNo;
//    public string color;

//    public static int totalCars = 0;
//    public static int totalAmount = 0;
//    public static int payingCars = 0;
//    public static int nonPayingCars = 0;
//    public virtual void Run()
//    {
//        Console.WriteLine($"{this.regNo} vehicle started running");

//    }
//}
//abstract public class Car : Vehicle
//{
//    public string brand;
//    public string model;
//    public int price;
//    public int basePrice = 2;
//    public static int carCount = 0;
//    public Car(string regno, string color, string brand, string model, int price)
//    {
//        this.regNo = regno;
//        this.color = color;
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//        totalCars++;
//        carCount++;
//    }
//    public static void paytax()
//    {
//        Console.WriteLine("Boom..! the race has begun. May the best be winner.");
//        //payingCars++;
//        //totalAmount += this.basePrice;

//    }
//    //method overriding
//    public void piassWithoutPayng()
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
//        nonPayingCars++;
//    }

//    //method overloading
//    public void Run(int speed)
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
//    }

//}




//Delegates
//Math
//Math.Cos()

//Normal Delegate
//MyMaths.MyMathsDelegate Eval = new MyMaths.MyMathsDelegate(MyMaths.Add);
//Eval(4, 8);

//Multicast Delegate

//MyMaths.MyMathsDelegate MultiEval;
//MultiEval = MyMaths.Mul;
//MultiEval(2, 5); //10

//MultiEval = MyMaths.Div;
//MultiEval(2, 0); //cant divide


//MyMaths.Sub(4, 2); //2
//public class MyMaths
//{
//    public delegate void MyMathsDelegate(double num1, double num2);

//    public static void Add(double a, double b)
//    {
//        Console.WriteLine(a + b);
//    }
//    public static void Sub(double a, int b)
//    {
//        Console.WriteLine(a - b);
//    }

//    public static void Mul(double a, double b)
//    {
//        Console.WriteLine(a * b);
//    }
//    public static void Div(double a, double b)
//    {
//        if (b != 0)
//            Console.WriteLine(a / b);
//        else
//            Console.WriteLine("Can't divide by zero");
//    }
//}


//Shopping.GetItem buy;
//buy = Shopping.GetGadgets;
//buy("Jam", 550, "Black current jam with great delight");

//public class Shopping
//{
//    public delegate void GetItem(string name, int price, string description);

//    public static void GetEatables(string name, int price, string desc)
//    {
//        Console.WriteLine("You have bought eatable {0} at Rs. {1} . {2} .", name, price, desc);//placeholders
//    }
//    public static void GetGadgets(string name, int price, string desc)
//    {
//        Console.WriteLine("You have bought gaddet {0} at Rs. {1} . {2} .", name, price, desc);//placeholders
//    }
//}


//unary operator    a++, a--
//binary operator   a + b; a - b
//Ternary operator  (condition) ? "hi" : "bye" // 3 operands

//string greet = (10 < 10) ? "hi" : "bye";

//Console.WriteLine(greet);

//getters and setters

//Animal cat = new Animal();
//cat.Name = "Tom";
//cat.Age = 40;
//Console.WriteLine(cat.Age);


//public class Animal
//{
//    public string? Name { get; set; } //auto complete properties
//    private int age;


//    public int Age
//    {
//        get { return age; }

//        set
//        {

//            if (value < 10)
//            {

//                age = value;
//            }
//            else
//            {
//                age = 10;
//            }
//        }
//    }
//}



//enums
//Implicit typecasting 
//Explicit typecasting 


//Console.WriteLine($"{pakBatters.Fakhar} has jersey no {(int)pakBatters.Fakhar}");

//enum pakBatters
//{
//    Babar = 56,
//    Rizwan = 33,
//    Fakhar = 45,
//    Imad = 75
//}





//namespaces : a collection of related classes and sub namespaces.

using System;
using System.Collections;
//using TaxMangementSytem;
//using Indexers;


//Tax tolltax = new Tax();

//tolltax.amount = 5000;

//Vehicle vehicle = new Vehicle();
//vehicle.regNum = 4545;



//Indexers : when we want our object to behave like an array we implement indexers.

//fruits basket = new fruits();
//basket[0] = "Langra";
//basket[1] = "Chaunsa";
//basket[2] = "Daseri";
//basket[3] = "Sindhri";
//basket[4] = "Anwer Ritol";
//basket[5] = "ahbfdk";
//basket[6] = "ahbfdk";

//Console.WriteLine(basket[3]);

//foreach (string item in basket.fruitNames)
//{
//    Console.WriteLine(item);
//}

//Records 

//User ahmed = new User();
//ahmed.id = 1;
//ahmed.name = "Ahmed Hassan";


//User haris = new User();
//haris.id = 1;
//haris.name = "Ahmed Hassan";


////Console.WriteLine(ahmed);
//Console.WriteLine(ahmed == haris);

//User1 talha = new User1();
//talha.id = 2;
//talha.name = "Mirza talha";

//User1 abdullah = new User1();
//abdullah.id = 2;
//abdullah.name = "Mirza talha";

////Console.WriteLine(talha);
//Console.WriteLine(talha == abdullah);

//public class User
//{
//    public int id { get; set; }
//    public string? name { get; set; }
//}

//public record User1
//{
//    public int id { get; set; }
//    public string name { get; set; }
//}


//events

myCar Civic = new myCar();
Civic.speedUp += new myCar.speedCar(myCar.carMoved);
Civic.drive();


public class myCar
{
    public delegate void speedCar();
    public event speedCar speedUp;
    public int speed = 0;

    public void drive()
    {
        for (int i = 1; i < 100; i++)
        {
            if (i > 50)
            {
                speedUp();
            }
            Console.WriteLine($"the car is moving at {i} mph");
            System.Threading.Thread.Sleep(200);


        }
    }
    public static void carMoved()
    {
        Console.WriteLine("the speed limit has exceeded");
    }


}


























































































































