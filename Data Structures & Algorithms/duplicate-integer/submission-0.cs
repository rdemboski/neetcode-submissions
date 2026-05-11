public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {
        Dictionary<int, int> numsDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numsDict.ContainsValue(nums[i]))
            {
                return true;
            }

            numsDict.Add(i, nums[i]);
        }

        return false;
    }
}