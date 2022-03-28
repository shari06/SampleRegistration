namespace FileRegistration
{
    using RegistrationCommonLibrary.DBInterface;
    using RegistrationCommonLibrary.Models;
    using System.Reflection;

    /// <summary>
    /// this class will be maintain to interact data in file structure
    /// </summary>
    public class FileOperations : IDBOperations
    {
        /// <summary>
        /// In this section we can get data from file structure
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Configuration GetConfiguration()
        {
            var sysPath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\configfolder\config.json";

            if (File.Exists(sysPath))
            {
                var jsonString = File.ReadAllText($@"{sysPath}");
                var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Configuration>(jsonString);
                return obj;
            }

            return new Configuration();
        }

        /// <summary>
        /// In this section we can insert or update Configuration data in file structure
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool InsertOrUpdate(Configuration configuration)
        {
            var sysPath = $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\configfolder";

            if (!Directory.Exists(sysPath))
            {
                Directory.CreateDirectory(sysPath);
            }
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(configuration);
            File.WriteAllText($@"{sysPath}\config.json", jsonString);
            return true;
        }
    }
}