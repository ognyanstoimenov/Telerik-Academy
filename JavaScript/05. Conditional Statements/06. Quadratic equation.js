function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    var D = b * b - (4 * a * c);
    //return D;
    if (D < 0) {
        return 'no real roots'
    }

    x1 = (-b + Math.sqrt(D)) / (2 * a);
    x2 = (-b - Math.sqrt(D)) / (2 * a);

    if (D == 0) {
        return 'x1=x2=' + x1.toFixed(2);
    }
    if(x1 < x2){
    return 'x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2);
    }
    else return 'x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2);

}