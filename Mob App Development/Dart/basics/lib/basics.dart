import 'dart:io';

void main(){
  print("Welcome to Dart Programming!");
  print("Welcome to Flutter Programming!");

  stdout.write("Enter your first name: \n");
  stdout.write("Enter your last name: ");

  //Variables Datatypes
  var carName = "Accord";
  const carYear = 2004;
  final carColor = "Silver";
  dynamic carPrice = 2900000;

  stdout.write("Car Name: $carName\n");
  stdout.write("Car Year: $carYear\n");
  stdout.write("Car Color: $carColor\n");
  stdout.write("Car Price: $carPrice\n");

  //numeric values
  // Both positive and negative whole numbers
  int age = 24;
  int b = -15;
  // floating values ya decimal values ya point values
  double height = 5.9;
  double weight = 70.5;
  // both wholenumbers and decimal values
  num price = 890.55;

  print("Integer a: $age \nInteger b: $b");
  print("Height: $height \nWeight: $weight");
  print("Price: $price");

  //strings
  String name = "Ayan";

  //Boolean
  bool isAlive = true;


  //conditional statements
  if(age > 18){
    print("You are allowed to drive");
  }else{
    print("You are not allowed to drive");
  }


}