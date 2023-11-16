using Unity.Profiling.Editor;

using BestHTTP.Profiler.Network;

namespace BestHTTP.Editor.Profiler.Network
{
    [System.Serializable]
    [ProfilerModuleMetadata(MemoryStats.CategoryName)]
    public sealed class MemoryStatsProfilerModule : ProfilerModule
    {
        static readonly ProfilerCounterDescriptor[] k_Counters =
        {
            new ProfilerCounterDescriptor(MemoryStats.BorrowedName, MemoryStats.Category),
            new ProfilerCounterDescriptor(MemoryStats.PooledName, MemoryStats.Category),
            new ProfilerCounterDescriptor(MemoryStats.ArrayAllocationsName, MemoryStats.Category)
        };

        public MemoryStatsProfilerModule() : base(k_Counters)
        {
        }
    }
}
