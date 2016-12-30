function solve(args) {
    var width = +args[0];
    var height = +args[1];
    var area = width * height;
    var perim = 2 * (width + height);
    console.log(area.toFixed(2) + ' ' + perim.toFixed(2));
};
