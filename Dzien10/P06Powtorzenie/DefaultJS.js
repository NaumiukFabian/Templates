$(document).ready(function () {
    WyslijNaSerwer();
});

function WyslijNaSerwer() {

    $.ajax({
        method: "POST",
        url: "ZawodnicyAPI.aspx",

    })
        .done(function (msg) {
            /*alert("Data Saved: " + msg);*/
            $(".col-md-12").html(msg)
        });
}