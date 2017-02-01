function solve(params) {
    var num1 = +params[0];
    var num2 = +params[1];

    if(num1 > num2){
        var swap = num1;
        num1 = num2;
        num2 = swap;
    }

    console.log(num1 + ' ' + num2);
}