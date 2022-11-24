using System.Data;
using Models;
using Utils;
using Microsoft.EntityFrameworkCore;

namespace Context
{
    public sealed class PeopleCentralContext : DbContext
    {

        private IDbConnection _connection;
        public IDbConnection Connection
        {
            get
            {
                if (_connection.State == ConnectionState.Open) return _connection;

                _connection.Open();

                while (_connection.State == ConnectionState.Connecting) { }

                return _connection;
            }
            private set => _connection = value;
        }

        public DbSet<UserDBO> Users { get; init; }


        public PeopleCentralContext()
        {

        }

        public PeopleCentralContext(DbContextOptions<PeopleCentralContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ValidateNullArgument();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PeopleCentralContext).Assembly);
        }
    }
}
