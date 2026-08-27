
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public enum UsageLogsSort
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
    public static class UsageLogsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLogsSort value)
        {
            return value switch
            {
                UsageLogsSort.EndTimeAsc => "end_time_asc",
                UsageLogsSort.EndTimeDesc => "end_time_desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLogsSort? ToEnum(string value)
        {
            return value switch
            {
                "end_time_asc" => UsageLogsSort.EndTimeAsc,
                "end_time_desc" => UsageLogsSort.EndTimeDesc,
                _ => null,
            };
        }
    }
}