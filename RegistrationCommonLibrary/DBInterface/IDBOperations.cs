namespace RegistrationCommonLibrary.DBInterface
{
    using RegistrationCommonLibrary.Models;

    public interface IDBOperations
    {
        /// <summary>
        /// Insert or Upate Configuration
        /// </summary>
        /// <param name="configuration">Configuration Object</param>
        /// <returns>boolean Value (0 (failure) 0r 1(Success))</returns>
        bool InsertOrUpdate(Configuration configuration);

        /// <summary>
        /// Get Configuration
        /// </summary>
        /// <returns>Configuration</returns>
        Configuration GetConfiguration();

    }
}
