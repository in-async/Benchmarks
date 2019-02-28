``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 10.0.14393.2214 (1607/AnniversaryUpdate/Redstone1)
Intel Core i5-6200U CPU 2.30GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2343756 Hz, Resolution=426.6656 ns, Timer=TSC
.NET Core SDK=2.2.101
  [Host] : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT
  Core   : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|          Method |  Categories |      Mean |     Error |     StdDev |    Median | Ratio | RatioSD | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|---------------- |------------ |----------:|----------:|-----------:|----------:|------:|--------:|------------:|------------:|------------:|--------------------:|
|        ToString |   Serialize |  76.21 ns | 0.6528 ns |  0.5787 ns |  76.27 ns |  1.00 |    0.00 |      0.0660 |           - |           - |               104 B |
| EncodeBase64Url |   Serialize | 191.09 ns | 6.9990 ns | 20.1937 ns | 185.61 ns |  2.39 |    0.16 |      0.1676 |           - |           - |               264 B |
|                 |             |           |           |            |           |       |         |             |             |             |                     |
|           Parse | Deserialize | 326.51 ns | 8.4219 ns | 23.6160 ns | 314.12 ns |  1.00 |    0.00 |           - |           - |           - |                   - |
| DecodeBase64Url | Deserialize | 235.22 ns | 6.6454 ns | 19.1736 ns | 228.95 ns |  0.72 |    0.06 |      0.0963 |           - |           - |               152 B |
