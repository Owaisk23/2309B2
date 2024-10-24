console.log("Hello in Typescript!!");
// alert("Good Morning!")
var userName = "Owais Ahmed Khan";
console.log(userName);
console.log(typeof userName);
console.log(userName.toUpperCase());
console.log(userName.toLowerCase());
var userAge = 23;
var userEmail = "owais23@gmail.com";
console.log(userAge);
console.log(userEmail);
var userDetails = "User Name is ".concat(userName, " Age is ").concat(userAge, " and User Email is ").concat(userEmail);
console.log(userDetails);
// true:1 false:0 null:0
var userPost = null;
if (userPost) {
    console.log("Null true huta hai");
}
else {
    console.log("Null False huta hai");
}
