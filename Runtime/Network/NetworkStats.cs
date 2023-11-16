using Unity.Profiling;

namespace BestHTTP.Profiler.Network
{
    public sealed class NetworkStats
    {
        public const string CategoryName = "Best HTTP/2 - Network";

        public static readonly ProfilerCategory Category =
#if UNITY_2020
            ProfilerCategory.Scripts;
#elif UNITY_2021_2_OR_NEWER
            new ProfilerCategory(CategoryName, ProfilerCategoryColor.Scripts);
#elif UNITY_2020_2_OR_NEWER
            new ProfilerCategory(CategoryName);
#endif

        public const string SentSinceLastFrameName = "Sent";
        public static readonly ProfilerCounterValue<long> SentSinceLastFrame = new ProfilerCounterValue<long>(Category, SentSinceLastFrameName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string SentTotalName = "Sent Total";
        public static readonly ProfilerCounterValue<long> SentTotal = new ProfilerCounterValue<long>(Category, SentTotalName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string ReceivedSinceLastFrameName = "Received";
        public static readonly ProfilerCounterValue<long> ReceivedSinceLastFrame = new ProfilerCounterValue<long>(Category, ReceivedSinceLastFrameName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string ReceivedTotalName = "Received Total";
        public static readonly ProfilerCounterValue<long> ReceivedTotal = new ProfilerCounterValue<long>(Category, ReceivedTotalName, ProfilerMarkerDataUnit.Bytes, ProfilerCounterOptions.FlushOnEndOfFrame | ProfilerCounterOptions.ResetToZeroOnFlush);

        public const string OpenConnectionsName = "Open Connections";
        public static readonly ProfilerCounterValue<int> OpenConnectionsCounter = new ProfilerCounterValue<int>(Category, OpenConnectionsName, ProfilerMarkerDataUnit.Count, ProfilerCounterOptions.FlushOnEndOfFrame);

        public const string TotalConnectionsName = "Total Connections";
        public static readonly ProfilerCounterValue<int> TotalConnectionsCounter = new ProfilerCounterValue<int>(Category, TotalConnectionsName, ProfilerMarkerDataUnit.Count, ProfilerCounterOptions.FlushOnEndOfFrame);
    }
}
