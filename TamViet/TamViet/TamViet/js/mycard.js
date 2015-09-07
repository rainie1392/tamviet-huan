
function AddToCard(productId, quantity) {
    $.ajax({
        url: '/Order/AddToCard',
        type: 'POST',
        data: JSON.stringify({ 'productId': productId, 'quantity': quantity }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data.Result == "OK") {
                window.location.href = "/gio-hang.html";
            }
        },
        error: function () {
        }
    });
}
function RemoveItemCard(productId) {
    $.ajax({
        url: '/Order/RemoveItemCard',
        type: 'POST',
        data: JSON.stringify({ 'productId': productId }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data.Result == "OK") {
                location.reload();
            }
        },
        error: function () {
        }
    })
}
function UpdateQuantityCard(event, productId) {
    var quantity = $("#txtQuantity" + productId).val();
    if (!$.isNumeric(quantity) || quantity <= 0) {
        $("#txtQuantity" + productId).val('1');
    }
    else if (event.keyCode == 13) {
        $.ajax({
            url: '/Order/UpdateQuantityCard',
            type: 'POST',
            data: JSON.stringify({ 'productId': productId, 'quantity': quantity }),
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                if (data.Result == "OK") {
                    location.reload();
                }
            },
            error: function () {
            }
        });
    }
}
function UpQuantityCard(productId) {
    $.ajax({
        url: '/Order/UpQuantityCard',
        type: 'POST',
        data: JSON.stringify({ 'productId': productId }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data.Result == "OK") {
                location.reload();
            }
        },
        error: function () {
        }
    });
}

function DownQuantityCard(productId) {
    $.ajax({
        url: '/Order/DownQuantityCard',
        type: 'POST',
        data: JSON.stringify({ 'productId': productId }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data.Result == "OK") {
                location.reload();
            }
        },
        error: function () {
        }
    });
}




