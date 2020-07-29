namespace DemoDotnetCore3.Data
{
    public class DbConfig : IDbConfig
    {
        public string ConnectionString { get; set; }
        public string DbName { get; set; }
        public string Command { get; set; }
    }
}