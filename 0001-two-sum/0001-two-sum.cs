public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] array = {0,0};
        for(int i = 0; i < nums.Length; i++)
        {
            for(int x = i + 1; x < nums.Length; x++)
                {
                    if(nums[x] == target - nums[i])
                    {
                        array[0] = x;
                            array[1] = i;
                    }
                }
        }
        return array;
    }
}