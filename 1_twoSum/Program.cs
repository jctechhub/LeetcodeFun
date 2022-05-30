// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nums =new  int[]{4,2,6,9,3,5,6};
var target = 15;
var result = Solution1(nums, target);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);

static int[] Solution1(int[] nums, int target)
{
    for(int i=0; i<nums.Length; i++)
    {
        for(int j=i+1; j<nums.Length; j++)
        {
            if (nums[i] == target - nums[j])
            {
                return new int[] { i, j };
            }
        }
    }
    return null;


}