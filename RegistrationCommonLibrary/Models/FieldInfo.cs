namespace RegistrationCommonLibrary.Models
{
    /// <summary>
    /// Filed Information
    /// </summary>
    public class FieldInfo
    {
        /// <summary>
        /// Field name
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Data type of the field
        /// </summary>
        public string FieldType { get; set; }

        /// <summary>
        /// Some user data for example we can store key value pair values
        /// </summary>
        public string UserData { get; set; }


    }
}
