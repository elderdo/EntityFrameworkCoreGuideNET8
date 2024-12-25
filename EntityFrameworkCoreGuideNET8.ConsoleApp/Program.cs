// See https://aka.ms/new-console-template for more information



using EntityFrameworkCoreGuideNET8.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Entry point of the application.
/// Using Global using directive to 
/// import namespaces in the GlobalUsings.cs
/// </summary>
Console.WriteLine("Hello, from Ziggy Rafiq!");



using (var context = new DemoDbContext(new DbContextOptionsBuilder<DemoDbContext>()
    .UseSqlServer("our_connection_string_here").Options))
{
    // Use context to interact with the database
}

