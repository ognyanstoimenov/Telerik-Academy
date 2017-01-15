function solve(args) {
    var num = +args[0];
    var trueNum = false;
    if(num % 7 == 0 && num % 5 == 0) {
        trueNum = true;
    }
    console.log(trueNum + ' ' + num)
}