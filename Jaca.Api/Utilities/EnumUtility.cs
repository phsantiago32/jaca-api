using Jaca.Api.Utilities.Interfaces;
using System;
using System.Reflection;

namespace Jaca.Api.Utilities
{
    public class EnumUtility : IEnumUtility
    {
        public T Convert<T>(object enumToConvert)
        {
            if (enumToConvert == null)
                return default(T);

            if (!typeof(T).GetTypeInfo().IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type.");
            }

            T convertedEnum = default(T);

            try
            {
                convertedEnum = (T)Enum.Parse(typeof(T), enumToConvert.ToString(), true);
            }
            catch (Exception) { }

            return convertedEnum;
        }
    }
}
