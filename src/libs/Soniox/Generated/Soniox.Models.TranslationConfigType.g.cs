
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        OneWay,
        /// <summary>
        /// 
        /// </summary>
        TwoWay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationConfigType value)
        {
            return value switch
            {
                TranslationConfigType.OneWay => "one_way",
                TranslationConfigType.TwoWay => "two_way",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationConfigType? ToEnum(string value)
        {
            return value switch
            {
                "one_way" => TranslationConfigType.OneWay,
                "two_way" => TranslationConfigType.TwoWay,
                _ => null,
            };
        }
    }
}