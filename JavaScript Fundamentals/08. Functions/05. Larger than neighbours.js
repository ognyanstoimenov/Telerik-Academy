function solve(args) {
    function isLargerThanNeighbours(arr, index) {
        if (arr[index - 1] < arr[index] && arr[index + 1] < arr[index]) {
            return true;
        }
        else return false;
    }
    let count = 0;
    let nums = args[1].split(' ').map(Number);
    for (let i = 0; i < nums.length; i++) {
        if (isLargerThanNeighbours(nums, i)) {
            count++;
        }
    }
    console.log(count);
}