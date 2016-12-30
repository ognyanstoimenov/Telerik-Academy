function solve(args) {
    var x = +args[0];
    var y = +args[1];

    var distance = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
    if(distance <= 1.5){
        var inCircle = 'inside ';
    }
    else inCircle = 'outside ';
    if (x >= -1 && x <= 5 && y >= -1 && y <= 1)
		var inRect = 'inside ';
	else
		inRect = 'outside ';
    console.log(inCircle + 'circle ' + inRect + 'rectangle');
};