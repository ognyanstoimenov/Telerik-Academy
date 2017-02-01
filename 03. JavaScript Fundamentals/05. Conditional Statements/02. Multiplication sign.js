function solve(args) {
    var num1 = +args[0];
    var num2 = +args[1];
    var num3 = +args[2];

    var product = num1 * num2 * num3;

    if (product < 0) {
        console.log ('-');
    }
    else if (product == 0) {
        console.log ('0');
    }
    else {
        console.log ('+');
    }
}