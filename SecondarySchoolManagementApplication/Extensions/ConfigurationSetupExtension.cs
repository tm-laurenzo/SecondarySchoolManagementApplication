namespace SecondarySchoolManagementApplication.Extensions
{
    public static class ConfigurationSetupExtension
    {
        public static IConfiguration GetConfig(bool isDevelopment)
        {
            string path = @"C:\Users\Chidolue Lawrence\AppData\Roaming\Microsoft\UserSecrets\bac9d45e-fb5a-417b-bb16-676e899579bd";
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
