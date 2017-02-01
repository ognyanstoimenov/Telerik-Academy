function solve(args){
    function appearenceInArr(arr,num){
        let count = 0;
        for(let i in arr){
            if(num === arr[i]){
                count++;
            }
        }
        return count;
    }
    let arr = args[1].split(' ').map(Number);
    let num = +args[2];
    console.log(appearenceInArr(arr,num));
}