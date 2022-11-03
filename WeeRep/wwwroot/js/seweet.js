
$(document).ready(function () {
    Submit();
    CheckTime();
    ContatSubmit();
});

function CheckTime() {
    if (document.getElementById("timeEnd")) {
        let ut = document.getElementById("timeEnd")
        setInterval(() => {
            let dt = new Date();
            dt.setMinutes(dt.getMinutes() + 30)
            ut.innerText = dt.toLocaleTimeString();
        }, 1000)
    }
}

function Submit() {
    $('#Submit').click(function() {
        var selectedDate = $("#datePicker").val();
        var Name = $("#Name").val();
        var Mobil = $("#Mobil").val();
        var PhonModel = $("#PhonModel").val();

        if (selectedDate == "" || Name == "" || Mobil == "" || Email == "" || PhonModel == "") {
            
        } else {
            Swal.fire(
                'Email',
                "Your email have been sent, thank you!",
                'success'
            );
        }
    });

}
function ContatSubmit() {
    $('#ContatSubmit').click(function() {
        var Name = $("#Name").val();
        var Mobil = $("#Mobil").val();
        var Email = $("#Email").val();

        if ( Name == "" || Mobil == "" || Email == "") {
            console.log('Date is not selected Contact!');
            console.log('You need to enter your name Contact!');
        } else {
            Swal.fire(
                'Email',
                "Your email have been sent, thank you!",
                'success'
            );
        }
    });

}



