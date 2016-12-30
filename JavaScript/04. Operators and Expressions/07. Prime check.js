function solve(args) {
    var num = +args[0];
    var prime = true;
    if(num < 2){
         prime = false;
    };
    for(var i = 2; i < num; i++){
        if(num % i == 0){
             prime = false;
        };
    };
    console.log(prime);
};

