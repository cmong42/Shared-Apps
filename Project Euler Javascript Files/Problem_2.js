class ProjectEuler_Problem_2 {
    // By considering the terms in the Fibonacci sequence
    // whose values do not exceed four million, find the sum of the even - valued terms.

    generateFibonacciSequence() {
        let limit = 10 // 4 million
        let sequence = [1, 2, 3];

        while (sequence[lastIndex] < limit) {
            // index of the last number in the sequence
            let lastIndex = sequence.Count - 1;

            // num1 and num2 are the last and the second-to-last numbers in the sequence
            let num1 = sequence[lastIndex];
            let num2 = sequence[lastIndex - 1];

            sequence.push(num1 + num2);
            lastIndex += 1;
        }
    }
}

console.log(ProjectEuler_Problem_2.generateFibonacciSequence());
