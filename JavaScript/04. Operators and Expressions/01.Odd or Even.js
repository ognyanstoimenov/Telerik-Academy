function solve(args) {
    var number = +args[0];
    var oddOrEven = null;
    if(number % 2 == 0) {
        oddOrEven = "even";
    }
    else oddOrEven = "odd";
    console.log(oddOrEven + " " + number);
}