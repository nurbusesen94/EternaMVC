function ajaxGetir() {
    //$.ajax({
    //    url: "AJAX/Index",
    //    type: "GET",
    //    data: {
    //        "ad": $(".iAd").val(),
    //        "soyad": $(".iSoyad").val(),
    //        "yil": $(".iYas").val()
    //    },
    //    success: function (veri) {
    //        $(".pIcerik").html(veri);
    //    },
    //    error: function (hata) { alert(hata.responseText) }

    //})

    $.ajax({
        url: "AJAX/Sehirler",
        type: "GET",      
        success: function (veri) {
            $.each(veri, function (index, item) {
                $(".sehir").append("<option value='" + item.ID +"'>" + item.TagName + "</option>");
            })
        },
        error: function (hata) { alert(hata.responseText) }

    })
}

function IlceGetir(tiklayan) {
    $.ajax({
        url: "AJAX/Ilceler",
        type: "GET",
        data: { "Plaka": $(tiklayan).val() },
        success: function (veri) {
            $(".ilceler").empty();
            $(".ilceler").append("<option value='0'>İlçe Seçiniz</option>");
            $.each(veri, function (index, item) {
                $(".ilceler").append("<option value='" + item.ID + "'>" + item.IlceAd + "</option>");
            })
        },
        error: function (hata) { alert(hata.responseText) }

    })
   
}
function MahalleGetir(tiklayan) {
    $.ajax({
        url: "AJAX/Mahalle",
        type: "GET",
        data: { "id": $(tiklayan).val() },
        success: function (veri) {
            $(".mahalleler").empty();
            $.each(veri, function (index, item) {
                $(".mahalleler").append("<option value='" + item.ID + "'>" + item.MahalleAd + "</option>");
            })
        },
        error: function (hata) { alert(hata.responseText) }

    })

}