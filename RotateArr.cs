public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;
        if (k>0) {
            Math.Abs(k);
        }
        Array.Reverse(nums, 0, n );
        Array.Reverse(nums, 0, k );
        Array.Reverse(nums, k, n - k);
    }
}