public class Solution {
   public int MajorityElement(int[] nums) {
       int count = 0, initialNum = 0;
        foreach (int num in nums) {
            if (count == 0) initialNum  = num;
            count += (num == initialNum ) ? 1 : -1;
        }
        return initialNum ;
    }
}