using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Models
{
    /// <summary>
    /// Middleware between Models and Database.
    /// Establishes connection with database.
    /// Determines the database contents after migration.
    /// </summary>
    public class APIDbContext : DbContext
    {
        /*** Package Manager commands used:
         * Add-Migration "comment here"
         * Update-Database
         */

        //*** C# uses PascalCase whereas the JSON responses will be camelCase


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options">Provider and connection string to use</param>
        public APIDbContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Student Entity mapping
        /// </summary>
        public DbSet<Student> Students { get; set; }
    }
}
