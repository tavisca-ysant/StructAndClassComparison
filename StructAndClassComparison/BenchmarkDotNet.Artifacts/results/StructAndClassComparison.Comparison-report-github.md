``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742190 Hz, Resolution=364.6720 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
| Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |----------:|----------:|----------:|-------:|------:|------:|----------:|
| Struct | 0.3697 ns | 0.0195 ns | 0.0173 ns |      - |     - |     - |         - |
|  Class | 7.3903 ns | 0.1010 ns | 0.0788 ns | 0.0191 |     - |     - |      40 B |
