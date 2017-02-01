function solve(args) {
    let nums = args[0].split(' ').map(Number);
    function getMax(a, b) {
        if (a > b) {
            return a;
        }
        else return b;
    }

    console.log(getMax(nums[0], getMax(nums[1], nums[2])));
}