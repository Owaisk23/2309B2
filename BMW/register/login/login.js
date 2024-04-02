function logIn(){
    var email = document.getElementById('user_email').value;
    var password = document.getElementById('user_password').value;

    var localEmail = localStorage.getItem('email')
    var localPass = localStorage.getItem('password')

    if(email == localEmail && password == localPass){
        alert("LogIn success")
    }else{
        alert("Kon Hoo AAppp??")
    }

}