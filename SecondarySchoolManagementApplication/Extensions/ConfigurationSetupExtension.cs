namespace SecondarySchoolManagementApplication.Extensions
{
    public static class ConfigurationSetupExtension
    {
        public static IConfiguration GetConfig(bool isDevelopment)
        {
            return isDevelopment ? IConfiguration
                :
                new ConfigurationBuilder()
                   .AddEnvironmentVariables()
                   .Build();
        }
    }
}
