using Microsoft.EntityFrameworkCore;

// A DbContext instance represents a session with the database and can be used to query and save instances of your entities. DbContext is a combination of the Unit Of Work and Repository patterns.
class TodoDb : DbContext
{
    // Initializes a new instance of the DbContext class using the specified options. The OnConfiguring(DbContextOptionsBuilder) method will still be called to allow further configuration of the options.
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}