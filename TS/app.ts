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

let mixedDT: (string | number) [];

mixedDT = ["Apple", "Grapes", "Banana", 89, 110, 90];

mixedDT.forEach((e) => {
  if(typeof e == "string"){
    console.log(e.toUpperCase())
  }else{
    console.log(e.toFixed(2))
  }
})






















