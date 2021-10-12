let findSum = (n) => {
    let sum = 0

    for (let i = 0; i < n.length; i++) {
        sum += n[i]*n[i]
    }

    return sum
}

let findSum2 = (n) => {
    return n.map(o => o*o).reduce((a,b) => a+b)
}

console.log(findSum(process.argv.slice(2)))
console.log(findSum2(process.argv.slice(2)))
