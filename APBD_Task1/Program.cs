namespace APBD_Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public static int CalculateAvg(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum / nums.Length;
        }
        
        public static int CalculateMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            return max;
        }

        public static int CalculateMin(int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > min)
                    min = nums[i];
            }

            return min;
        }
    }
}