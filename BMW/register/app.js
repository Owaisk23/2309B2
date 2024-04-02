function signUp() {
    var uname = document.getElementById('user_name').value;
    var uemail = document.getElementById('user_email').value;
    var upass = document.getElementById('user_password').value;

    if(uname == "" || uemail == "" || upass == ""){
        var errorSpan = document.getElementById('error');
        errorSpan.innerText = "Plz fill all the fields";
        errorSpan.style.display = "inline";
    }else{
        // saving user data in local storage
        localStorage.setItem('name', uname);
        localStorage.setItem('email', uemail);
        localStorage.setItem('password', upass);
        
        // change location to login page
        location.href = "./login/login.html";
    }
}