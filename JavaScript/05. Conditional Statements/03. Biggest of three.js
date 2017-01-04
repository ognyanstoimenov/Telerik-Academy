function solve(args){
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    if(a >= b && a >= c){
        return a;
    }
    else if(b >= a && b >= c){
        return b;
    }
    else if(c >= a && c >= b){
        return c;
    }
}