public class Solution {
    public int[] PlusOne(int[] digits) {
             string number = "";

        // Convert array to a string
        foreach (int digit in digits) {
            number += digit.ToString();
        }

        // Convert to BigInteger to avoid overflow, then add 1
        BigInteger num = BigInteger.Parse(number) + 1;
        int num = int.Parse(number) + 1;
        string newNumber = num.ToString();

        // Convert string back to an integer array
        int[] result = new int[newNumber.Length];
        for (int i = 0; i < newNumber.Length; i++) {
            result[i] = newNumber[i] - '0';
        }

        return result;

        //   //another one only by adding 1 o the last digits of i

        //      // loop through the array from the end
        //       for (int i=digits.Length -1 ; i>=0 ; i--){
        //             if (digits[i] < 9 ){
        //                 digits[i]++;
        //                 return digits;
        //             }
        //      // if the digit is 9, then we need to set it to 0 and continue to the next digit
        //         digits[i]=0; 
        //         }
        //     // if we reach here, then all the digits are 9, so we need to add 1 to the beginning of the array
        //         int[] result = new int[digits.Length + 1];
        //         result[0] = 1;
        //         return result;
}
}
       

