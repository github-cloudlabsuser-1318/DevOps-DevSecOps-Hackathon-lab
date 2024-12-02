DependencyInjection.ConfigureApp();
AddApplicationInsightsTelemetry();

// This method gets called by the runtime. Use this method to add services to the container.
var builder = WebApplication.CreateBuilder(args);

// The following line enables Application Insights telemetry collection.
builder.Services.AddApplicationInsightsTelemetry();

// This code adds other services for your application.
builder.Services.AddMvc();

var app = builder.Build();