using Unity.Profiling.Editor;

using BestHTTP.Profiler.Network;

namespace BestHTTP.Editor.Profiler.Network
{
    [System.Serializable]
    [ProfilerModuleMetadata(NetworkStats.CategoryName)]
    public sealed class NetworkStatsProfilerModule : ProfilerModule
    {
        static readonly ProfilerCounterDescriptor[] k_Counters =
        {
            new ProfilerCounterDescriptor(NetworkStats.SentSinceLastFrameName, NetworkStats.Category),
            new ProfilerCounterDescriptor(NetworkStats.SentTotalName, NetworkStats.Category),
            new ProfilerCounterDescriptor(NetworkStats.ReceivedSinceLastFrameName, NetworkStats.Category),
            new ProfilerCounterDescriptor(NetworkStats.ReceivedTotalName, NetworkStats.Category),
            new ProfilerCounterDescriptor(NetworkStats.OpenConnectionsName, NetworkStats.Category),
            new ProfilerCounterDescriptor(NetworkStats.TotalConnectionsName, NetworkStats.Category),
        };

        public NetworkStatsProfilerModule() : base(k_Counters)
        {
        }
    }
}
