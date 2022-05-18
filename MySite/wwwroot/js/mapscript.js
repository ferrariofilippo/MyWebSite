"use-strict"

var old_height = 2592;
var old_width = 4500;
var new_width = 2592;
var new_width = 4500;

function fetch_countries() {
    const fs = require('fs');
    return JSON.parse(fs.readFileSync('~/Data/Coords.json'));
}

function get_coords(actual_coords) {
    var array = actual_coords.split(',');
    for (var i = 0, j = 1; j < array.length; i += 2, j += 2) {
        array[i] *= new_width / old_width;
        array[j] *= new_height / old_height;
    }
    return array.join(',');
}

function adjust_hitboxes() {
    var map = document.getElementById('worldmap');
    new_width = map.clientWidth;
    new_height = map.clientHeight;
    console.log(map.clientHeight);
    console.log(map.clientWidth);

    for (var i = 0; i < map.children.length; i++) {
        console.log(map.children[i]);
        map.children[i].coords = get_coords(map.children[i].coords);
    }

    old_height = new_height;
    old_width = new_width;
}

function load_countries() {
    var countries = fetch_countries();
}