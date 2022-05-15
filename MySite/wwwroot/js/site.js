// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use-strict"

function copy_email() {
    var email = document.getElementById("emailBtn");
    navigator.clipboard.writeText(email.textContent.trim());
    email.title = "Email Copied!";
}

function reset_tooltip(){
    var email = document.getElementById("emailBtn");
    navigator.clipboard.readText().then(txt => console.log(txt));
    navigator.clipboard.readText().then(text => {
        if (text != email.textContent) {
            console.log("Changed");
            email.title = "Copy Email";
        }
    });
}