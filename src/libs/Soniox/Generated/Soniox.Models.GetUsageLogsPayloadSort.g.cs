
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetUsageLogsPayloadSort
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
    public static class GetUsageLogsPayloadSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageLogsPayloadSort value)
        {
            return value switch
            {
                GetUsageLogsPayloadSort.EndTimeAsc => "end_time_asc",
                GetUsageLogsPayloadSort.EndTimeDesc => "end_time_desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageLogsPayloadSort? ToEnum(string value)
        {
            return value switch
            {
                "end_time_asc" => GetUsageLogsPayloadSort.EndTimeAsc,
                "end_time_desc" => GetUsageLogsPayloadSort.EndTimeDesc,
                _ => null,
            };
        }
    }
}