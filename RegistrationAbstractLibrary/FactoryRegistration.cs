namespace RegistrationAbstractLibrary
{
    using DBRegistration;
    using FileRegistration;
    using RegistrationCommonLibrary.DBInterface;

    /// <summary>
    /// Factory Registration
    /// </summary>
    public class FactoryRegistration
    {
        /// <summary>
        /// Object initiation based on the storage type
        /// </summary>
        /// <param name="storageType">storage type File or DB</param>
        /// <returns></returns>
        public static IDBOperations Repository(string storageType)
        {
            IDBOperations dBRepository = null;
            if (storageType == "1")
            {
                dBRepository = new FileOperations();
            }
            else if (storageType == "2")
            {
                dBRepository = new DBOperations();
            }
            else if (storageType == "3")
            {
                // We can extend further with more options
            }
            return dBRepository;
        }
    }
}
