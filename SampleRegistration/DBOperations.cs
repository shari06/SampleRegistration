namespace DBRegistration
{
    using RegistrationCommonLibrary.DBInterface;
    using RegistrationCommonLibrary.Models;

    /// <summary>
    /// this class will be maintain to interact with the database
    /// </summary>
    public class DBOperations : IDBOperations
    {
        /// <summary>
        /// In this section we can get data from Database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Configuration GetConfiguration()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// In this section we can insert or update Configuration data in database 
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
