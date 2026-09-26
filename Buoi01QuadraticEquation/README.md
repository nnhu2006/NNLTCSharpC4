# Buoi01QuadraticEquation

Thư mục này chứa bản độc lập của bài tập Buoi01:

- `Buoi01Solution.sln`
- `MyLib` (thư viện chứa `LibBaiTap.GiaiPTBac2`)
- `Buoi01Prj` (console app)
- `MyLib.Tests` (xUnit)

## Mở solution

```bash
cd /home/runner/work/NNLTCSharpC4/NNLTCSharpC4/Buoi01QuadraticEquation
dotnet sln Buoi01Solution.sln list
```

## Restore / Build / Test

```bash
dotnet restore Buoi01Solution.sln
dotnet build Buoi01Solution.sln
dotnet test Buoi01Solution.sln
```

## Chạy console app

```bash
dotnet run --project Buoi01Prj/Buoi01Prj.csproj
```
