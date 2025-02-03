var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PollApp_UI>("pollapp-ui");

builder.AddProject<Projects.PollApp_Server_API>("pollapp-server-api");

builder.Build().Run();
