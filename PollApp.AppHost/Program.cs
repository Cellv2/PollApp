var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PollApp_UI>("pollapp-ui");

builder.Build().Run();
