namespace DemoDotnetCore3.Data
{
    public interface IDbConfig
    {
        string ConnectionString { get; set; }
        string DbName { get; set; }
        string Command { get; set; }
    }
}