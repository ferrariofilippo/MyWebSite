"use-strict"
var old_height = 2592;
var old_width = 4500;
var new_height = 2592;
var new_width = 4500;

async function fetch_countries() {
    return await fetch('/Data/Coords.json').then((txt) => txt.json());
}

function get_coords(actual_coords) {
    var array = actual_coords.split(',');
    return proportion(array);
}

function proportion(coord_arr) {
    for (var i = 0, j = 1; j < coord_arr.length; i += 2, j += 2) {
        coord_arr[i] = Math.round(coord_arr[i] * new_width / old_width);
        coord_arr[j] = Math.round(coord_arr[j] * new_height / old_height);
    }
    return coord_arr.join(',');
}

function adjust_hitboxes() {
    const world = document.getElementById('worldmap');
    var map = document.getElementById('countries');
    new_width = world.clientWidth;
    new_height = world.clientHeight;

    for (var i = 0; i < map.children.length; i++) {
        map.children[i].coords = get_coords(map.children[i].coords);
    }

    old_height = new_height;
    old_width = new_width;
}

async function load_countries() {
    var countries = await fetch_countries();    
    var map = document.getElementById('countries');
    const world = document.getElementById('worldmap');

    new_width = world.clientWidth;
    new_height = world.clientHeight;

    for (var i = 0; i < countries.length; i++) {
        const area = document.createElement('area');
        area.shape = 'poly';
        area.alt = countries[i]['country'];
        area.href = countries[i]['url'];
        
        var coords = [];
        for (var j = 0; j < countries[i]['coords'].length; j++) {
            coords.push(countries[i]['coords'][j][0]);
            coords.push(countries[i]['coords'][j][1]);
        }
        area.coords = proportion(coords);
        map.appendChild(area);
    }
    old_width = world.clientWidth;
    old_height = world.clientHeight;
}