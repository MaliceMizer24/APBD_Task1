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
    }
}