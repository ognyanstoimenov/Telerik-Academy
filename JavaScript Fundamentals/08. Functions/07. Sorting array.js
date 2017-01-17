function solve(args) {
    function maxElement(arr, index) {
        let max = index;
        for (let i = index + 1; i < arr.length; i++) {
            if (arr[i] > arr[max]) {
                max = i;
            }
        }
        return max;
    }
    function sortArrDesc(arr) {
            for (let i = 0; i < arr.length; i++) {
                let max = maxElement(arr, i);
                if (arr[max] > arr[i]) {
                    let swap = arr[max];
                    arr[max] = arr[i];
                    arr[i] = swap;
                }
            }
        }
    let nums = args[1].split(' ').map(Number);
    sortArrDesc(nums);
    console.log(nums.reverse(nums).join(' '));
}