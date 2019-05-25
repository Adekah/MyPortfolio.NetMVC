





function UpdateAboutus(aboutus, aboutusid = 1) {
    let objdata;
    $.ajax({
        url: 'AboutUs',
        type: 'POST',
        data: JSON.stringify({

            aboutus: aboutus,
            aboutusid:aboutusid
        }),
        dataType: 'json',
        processData: false,
        xhrFields: {
            withCredentials: true
        },
        contentType: 'application/json;charset=utf-8',
        error: function (result) { },
        success: function (result) { },
        async: false,
        processData: false
    });

}

