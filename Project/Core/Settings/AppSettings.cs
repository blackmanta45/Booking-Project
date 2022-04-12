namespace Core.Settings
{
    public sealed class AppSettings
    {
        public string Secret { get; set; }
        public string DbConnectionString { get; set; }
        public string MigrationAssembly { get; set; }
    }
}