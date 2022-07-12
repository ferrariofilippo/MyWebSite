"use-strict"

async function fetch_visited() {
    const visited = await fetch('/Data/visited.json').then((txt) => txt.json());
    const par = document.createElement('p');
    const container = document.getElementById('map-container');
    par.innerHTML = `Visited: ${visited['visited']}/195`;
    container.appendChild(par);
}