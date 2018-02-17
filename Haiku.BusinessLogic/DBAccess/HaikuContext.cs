using System.Data.Entity;

using Haiku.BusinessLogic.Data;

namespace Haiku.BusinessLogic.DBAccess
{
    /// <summary>
    /// haiku database context
    /// </summary>
    public class HaikuContext : DbContext
    {
        private static string connectionString = "Server=tcp:haikuserver.database.windows.net,1433;Initial Catalog=haikuDb;Persist Security Info=False;User ID=haikuadmin;Password=Debilina123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //private static string connectionString = "Data Source=MITCHIE\\SQLEXPRESS;Initial Catalog=Haiku;Persist Security Info=True;Integrated Security=True;Connection Timeout=30;";

        /// <summary>
        /// Initializes a new instance of the <see cref="HaikuContext"/> class.
        /// </summary>
        public HaikuContext() : base(connectionString)
        { }

        /// <summary>
        /// Gets or sets the haikus - represents the entity to query and save
        /// </summary>
        /// <value>
        /// The haikus.
        /// </value>
        public DbSet<HaikuPoem> Haikus { get; set; }

        /// <summary>
        /// Gets or sets the models - represents the entity to query and save
        /// </summary>
        /// <value>
        /// The models.
        /// </value>
        public DbSet<HaikuDBModel> Models { get; set; }

        /// <summary>
        /// Gets or sets the words - represents the entity to query and save
        /// </summary>
        /// <value>
        /// The words.
        /// </value>
        public DbSet<HaikuDBWord> Words { get; set; }
    }
}
