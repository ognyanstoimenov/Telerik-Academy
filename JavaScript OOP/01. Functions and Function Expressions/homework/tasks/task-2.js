/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
	function isPrime(number) {
		if(number < 2){
			return false;
		}
		for (let i = 2; i <= Math.sqrt(number); i+=1) {
			if (number % i == 0) {
				return false;
			}
		}
		return true;
	}
	return function findPrimes() {
		let start = +arguments[0];
		let end = +arguments[1];
		if(start === undefined || end === undefined || isNaN(start) || isNaN(end)){
			throw "Error";
		}
		let nums = [];
		for(let j = start;j<=end;j++){
			nums.push(j);
		}
		let primes = [];
		for (let i = 0; i < nums.length; i++) {
			if (isPrime(nums[i])){
				primes.push(nums[i]);
			}
		}
		return primes;

	}
}

module.exports = solve;
