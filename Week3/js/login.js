function initLogin() {

    $('#error').hide();

    $('#submit-btn').click(function(event) {
         if (initLogin()) {
            alert("Logging in");
         }
    });
}

function initLogin() {
    if ($('#Username').val().length == 0) {
        displayError("Username");
        return false;
    }
    if ($('#Password').val().length == 0) {
        displayError("Password");
        return false;
    }
    return true;
}

function displayError(error) {
    $('#error').text(error);
    $('#error').show();
}