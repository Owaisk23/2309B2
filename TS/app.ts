console.log("Hello in Typescript!!")

// alert("Good Morning!")

let userName: string = "Owais Ahmed Khan";

console.log(userName);
console.log(typeof userName);
console.log(userName.toUpperCase())
console.log(userName.toLowerCase())

let userAge: number = 23;

let userEmail: string = "owais23@gmail.com";

console.log(userAge)
console.log(userEmail)

let userDetails: string = `User Name is ${userName} Age is ${userAge} and User Email is ${userEmail}`;

console.log(userDetails);


// true:1 false:0 null:0

let userPost = null;

if(userPost){
    console.log("Null true huta hai")
}else{
    console.log("Null False huta hai")
}

