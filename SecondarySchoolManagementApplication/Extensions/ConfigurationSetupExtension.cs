namespace SecondarySchoolManagementApplication.Extensions
{
    public static class ConfigurationSetupExtension
    {
        public static IConfiguration GetConfig(bool isDevelopment)
        {
            string path = @"c:\users\chidolue lawrence\AppData\Roaming\Microsoft\UserSecrets\5e1b2274-ba4c-4918-bdc1-d2939a4a540d";
            return isDevelopment ? new ConfigurationBuilder()
                   .SetBasePath(path)
                   .AddJsonFile("secrets.json")
                   .Build()
                :
                new ConfigurationBuilder()
                   .AddEnvironmentVariables()
                   .Build();
        }
    }
}
