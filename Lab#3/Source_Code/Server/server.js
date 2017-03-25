var express = require('express');
var app = express();
var port = 8080;

// start the server
app.listen(port, function() {
    console.log('app started!');
});

//route for our homepage
app.get('/', function(req, res) {
    res.send('hello again!');
});

//route for our contacts page
app.get('/contacts', function(req, res) {
    res.send('hello, i am contacts page!');
});

app.get('/contacts');