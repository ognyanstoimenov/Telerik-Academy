function solve(args){
    var num = +args[0];
    num = num >> 3;
    num = num & 1;
    console.log(num);
}