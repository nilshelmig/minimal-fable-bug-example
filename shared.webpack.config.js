"use strict";

let path = require("path");

function resolve(dir) {
  return path.resolve(__dirname, dir);
}

const env_preset = modules => [
  "@babel/preset-env",
  {
    useBuiltIns: "entry",
    modules,
    targets: ["last 4 versions", "ie >= 11"]
  }
];

module.exports.resolve = {
  modules: [resolve("node_modules")],
  extensions: [".js", ".jsx"]
};

module.exports.module = isProduction => ({
  rules: [
    {
      test: /\.fs(x|proj)?$/,
      exclude: /(node_modules)/,
      use: [
        {
          loader: "fable-loader",
          options: {
            babel: {
              presets: [env_preset(false)]
            }
          }
        }
      ]
    }
  ]
});
