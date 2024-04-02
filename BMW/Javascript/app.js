// Class 1

// 3 ways of printing in JS
// document.write("Hello from external JS!")
// alert("Hello, Good Morning!")
// console.log("Hello from external JS!")
// console.log("Hello from external JS!")

// Declaration & Assigning Value

// var fname; //Declare variable

// fname = "Abdullah"; //Assigning value
// console.log("His name is: " + fname);

// var age = 24;
// console.log("His age is: " + age);

// data types in js

// var a = true;

// Concat
// console.log(typeof(age))
// console.log(typeof(fname))
// console.log(typeof(a))
// console.log(typeof("45"))


// Class 2

// console.log("this is a " + typeof(a));
// console.log("this is a " + typeof(age));
// console.log("this is a " + typeof(fname));
// console.log("Pakistan " + "Zindabad");


// var num1 = 10;

// var num2 = 40;

// console.log("Number 1 is " + num1)
// console.log("Number 2 is " + num2)

// var add = num1 + num2;
// var sub = num1 - num2;
// var mult = num1 * num2;
// var div = num1 / num2;
// var mod =  num1 % num2;


// console.log(add)


// console.log("Addition result is: " + add)
// console.log("Subtraction result is: " + sub)
// console.log("Multiplication result is: " + mult)
// console.log("Division result is: " + div)
// console.log("Remainder result is: " + mod)


// precedence

// var a = 2 + 4 * 10 / 2;
//      6 * 10 /2
// 60/2
// 30

// 2 + 4 * 5
// 2 + 20
// 22

// console.log("Result of DMAS is : " + a);

// var exp = (2 * 5) - 10 / (2 * 3);
//        10 - 10 / 6
//        10 - 1.66
//        8.34

// console.log("Result of BODMAS is: " + exp);


// Increment & Decrement || POST & PRE

// var a = 5;
// console.log(a)
// ++a;
// ++a;
// ++a;
// ++a;
// ++a;
// ++a;
// ++a;
// ++a;
// ++a;
// ++a;
// --a;
// console.log(a)

// var x = 2;

// var y = x +  ++x + x + x++ + x;
//      2 +  3  +  3  + 3  +  4 =  15
// console.log("Expected outcome of x is: " + x) 
// console.log("Expected outcome of y is: " + y) 

// var x = 5;

// var y = x + ++x + x++ + --x + x-- + x + ++x + ++x;
//      5 +  6  +  6  +  6  + 6 +  5  +  6  +  7;


// console.log("Expected outcome of x is: " + x) 
// console.log("Expected outcome of y is: " + y)

// var a = 2;

// var y = a + a++ + --a + a-- + a;
//      2 +  2  +  2  + 2   + 1;

// console.log("Expected outcome of a is: " + a) //1
// console.log("Expected outcome of y is: " + y) //9

// == vs ===

// var num1 = 2; 

// var num2 = '2';

// var add = num1 + num2;
// console.log(add); 

// console.log(typeof(num1))
// console.log(typeof(num2))

// var result = num1 == num2; //True
// var result = num1 === num2; //False
// var result = num1 != num2; //False
// var result = num1 !== num2; //True
// console.log(result)

// PROMPT 

// var fname = prompt('Enter your name:');

// alert("Your name is: " + fname);

// var age = prompt('Enter your age:');

// console.log("Data Type of age is: " + typeof(age))

// console.log("Your age is: " + age);

// Unary Operator

// var num1 = +prompt("Enter number 1:")
// var num2 = +prompt("Enter number 2:")

// var add = num1 + num2;

// console.log("Result of addition is: " + add);

// Conditional Statments

// var fname = "Ali";
// var marks = prompt("Enter your marks", 20);


// If Else

// if(marks > 50){
//     console.log(fname + " your marks are: " + marks);
// } else{
//     console.log("Sorry " + fname +  " you are failed, and your marks are: " + marks)
// }


// IF else if else

// if(marks > 80){

//     alert("A1 Grade")

// } else if(marks < 80) {

//     alert("B Grade")

// }else{

//     alert("Invalid Number")
    
// }


// Nested IF

// if(marks >= 80 && marks <= 100){

//     alert("Congrats, you are passed with A1 Grade!!");
//     if(marks > 90){
//         alert("Apki position aye hai");
//     }else{
//         alert("Agli bar or mehnat krna");
//     }
// }else if(marks <= 80 && marks >= 50){

//     alert("B-Grade");

// }else{

//     alert("Failed or Invalid Marks");

// }

// SWITCH Case

// Syntax

// switch(key){
//     case 1:
//          Block Of Code
//          break;

//     case 2:
//          Block Of Code
//          break;

//     case 3:
//          Block Of Code
//          break;

//     case 4:
//          Block Of Code
//          break;

//      default:
//          Block Of Code
//          break;
// }



// var days = +prompt("Enter any number to find day.", 1)

// switch(days){
//     case 1:
//         alert("Monday");
//         break;

//     case 2:
//         alert("Tuesday");
//         break;

//     case 3:
//         alert("Wednesday");
//         break;

//     case 4:
//         alert("Thursday");
//         break;

//     case 5:
//         alert("Friday");
//         break;

//     case 6:
//         alert("Saturday");
//         break;

//     case 7:
//         alert("Sunday");
//         break;

//     default:
//         alert("Holiday")
//         break;

// }

//FOR LOOP

// for loop has three statements
// i) initialization --> run only one time before iteration.
// ii) condition --> run before iteration
// iii) expression --> run after iteration

// for (initialization; condition ; expression){
//     code to be executed;
// }


// console.log("1")
// console.log("2")
// console.log("3")
// console.log("4")
// console.log("5")
// console.log("7")


// for(var i = 0; i < 10; i++){
//     console.log(i);
// }


// var num = +prompt("Enter table for desire table:");

// for(var i = 1; i <= 100; i++){
//     //       2  x  1  =  2
//     console.log(num + 'x' + i + '=' +  num * i);

// }

// WHILE Loop
// Init
// var i = 1;

// // Condition
// while(i<=10){
    
//     console.log(i);

//     // Expression
//     i++;
// }

// DO- While Loop

// var i = 1;

// do{
//     console.log(i)

//     i++
// }while(i <= -2)


// var std1 = "Ali";
// var std2 = "Owais";
// var std3 = "Abdullah";
// var std4 = "Alisha";
// var std5 = "Alex";
// var std6 = "Aly";

// console.log(std1)
// console.log(std2)
// console.log(std3)
// console.log(std4)


// var students = ["Ali", "Sara", "Yunus", "Hunain", "Ayan", "Ahsan"];
// Indexing      0         1      2        3         4       5

// console.log(students);

// console.log(students[2]);
// console.log(students[3]);
// console.log(students[5]);

// for(var i = 0; i < students.length; i++){
//     console.log("Students name are: " + students[i]);
// }

// var ages = [23, 13, 14, 33, 20, 18];

// console.log(ages[3]);

// Array Methods

// var countries =  ["Pak", "Bharat", "Aussies", "China", "Ban"];

// Push method add element at the end
// var updateCountries = countries.push("Sri")


// Pop method remove element at the end
// var updateCountries = countries.pop();

// Shift method remove element at the start
// var updateCountries = countries.shift();

// UnShift method add element at the start
// var updateCountries = countries.unshift("Afg");

// console.log(countries)

// functions declaration

// function print(){
//     console.log("Hello in functions")
//     console.log("Umeed hei apko samjh ayega")
//     console.log("Focus rkhiyega ajaygea")
// }

// functions calling

// print();


// function add(){
//     console.log(9 + 15);
// }

// add();

// arguments and parameters

// function sum(num1, num2){
//     var add = num1 + num2;
//     console.log("Addition result is " + add);
// }

// sum(23, 55)

// function sub(num1, num2){
//     var add = num1 - num2;
//     console.log("Subtraction result is " + add);
// }

// sub(60, 55)

// function mult(num1, num2){
//     var add = num1 * num2;
//     console.log("Multiplication result is " + add);
// }

// mult(23, 55)

// function div(num1, num2){
//     var add = num1 / num2;
//     console.log("Division result is " + add);
// }

// div(10, 5)


// function greet(){
//    alert("Hello, good morning!!")
// }

// function getInput(){
//     var input = prompt("Enter your name");

//     greet()
// }

// getInput()



















































































































