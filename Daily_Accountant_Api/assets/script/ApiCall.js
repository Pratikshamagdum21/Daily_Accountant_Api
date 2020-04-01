/// <reference path="C:\Users\riya\Desktop\Partiksha\Daily_Accountant_Api\Daily_Accountant_Api\ViewPage/Home.html" />
/// <reference path="C:\Users\riya\Desktop\Partiksha\Daily_Accountant_Api\Daily_Accountant_Api\ViewPage/Home.html" />
/// <reference path="C:\Users\riya\Desktop\Partiksha\Daily_Accountant_Api\Daily_Accountant_Api\ViewPage/Home.html" />
$(document).ready(function () {
    var table = $("#ExpensesId").DataTable({bFilter: false,
        ajax: {
            type: 'GET',
            url: "/api/ExpensesDetail",
            dataSrc: ""
        },
        columns: [
            {
                data: "Expenses_Id",
            },
            {
                data:"Category.CategoryName"
            },
            {
                data: "date"
            },
            {
                data: "Note"
            },
            {
                data: "Amount"
            },
            {
                data: "Expenses_Id",
                render: function (data) {
                    return "<button class='btn-link js-Edit' data-toggle='modal' data-target='#myModal' data-ExpensesDetail-Expenses_Id=" + data + ">Edit</button>";
                }
            },
            {
                data: "Expenses_Id",
                render: function (data) {
                    return "<button class='btn-link js-delete' data-ExpensesDetail-Expenses_Id=" + data + ">Delete</button>";
                }
            }
        ]
    });
    $("#ExpensesId").on("click", ".js-delete", function () {
            var button = $(this);
            bootbox.confirm("Are you sure you want to delete this Expenses?", function (result) {
                if (result) {
                    $.ajax({
                        url: "/api/ExpensesDetail/" + button.attr("data-ExpensesDetail-Expenses_Id"),
                        method: "DELETE",
                        success: function () {
                            table.row(button.parents("tr")).remove().draw();
                        }
                    });
                }
            });
    });

    $("#ExpensesId").on("click", ".js-Edit", function () {
        var button = $(this);
        bootbox.confirm("Are you sure you want to delete this customer?", function (result) {
            if (result) {
                $.ajax({
                    url: "/api/ExpensesDetail/EditExpenses/" + button.attr("data-ExpensesDetail-Expenses_Id"),
                    method: "patch",
                    success: function () {
                        
                    }
                });
            }
        });
    });

        var ExpensesDropodown = $("#selectExpenses");
        var ExpensesDropodown1 = $("#selectExpenses1");
        $.ajax({
            type: "POST",
            url: "/ExpensesDetails/AjaxMethod_ExpensesList",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                ExpensesDropodown.empty().append('<option selected="selected" value="0">Please select</option>');
                ExpensesDropodown1.empty().append('<option selected="selected" value="0">Please select</option>');
                $.each(response, function () {
                    ExpensesDropodown.append($("<option></option>").val(this['Value']).html(this['Text']));
                    ExpensesDropodown1.append($("<option></option>").val(this['Value']).html(this['Text']));
                });
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    $('#Investment').click(function AddExpenses() {

    var List = document.createElement("li");
    var para = document.createElement("a");
    var investment = {};
    investment.Investment_Name = $('#InvestmentName').val();
    para.id = "AddInvestment";
    para.innerHTML = investment.Investment_Name;
    document.getElementById("pageSubmenu").appendChild(List).appendChild(para);
    $.ajax({
        type: "POST",
        dataType: 'json',
        data: investment,
        url: "/Api/Investment/AddInvestment/",
        success: function (data) {
            
        }
    })   
});

    $('#AddExpense').click(function AddExpenses() {
        alert("Add Expenses");
        var expenses = {};
        expenses.CategoryId = $('#selectExpenses').val();
        expenses.Date = $('#timepicker1').val();
        expenses.Note = $('#inp-Note').val();
        expenses.Amount = $('#inp-amount').val();
        $.ajax({
            type: "POST",
            dataType: 'json',
            data: expenses,
            url: "/Api/ExpensesDetail/AddExpenses/",
            success: function (data) {
               toastr.success('Hi! I am success message.');
                alert(data);
            }
        })
        });

});
function Submit() {
    alert("Hey");
    var user = {};
    user.Mail = $('#userName').val();
    user.Password = $('#password').val();
    $.ajax({
        type: "POST",
        dataType: 'json',
        data: user,
        url: "/Api/Login/NewUser/",
        success: function (data) {
            alert("Sucess");
                $(".notify").toggleClass("active");
                $("#notifyType").toggleClass("success");

                setTimeout(function () {
                    $(".notify").removeClass("active");
                    $("#notifyType").removeClass("success");
                }, 2000);
                 window.location.replace("login.html");
            //Session["UserId"] = 'Id';
        }
    })
}

$('#AddWallet').click(function AddWallet() {
    alert("Add Wallet");
    var Wallet = {};
    Wallet.WalletName = $('#WalletName').val();
    Wallet.Amount = $('#WalletAmount').val();
    $.ajax({
        type: "POST",
        dataType: 'json',
        data: Wallet,
        url: "/Api/Wallet/AddWallet/",
        success: function (data) {
            alert(data);
        }
    })
});


