$(document).ready(function () {

    PokazLadowanie();
    WyslijNaSerwer();
    $(".input-group-append").click(function () {

        WyslijNaSerwer();

    });

});

function WyslijNaSerwer() {
    PokazLadowanie();
    var filtr = $("#txtFiltr").val();
    $.ajax({
        method: "POST",
        url: "ZawodnicyAPI.aspx",
        data: { filtr: filtr }
    })
        .done(function (msg) {
            //alert("Data Saved: " + msg);
            $(".col-md-12").html(msg)

            $("tr").click(function () {

                var id = $(this).data("id");
                PokazSzczegoly(id);

            });

        });

}

function PokazLadowanie() {
    var obrazek = $("#dvLadowanie").html()
    $(".col-md-12").html(obrazek)
}

function PokazSzczegoly(id) {
    PokazLadowanie();
    $.ajax({
        method: "POST",
        url: "EdycjaZawodnika.aspx",
        data: { id: id }
    })
        .done(function (msg) {
            //alert("Data Saved: " + msg);
            $(".col-md-12").html(msg)

            $("#btnZapisz").click(function (e) {

                e.preventDefault(); // nie wywołuj domyślnej akcji - wysłanie formularza na serwer
                var imie = $("#txtImie").val();
                var nazwisko = $("#txtNazwisko").val();
                var kraj = $("#txtKraj").val();
                var miasto = $("#txtMiasto").val();
                var waga = $("#txtWaga").val();
                var wzrost = $("#txtWzrost").val();
                var dataUr = $("#txtDataUr").val();

                data = {
                    id: id,
                    imie: imie,
                    nazwisko: nazwisko,
                    kraj: kraj,
                    miasto: miasto,
                    waga: waga,
                    wzrost: wzrost,
                    dataUr: dataUr
                };

                ZapiszZawodnika(data)
            });

            $("#btnUsun").click(function (e) {
                e.preventDefault(); // nie wywołuj domyślnej akcji - wysłanie formularza na serwer
                UsunZawodnika(id);
            });


        });
}

function ZapiszZawodnika(data) {
    //  PokazLadowanie();
    $.ajax({
        method: "POST",
        url: "ZapiszZawodnikaAPI.aspx",
        data: data
    })
        .done(function (msg) {
            /*alert("Data Saved: " + msg);*/
            WyslijNaSerwer()
        });
}

function UsunZawodnika(id) {
    $.ajax({
        method: "POST",
        url: "UsunZawodnikaAPI.aspx",
        data: { id: id }
    })
        .done(function (msg) {
            /*alert("Data Saved: " + msg);*/
            WyslijNaSerwer()
        });
}