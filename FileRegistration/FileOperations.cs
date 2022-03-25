namespace FileRegistration
{
    using RegistrationCommonLibrary.DBInterface;
    using RegistrationCommonLibrary.Models;

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
            throw new NotImplementedException();
        }

        /// <summary>
        /// In this section we can insert or update Configuration data in file structure
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool InsertOrUpdate(Configuration configuration)
        {
            throw new NotImplementedException();
        }
    }
}