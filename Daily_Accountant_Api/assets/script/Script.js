$(document).ready(function () {
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });
});
$(function () {
    $('.dates #timepicker').datepicker({
        'timepicker': false,
        'datepicker': true,
        'format': 'yyyy-mm-dd',
        'autoclose': true
    })
    $('#timepicker1').datepicker({
        'timepicker': false,
        'datepicker': true,
        'format': 'yyyy-mm-dd',
        'autoclose': true
    })
});

function Submit() {
    x = document.getElementById("Confirmpassword").value;
    y = document.getElementById("password").value;
    if (x == y) {
        window.open("Login.html");
    }
    else
        alert("Password is not match");
}


//function addItem() {
//    x = document.getElementById("inp-category").value;
//    y = document.getElementById("timepicker1").value;
//    a = document.getElementById("inp-username").value;
//    b = document.getElementById("inp-amount").value;
//    if (x == "" || y == "" || a == "" || b == "") {
//        alert("Input in not filled");
//    } else {
//        var tbodyId = document.getElementById("tbodyId");

//        var tr = document.createElement("tr");

//        var inpcategory = document.getElementById("inp-category");
//        var cell1 = tr.insertCell(0);
//        cell1.appendChild(document.createTextNode(inpcategory.value));

//        var timepicker1 = document.getElementById("timepicker1");
//        var cell2 = tr.insertCell(1);
//        cell2.appendChild(document.createTextNode(timepicker1.value));

//        var inpusername = document.getElementById("inp-username");
//        var cell3 = tr.insertCell(2);
//        cell3.appendChild(document.createTextNode(inpusername.value));

//        var inpamount = document.getElementById("inp-amount");
//        var cell4 = tr.insertCell(3);
//        cell4.appendChild(document.createTextNode(inpamount.value));

//        tbodyId.appendChild(tr);
//        document.getElementById("myForm").reset();
//        document.getElementById("container").style.display = "block";
//    }
//}