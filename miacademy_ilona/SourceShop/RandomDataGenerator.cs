namespace BrowserTests.Utilities
{
    public static class RandomDataGenerator
    {
        private static readonly List<string> FirstNames = new List<string> { "John", "Jane", "Alex", "Emily", "Michael", "Sarah", "David", "Laura" };
        private static readonly List<string> LastNames = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };

        public static string GenerateRandomPhoneNumber(Random random)
        {
            int areaCode = random.Next(100, 1000);
            int exchangeCode = random.Next(100, 1000);
            int subscriberNumber = random.Next(1000, 10000);
            return $"({areaCode}) {exchangeCode}-{subscriberNumber}";
        }

        public static string GenerateRandomFirstName(Random random)
        {
            return FirstNames[random.Next(FirstNames.Count)];
        }

        public static string GenerateRandomLastName(Random random)
        {
            return LastNames[random.Next(LastNames.Count)];
        }
    }
}
