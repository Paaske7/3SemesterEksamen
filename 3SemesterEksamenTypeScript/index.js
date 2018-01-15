"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
// Imports
var express = require("express");
var bodyParser = require("body-parser");
// Init Express Server
var app = express();
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
// Start Express Server
var port = (process.env.PORT || 3000);
app.listen(port);
console.log("Server Listening on Port: " + port);
// Logic
app.get("/", function (req, resp) {
    resp.sendFile(__dirname + "/index.html");
});
