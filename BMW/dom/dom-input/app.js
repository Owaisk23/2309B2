

function Login(){
    var email = document.getElementById("email").value;
    var pass = document.getElementById("password").value;
    
    if(email == "" || pass == ""){
        alert("Plz fill all the fields");
    }else{
        alert("Your email is " + email + " & your password is " + pass);
    }

}