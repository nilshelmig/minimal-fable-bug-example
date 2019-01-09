"use strict";

let path = require("path");
let sharedConfig = require("./shared.webpack.config.js");

// --- Start Message ---
var isProduction = process.env.NODE_ENV && process.env.NODE_ENV.trim() == "production";
console.log("Bundling for " + (isProduction ? "production" : "development") + "...");
// ---------------------

function resolve(dir) {
  return path.resolve(__dirname, dir);
}

module.exports = {
  mode: isProduction ? "production" : "development",
  entry: {
    webUI: resolve("WebUI.Fable/WebUI_Fable.fs")
  },
  output: {
    filename: "PPLUS-WebUI.js",
    publicPath: "/webui/",
    path: resolve("out"),
    library: "webUI"
  },
  module: sharedConfig.module(isProduction),
  resolve: sharedConfig.resolve
};
