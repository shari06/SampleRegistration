namespace RegistrationCommonLibrary.Models
{
    /// <summary>
    /// Filed Information
    /// </summary>
    public class ConflgValues
    {
        /// <summary>
        /// Field name {"FieldName":"ddd","FieldType":"Text","FieldInfo":"ddd"}
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Data type of the field
        /// </summary>
        public string FieldType { get; set; }

        /// <summary>
        /// Some user data for example we can store key value pair values
        /// </summary>
        public string FieldInfo { get; set; }


    }
}
