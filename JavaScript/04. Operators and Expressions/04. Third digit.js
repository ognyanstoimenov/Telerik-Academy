function solve(args){
    var num = args[0];
    var index = num.length-3;
    var thirdDigit = index < 0? 0 : num[index];
    console.log((thirdDigit == 7) + ' ' + ((thirdDigit!=7) ? thirdDigit : ''));
};