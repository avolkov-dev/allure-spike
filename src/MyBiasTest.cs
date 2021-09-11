using Dapper;
using Npgsql;
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
        
        
        

        [Fact]
        public void ExecuteSql()
        {
            using var con = new NpgsqlConnection("Server=localhost;Port=26257;Username=root;Database=postgres");
            con.Query("select 1;");
        }
        
    }
}