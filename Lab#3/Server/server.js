// var http = require('http');

// function handleRequests(req, res) {
//     res.end('Hello, World!');
// }

// var server = http.createServer(handleRequests);


// server.listen(8180, function() {
//     console.log('Listening on port 8080')
// });

/////////////////// EXPRESS //////////////////////

var express = require('express');
var app = express();
var port = 8080;

app.listen(port, function() {
    console.log('app started!');
});

app.get('/', function(req, res) {
    res.send('hello again!');
});

