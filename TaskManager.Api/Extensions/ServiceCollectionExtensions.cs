using System;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Facades;
using TaskManager.Services;

namespace TaskManager.Api.Extensions;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddTaskManagerServices(this IServiceCollection services)
  {
    
      // Registra os serviços
      // services.AddScoped<ITaskService, TaskService>();
      
      // Registra os facades
      // services.AddScoped<ITaskFacade, TaskFacade>();

      // Outras injeções
      //services.AddHttpClient(); // Exemplo de configuração de cliente HTTP

      return services;
  }
}
