``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 8.1 (6.3.9600.0), VM=Hyper-V
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.6.1055.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.6.1055.0


```
|                                     Method |        Mean |       Error |      StdDev |      Median |         Min |         Max |  Gen 0 | Allocated |
|------------------------------------------- |------------:|------------:|------------:|------------:|------------:|------------:|-------:|----------:|
|                            ChangeType_bool | 3,059.07 ns |  60.9176 ns | 108.2810 ns | 3,060.74 ns | 2,781.13 ns | 3,293.36 ns | 0.0877 |     384 B |
|                 ChangeType_bool_FromString | 3,186.46 ns |  63.1000 ns |  90.4962 ns | 3,185.57 ns | 3,027.91 ns | 3,347.07 ns | 0.0877 |     372 B |
|                        ChangeType_DateTime | 3,037.88 ns |  78.5326 ns |  80.6472 ns | 3,005.74 ns | 2,962.81 ns | 3,263.22 ns | 0.0916 |     396 B |
|             ChangeType_DateTime_FromString | 4,986.79 ns |  98.8948 ns | 128.5912 ns | 4,986.62 ns | 4,763.51 ns | 5,246.43 ns | 0.0916 |     396 B |
|                         ChangeType_Decimal | 3,174.77 ns |  48.9829 ns |  45.8187 ns | 3,179.64 ns | 3,097.72 ns | 3,232.37 ns | 0.0992 |     420 B |
|              ChangeType_Decimal_FromString | 3,704.28 ns |  73.9270 ns | 177.1243 ns | 3,648.47 ns | 3,319.60 ns | 4,185.29 ns | 0.0916 |     396 B |
|                            ChangeType_Guid | 3,278.34 ns | 107.1722 ns | 300.5225 ns | 3,181.36 ns | 2,910.93 ns | 4,204.57 ns | 0.0916 |     396 B |
|                 ChangeType_Guid_FromString | 3,900.81 ns |  77.4890 ns | 143.6309 ns | 3,907.45 ns | 3,691.22 ns | 4,300.70 ns | 0.0916 |     396 B |
|                           ChangeType_Int16 | 3,006.10 ns |  59.7043 ns |  89.3625 ns | 3,025.92 ns | 2,816.74 ns | 3,185.67 ns | 0.0877 |     384 B |
|                ChangeType_Int16_FromString | 3,572.55 ns |  68.3010 ns |  73.0813 ns | 3,560.41 ns | 3,430.84 ns | 3,738.24 ns | 0.0916 |     384 B |
|                           ChangeType_Int32 | 3,050.91 ns |  57.0970 ns |  50.6150 ns | 3,041.55 ns | 2,970.87 ns | 3,156.81 ns | 0.0877 |     384 B |
|                ChangeType_Int32_FromString | 3,773.75 ns |  73.8464 ns | 136.8790 ns | 3,728.88 ns | 3,569.84 ns | 4,071.95 ns | 0.0916 |     384 B |
|                           ChangeType_Int64 | 3,082.11 ns |  61.4605 ns | 134.9072 ns | 3,077.98 ns | 2,810.27 ns | 3,380.61 ns | 0.0916 |     396 B |
|                ChangeType_Int64_FromString | 3,878.21 ns |  77.5600 ns | 135.8401 ns | 3,884.93 ns | 3,542.29 ns | 4,161.63 ns | 0.0916 |     396 B |
|                    ChangeType_NullableLong | 4,223.80 ns |  83.5928 ns | 208.1752 ns | 4,193.81 ns | 3,861.23 ns | 4,774.45 ns | 0.0992 |     436 B |
|         ChangeType_NullableLong_FromString | 4,516.76 ns |  89.6282 ns | 159.3139 ns | 4,504.83 ns | 4,272.88 ns | 4,874.25 ns | 0.0992 |     420 B |
|                          ChangeType_String | 3,749.92 ns | 129.3825 ns | 369.1356 ns | 3,637.84 ns | 3,060.46 ns | 4,703.36 ns | 0.0877 |     368 B |
|                    ChangeTypeWithType_bool |    23.23 ns |   0.5515 ns |   0.7548 ns |    23.15 ns |    22.02 ns |    24.82 ns | 0.0028 |      12 B |
|         ChangeTypeWithType_bool_FromString |    89.11 ns |   1.7855 ns |   2.9831 ns |    88.81 ns |    84.66 ns |    97.40 ns | 0.0027 |      12 B |
|                ChangeTypeWithType_DateTime |    23.77 ns |   0.5509 ns |   0.5411 ns |    23.67 ns |    22.81 ns |    24.82 ns | 0.0038 |      16 B |
|     ChangeTypeWithType_DateTime_FromString | 1,523.55 ns |  30.9778 ns |  88.8810 ns | 1,507.40 ns | 1,396.35 ns | 1,789.22 ns | 0.0019 |      16 B |
|                 ChangeTypeWithType_Decimal |    26.96 ns |   0.6572 ns |   1.6367 ns |    26.93 ns |    24.30 ns |    31.67 ns | 0.0057 |      24 B |
|      ChangeTypeWithType_Decimal_FromString |   670.66 ns |  16.8857 ns |  48.9884 ns |   663.45 ns |   594.10 ns |   810.77 ns | 0.0048 |      24 B |
|                    ChangeTypeWithType_Guid |    27.26 ns |   0.6345 ns |   1.8000 ns |    26.94 ns |    24.57 ns |    32.15 ns | 0.0057 |      24 B |
|         ChangeTypeWithType_Guid_FromString |   648.86 ns |  21.0701 ns |  60.4541 ns |   635.67 ns |   542.91 ns |   822.01 ns | 0.0048 |      24 B |
|                   ChangeTypeWithType_Int16 |    23.47 ns |   0.6473 ns |   1.0267 ns |    23.46 ns |    22.14 ns |    27.24 ns | 0.0028 |      12 B |
|        ChangeTypeWithType_Int16_FromString |   283.69 ns |   5.2426 ns |   4.9039 ns |   283.65 ns |   275.04 ns |   292.51 ns | 0.0024 |      12 B |
|                   ChangeTypeWithType_Int32 |    22.95 ns |   0.5670 ns |   0.7170 ns |    22.72 ns |    22.24 ns |    24.66 ns | 0.0028 |      12 B |
|        ChangeTypeWithType_Int32_FromString |   337.67 ns |   5.1814 ns |   4.8467 ns |   338.77 ns |   329.48 ns |   343.73 ns | 0.0024 |      12 B |
|                   ChangeTypeWithType_Int64 |    22.49 ns |   0.5423 ns |   0.8116 ns |    22.51 ns |    21.33 ns |    24.34 ns | 0.0038 |      16 B |
|        ChangeTypeWithType_Int64_FromString |   537.22 ns |  13.4202 ns |  36.5108 ns |   526.97 ns |   493.76 ns |   650.54 ns | 0.0029 |      16 B |
|            ChangeTypeWithType_NullableLong |   522.91 ns |  10.3023 ns |  10.1182 ns |   523.77 ns |   502.52 ns |   539.73 ns | 0.0105 |      48 B |
| ChangeTypeWithType_NullableLong_FromString |   835.34 ns |  16.7349 ns |  28.4171 ns |   829.58 ns |   789.13 ns |   905.06 ns | 0.0067 |      32 B |
|                  ChangeTypeWithType_String |    17.90 ns |   0.4400 ns |   0.4891 ns |    17.72 ns |    17.18 ns |    18.86 ns |      - |       0 B |
