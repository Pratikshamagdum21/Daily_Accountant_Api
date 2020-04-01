var myInput = document.getElementById("password");
function Submit() {
    var re = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}/;
    if (myInput.value.match(re)) {
        alert("correct");
        window.open("../Default.html");
    } else
        alert("Enter the correct Format password");
}

myInput.onfocus = function () {
    document.getElementById("PasswordError").style.display = "block";
}

myInput.onblur = function () {
    document.getElementById("PasswordError").style.display = "none";
}

 


