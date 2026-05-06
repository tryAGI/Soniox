
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetUsageLogsSort2
    {
        /// <summary>
        /// 
        /// </summary>
        EndTimeAsc,
        /// <summary>
        /// 
        /// </summary>
        EndTimeDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsageLogsSort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageLogsSort2 value)
        {
            return value switch
            {
                GetUsageLogsSort2.EndTimeAsc => "end_time_asc",
                GetUsageLogsSort2.EndTimeDesc => "end_time_desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageLogsSort2? ToEnum(string value)
        {
            return value switch
            {
                "end_time_asc" => GetUsageLogsSort2.EndTimeAsc,
                "end_time_desc" => GetUsageLogsSort2.EndTimeDesc,
                _ => null,
            };
        }
    }
}