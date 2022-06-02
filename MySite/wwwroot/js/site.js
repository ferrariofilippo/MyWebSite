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

let dots = 1;
let defaultTxt;

function start_loading(baseTxt) {
    document.getElementById('pop_up_text').innerText = baseTxt;
    document.getElementById('ldng_pop_up').style.display = 'block';
    defaultTxt = baseTxt;
    setInterval(update_txt, 1000);
}

function update_txt() {
    document.getElementById('pop_up_text').innerText = defaultTxt + '. '.repeat(dots);
    dots++;
    if (dots > 3)
        dots = 1;
}