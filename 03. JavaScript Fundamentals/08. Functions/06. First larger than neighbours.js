function solve(params) {
     function isLargerThanNeighbours(arr, index) {
        if (arr[index - 1] < arr[index] && arr[index + 1] < arr[index]) {
            return true;
        }
        else return false;
    }
    function firstLargerIndex(arr){
        for(let i = 0; i < arr.length; i++){
            if(isLargerThanNeighbours(arr,i)){
                return i;
            }
        }
        return -1;
    }
    let nums = params[1].split(' ').map(Number);
    console.log(firstLargerIndex(nums));
}