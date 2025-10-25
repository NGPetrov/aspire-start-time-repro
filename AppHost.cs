var builder = DistributedApplication.CreateBuilder(args);

builder.AddExecutable("date", "date", ".").WithExplicitStart();
builder.AddContainer("working-regardless-of-nuget-version", "fedora", "latest").WithExplicitStart();

builder.Build().Run();
