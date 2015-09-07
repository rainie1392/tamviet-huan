$.xhrPool = [];
$.xhrPool.abortAll = function () {
    $(this).each(function (idx, jqXHR) {
        jqXHR.abort();
    });
};

$.ajaxSetup({
    beforeSend: function (jqXHR) {
        $.xhrPool.push(jqXHR);
        $("#loading-mask").show();
    }
});
$(document).ajaxStop(function () {
    $.xhrPool.pop();
    $("#loading-mask").hide();
});

$(document).ajaxError(function () {
    $.xhrPool.abortAll();
});
window.fbAsyncInit = function () {
    FB.init({
        appId: '317495925099540', // Set YOUR APP ID
        status: true, // check login status
        cookie: true, // enable cookies to allow the server to access the session
        xfbml: true,  // parse XFBML
        oauth: true // Enable oauth authentication
    });
};
function PostToWall(name, image) {
    FB.ui({
        method: 'feed',
        name: name,
        link: '/',
        picture: '/' + image,
        caption: '',
        description: ''
    }, function (response) {
        if (response && response.post_id) {
            //                    alert('Post was published.');
        } else {
            //                    alert('Post was not published.');
        }
    });
}
(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/all.js#xfbml=1&appId=317495925099540";
    fjs.parentNode.insertBefore(js, fjs);
} (document, 'script', 'facebook-jssdk'));

function CheckAccountLogin() {
    var accountId = 0;
    $.ajax({
        url: '/Account/CheckAccountLogin',
        type: 'POST',
        async: false,
        data: JSON.stringify({}),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data.Result == "OK") {
                accountId = data.Data;
            }
            else {
                alert(data.Message);
            }
        },
        error: function () {
        }
    });
    return accountId;
}