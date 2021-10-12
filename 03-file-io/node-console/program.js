const fs = require('fs')

const output = `Hello ${process.argv[2]}!`
console.log(output)
fs.writeFileSync('output.txt', output)
