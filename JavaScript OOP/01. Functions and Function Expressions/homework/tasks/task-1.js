function solve() {
	return function sum(args) {
		if (args === undefined) {
			throw "Error";
		}
		else if (args.length === 0) {
			return null;
		}
		else {
			let nums = args.map(Number);
			let sum = 0;
			for (let i = 0; i < nums.length; i++) {
				sum += nums[i];
			}
			if(isNaN(sum)){
				throw "Not convertible to number";
			}
			else {
				return sum;
			}
		}
	}
}

module.exports = solve;
