"use-strict"
let dots = 1;
const baseTxt = 'Loading Memories ';
let update_thread;

function start_loading() {
    const pop_up = document.getElementById('ldng_pop_up');
    update_thread = setInterval(update_txt, 1000, pop_up);
}

function close_loading() {
    clearInterval(update_thread);
    document.getElementById('ldng_pop_up').style.display = 'none';
}

function update_txt(elmnt) {
    if (elmnt.style.display == 'none')
        return;
    elmnt.innerHtml = baseTxt + '. ' * dots;
    dots++;
    if (dots > 3)
        dots = 1;
}