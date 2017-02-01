function solve(args) {
    var n = +args[0];

    var matrix = new Array(n);
    for(var i = 0;i<n;i++){
        matrix[i] = new Array(n);
    } 
    var count = 0;
    var result = ' ';
     for (var i = 0, r = 0; r < n; i++) {
       matrix[r][i] = ++count;
        if (i == n - 1) {
            i = 0;
            r++;
            count = r;
        }
     }
        for (i = 0; i < n; i++) {
        for (var j = 0; j < n; j++) {
            result += matrix[i][j];
        }
        result += '\n';
    }
    return result;
}
console.log(solve(['4']));