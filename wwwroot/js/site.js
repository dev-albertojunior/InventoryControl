// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#email-input').blur(function () {
        var email = $(this).val();
        if (!isValidEmailAddress(email)) {
            $('#email-error').show();
        } else {
            $('#email-error').hide();
        }
    });
});

function isValidEmailAddress(email) {
    // Regular expressions to validate email
    var regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    return regex.test(email);
}