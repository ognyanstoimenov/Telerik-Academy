function solve(args){
    var x = +args[0];
    var y = +args[1];
    var distance = Math.sqrt(x * x + y * y);
    if(distance <= 2){
        var inside = 'yes';
    }
    else inside = 'no';
    console.log(inside + ' ' + distance.toFixed(2));
};