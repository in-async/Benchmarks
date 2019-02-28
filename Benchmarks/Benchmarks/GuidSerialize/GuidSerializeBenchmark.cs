using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace Benchmarks {

    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public class GuidSerializeBenchmark {
        private readonly Guid _guid;
        private readonly string _guid_str;
        private readonly string _guid_b64u;

        public GuidSerializeBenchmark() {
            _guid = Guid.NewGuid();
            _guid_str = _guid.ToString();
            _guid_b64u = Base64Url.Encode(_guid.ToByteArray());
        }

        [BenchmarkCategory("Serialize"), Benchmark(Baseline = true)]
        public new string ToString() => _guid.ToString();

        [BenchmarkCategory("Serialize"), Benchmark]
        public string EncodeBase64Url() => Base64Url.Encode(_guid.ToByteArray());

        [BenchmarkCategory("Deserialize"), Benchmark(Baseline = true)]
        public Guid Parse() => Guid.Parse(_guid_str);

        [BenchmarkCategory("Deserialize"), Benchmark]
        public Guid DecodeBase64Url() => new Guid(Base64Url.Decode(_guid_b64u));
    }
}
