namespace Action_Func_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Func<int, int, int> sumFunc = (a, b) => a + b; int result = sumFunc(3, 4); // result = 7

            Action<int, int> ActionCalculator = (a, b) =>
            {
                Console.WriteLine($"Addition result: {a + b}");
                Console.WriteLine($"Subtraction result: {a - b}");
                Console.WriteLine($"Multiplication result: {a * b}");
                Console.WriteLine($"Division result: {a / b}");
            };

            ActionCalculator(9, 3);

            Console.ReadLine();
        }
    }
}