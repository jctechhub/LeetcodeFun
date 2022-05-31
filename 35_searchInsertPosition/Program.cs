// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var intlist = new int[] { 1, 3, 5, 7 };
var target = -1;
var result = SearchInsert1(intlist, target);
Console.WriteLine(result);


/*
 * Runtime: 173 ms, faster than 5.23% of C# online submissions for Search Insert Position.
Memory Usage: 37.5 MB, less than 92.21% of C# online submissions for Search Insert Position.
  */
static int SearchInsert(int[] nums, int target)
{
        if (target < nums[0]) return 0;
    
        for (int i=0; i<nums.Length; i++)
        {
            if (nums[i] == target) return i;        
            else if (i + 1 == nums.Length) return nums.Length;
            else if (nums[i] < target && target < nums[i+1] ) return i+1;        
        }

        return 0;
}


static int SearchInsert1(int[] nums, int target)
{
    int lo = 0, hi = nums.Length;

    while (lo < hi)
    {
        var mid = lo + (hi - lo) / 2;
        if (nums[mid] == target) return mid;
        else if (nums[mid] < target) lo = mid + 1;
        else hi = mid;
    }

    return lo;
}
