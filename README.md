# C# Generics Exercises (with tests)

This repo contains:
- **MyStack<T>** and **MyList<T>** implementations
- **GenericRepository<T>** with `IRepository<T>` and pluggable `IStore<T>` (includes an in-memory store)
- xUnit tests and FluentAssertions
- A small console `Program.cs` demo

## Requirements
- .NET 8 SDK

## Build & Test
```bash
dotnet build
dotnet test
dotnet run --project src/GenericsPlayground
```

## GitHub: create & push
```bash
# 1) unzip, cd into repo root
git init
git add .
git commit -m "Generics: MyStack, MyList, GenericRepository with tests"

# 2) create a GitHub repo first (web UI), then add remote:
git remote add origin https://github.com/<your-username>/csharp-generics-exercises.git
git branch -M main
git push -u origin main
```

## CI (optional)
This repo includes a minimal GitHub Actions workflow that builds & tests on push/PR to `main`.