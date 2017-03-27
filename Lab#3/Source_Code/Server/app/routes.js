var express = require('express');

var path    = require('path');


var router = express.Router();

module.exports = router;

//route for our homepage
router.get('/', function(req, res) {
    res.sendFile(path.join(__dirname, '../index.html'));
});

//route for our contacts page
router.get('/contacts', function(req, res) { 
    res.send('hello, i am on new contacts page!');
});

router.get('/contacts');
router.post('/contacts');