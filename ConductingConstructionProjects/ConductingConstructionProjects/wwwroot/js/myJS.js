﻿function messagemessage(e) { alert(e); }
function  (key, value) { localStorage.setItem(key, value); }
function get(key) { return localStorage.getItem(key); }
function remove(key) { return localStorage.removeItem(key); }
function logError(errorMessage) { console.log(errorMessage); }