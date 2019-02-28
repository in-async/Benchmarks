using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Benchmarks {

    public class Program {

        private static void Main(string[] args) {
            var config = ManualConfig.Create(DefaultConfig.Instance)
                //.With(RPlotExporter.Default)
                .With(MarkdownExporter.GitHub)
                .With(MemoryDiagnoser.Default)
                //.With(StatisticColumn.Min)
                //.With(StatisticColumn.Max)
                //.With(RankColumn.Arabic)
                .With(Job.Core)
                //.With(Job.Clr)
                //.With(Job.ShortRun)
                //.With(Job.ShortRun.With(Platform.X64).WithWarmupCount(1).WithIterationCount(1))
                ;

            BenchmarkRunner.Run<GuidSerializeBenchmark>(config);
        }
    }
}
