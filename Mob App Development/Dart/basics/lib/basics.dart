import 'dart:io';

String myName(){
  // print("My name is Ayan");
  return "My name is Ayan";
  // return 20;
}

int add(int a, int b){
  //        10    15
  return a + b;
  //    10 + 15 = 25
}



void main(){
  print("Welcome to Dart Programming!");
  // print("Welcome to Flutter Programming!");

  // stdout.write("Enter your first name: \n");
  // stdout.write("Enter your last name: ");

  // //Variables Datatypes
  // var carName = "Accord";
  // const carYear = 2004;
  // final carColor = "Silver";
  // dynamic carPrice = 2900000;

  // stdout.write("Car Name: $carName\n");
  // stdout.write("Car Year: $carYear\n");
  // stdout.write("Car Color: $carColor\n");
  // stdout.write("Car Price: $carPrice\n");

  // //numeric values
  // // Both positive and negative whole numbers
  // int age = 24;
  // int b = -15;
  // // floating values ya decimal values ya point values
  // double height = 5.9;
  // double weight = 70.5;
  // // both wholenumbers and decimal values
  // num price = 890.55;

  // print("Integer a: $age \nInteger b: $b");
  // print("Height: $height \nWeight: $weight");
  // print("Price: $price");

  // //strings
  // String name = "Ayan";

  // //Boolean
  // bool isAlive = true;


  // //conditional statements
  // if(age > 18){
  //   print("You are allowed to drive");
  // }else{
  //   print("You are not allowed to drive");
  // }

  // //caliing function
  // String userName = myName();
  // print(userName);

  // //calling function with parameters
  // int result = add(100, 150);
  // print("The sum of 100 and 150 is: $result");


  //LIST
  List<String> stdNames = ["Ayan", "Luqman", "Maaz", " Daniyal", "Sami", "Hussain", "Huzaifa"];

  print("List of Students: $stdNames");
  // print("Student Name: ${stdNames[4]}");
  // print("Length of List: ${stdNames.length}");
  // print("Hash Code of List: ${stdNames.hashCode}");
  // print("TRUE/FALSE is Not Empty of List: ${stdNames.isNotEmpty}");
  // print("List Reversed: ${stdNames.reversed}");

  //CRUD
  // stdNames.add("Ali");
  // print("List after adding new student: $stdNames");
  stdNames.insert(0, "Abdullah");
 print("List after adding new student: $stdNames"); 
  //remove
  // stdNames.remove("Sami");
  // print("List after removing student: $stdNames");
  // stdNames.removeAt(2);
  // print("List after removing student: $stdNames");

  // stdNames.clear();
  // print("List after clear method student: $stdNames");

  //update
  stdNames[3] = "Alyan";
  print("List after updating student: $stdNames");

}