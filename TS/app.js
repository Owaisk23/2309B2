console.log("Hello in Typescript!!");
// alert("Good Morning!")
// let userName: string = "Owais Ahmed Khan";
// console.log(userName);
// console.log(typeof userName);
// console.log(userName.toUpperCase())
// console.log(userName.toLowerCase())
// let userAge: number = 23;
// let userEmail: string = "owais23@gmail.com";
// console.log(userAge)
// console.log(userEmail)
// let userDetails: string = `User Name is ${userName} Age is ${userAge} and User Email is ${userEmail}`;
// console.log(userDetails);
// true:1 false:0 null:0
// let userPost = null;
// if(userPost){
//     console.log("Null true huta hai")
// }else{
//     console.log("Null False huta hai")
// }
// let userPost = undefined;
// if(userPost){
//     console.log("Null true huta hai")
// }else{
//     console.log("Null False huta hai")
// }
// let stdMarks: number[] = [77, 90, 82, 67, 99];
// console.log(stdMarks)
// let stdNames: string[] = ["Ayan", "Sami", "Ahsan", "Hunain", "Luqman", "Hanzala", "Daniyal"]
// console.log(stdNames)
// // stdNames.forEach((e) => {
// //     console.log(e)
// // })
// let stds = stdNames.map((e) => {
//     // console.log(e.toUpperCase())
//     return e.toUpperCase();
// })
// console.log(stds);
// Object
// type any
// let product: any = {
//     prodName: "IPhone 16 Pro Max",
//     prodColor: "Purple",
//     prodPrice: 400000,
//     prodStock: true
// }
// console.log(product)
// console.log(product.prodName)
// console.log(product.prodPrice)
// let student: object = {
//     stdName: "Ayan",
//     stdAge: 23,
//     stdExamStatus: true
// }
// console.log(student)
// let student: {
//   stdName: string;
//   stdAge: number;
//   stdExamStatus: boolean;
// } = {
//   stdName: "Ayan",
//   stdAge: 23,
//   stdExamStatus: true,
// };
// let mixedDT: (string | number) [];
// mixedDT = ["Apple", "Grapes", "Banana", 89, 110, 90];
// mixedDT.forEach((e) => {
//   if(typeof e == "string"){
//     console.log(e.toUpperCase())
//   }else{
//     console.log(e.toFixed(2))
//   }
// })
// let Teacher: {name: string, exp: number} = {
//   name: "Haris Naseer",
//   exp: 3
// }
// // Aliased Object Type
// type Student = {
//   sName: string,
//   age?: number
// }
// let stds: Student = {
//   sName: "Hanzala",
//   age: 25
// }
// console.log(stds["sName"])
// console.log(stds.age)
// interface Manager {
//   name: string,
//   salary?: number
// }
// let bankManager: Manager = {
//   name: "Taha Hassan",
//   salary: 230000
// }
// let storeManager: Manager = {
//   name: "Hassan Abbas",
//   salary: 23030
// }
// interface Student {
//   stdId: number,
//   stdName: string
// }
// interface Teacher {
//   tId: number,
//   tName: string
// }
// type intersected_type = Student & Teacher;
// let mixObj: intersected_type = {
//   stdId: 23,
//   stdName: "Luqman",
//   tId: 12,
//   tName: "Owais"
// }
// console.log(mixObj.stdName)
// console.log(mixObj.tName)
// Tuples
// let tuple: [number, string] = [101, "Javeria"]
// let scndEle = tuple[1];
// console.log(scndEle)
// // console.log(tuple[1])
// // IN JS
// const failingResponse = ["Not Found", 404];
// // In TS
// const passingResponse: [string, number] = ["{}", 200]
// if(passingResponse[1] === 200){
//   let data = JSON.parse(passingResponse[0])
//   console.log(data)
// }
// type staffAcc = [number, string, string, string?]
// const staff: staffAcc[] = [
//   [0, "Hassan Shehzad", "hassam@aptechnorth.edu.pk", "CAH"],
//   [1, "Owias", "owais@aptechnorth.edu.pk", "Senior Faculty Member"],
//   [2, "Haris", "haris@aptechnorth.edu.pk", "Senior Faculty Member"],
//   [3, "Afzal", "afzal@aptechnorth.edu.pk"],
//   [4, "Osama", "osama@aptechnorth.edu.pk"]
// ]
// type PayStubs = [staffAcc, ...number[]];
// const payStubs: PayStubs[] = [
//   [staff[0], 350],
//   [staff[1], 400, 500],
//   [staff[2], 400, 500, 600],
//   [staff[3], 200, 450, 800, 750],
//   [staff[4], 400, 500, 600],
// ]
// let monthOnePayStubs: number =   payStubs[0][1] + payStubs[1][1] + payStubs[2][1] + payStubs[3][1] + payStubs[4][1];
// let monthTwoPayStubs: number =   payStubs[1][2] + payStubs[2][2] + payStubs[3][2] + payStubs[4][2];
// console.log(monthOnePayStubs)
// console.log(monthTwoPayStubs)
// enum
// enum Colors {Blue, Red, Green}
// const c: Colors = Colors.Red;
// console.log(c)
// enum Colors1 {Blue = 1, Red, Green}
// const color: string = Colors1[3];  
// console.log(color)
// enum Cars {City = 8, BMW = 16, Civic = 23, Accord = 7, Mehran = 1}
// const car: string = Cars[7];
// console.log(car)
