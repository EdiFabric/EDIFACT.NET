using System.Linq;
using System.Xml.Serialization;

namespace EdiFabric.Framework
{
    /// <summary>
    /// Public helpers.
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// This method pulls out the numeric value from an enum item.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The value from the xml attributes if enum else return the input.</returns>
        public static string GetPropertyValue(object value)
        {
            var result = value as string;
            if (value != null)
            {
                var enumType = value.GetType();
                if (enumType.IsEnum)
                {
                    var member = enumType.GetMember(value.ToString()).FirstOrDefault();
                    if (member == null) return value.ToString();

                    var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
                    if (attribute != null) return attribute.Name;

                    return value.ToString();
                }
            }

            return result;
        }
    }
}
