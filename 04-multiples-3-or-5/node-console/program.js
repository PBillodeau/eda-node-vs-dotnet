let findSum = (n) => {
    let sum = 0

    for (let i = 1; i <=n; i++) {
        if (i % 3 == 0 || i % 5 == 0) {
            sum += i
        }
    }

    return sum
}

let findSum2 = (n) => {
    return Array.from({ length: n }, (v, i) => i + 1).filter(o => (o % 3 == 0) || (o % 5 == 0)).reduce((a, b) => a + b)
}

console.log(findSum(process.argv[2]))
console.log(findSum2(process.argv[2]))
