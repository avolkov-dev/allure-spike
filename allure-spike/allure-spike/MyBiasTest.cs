using Xunit;

namespace allure_spike
{
    public class MyBiasTest
    {
        [Fact]
        public void Run()
        {
            Assert.True("I like K-pop music".GetHashCode() % 2 == 0);
        }
        
    }
}