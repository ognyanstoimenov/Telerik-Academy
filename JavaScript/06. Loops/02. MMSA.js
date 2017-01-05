function solve(args) {
    var num = args.map(Number);
    var min = num[0];
    var max = num[0];
    var sum = num[0];
    
    for (var i = 1; i < args.length; i++) {
        if (num[i] < min) min = num[i];
        if (num[i] > max) max = num[i];
        sum += num[i];
    }
    return 'min=' + min.toFixed(2) + '\n' + 'max=' + max.toFixed(2) + '\n' + 'sum=' + sum.toFixed(2) + '\n' + 'avg=' + (sum/num.length).toFixed(2);
}