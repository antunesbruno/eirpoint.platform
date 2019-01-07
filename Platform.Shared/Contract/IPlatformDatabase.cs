using System;
using System.Collections.Generic;
using System.Text;

namespace Platform.Shared.Contract
{
    public interface IPlatformDatabase
    {      
        /// <summary>
        /// database path
        /// </summary>
        string DatabasePath { get; }
      
        /// <summary>
        /// database name
        /// </summary>
        string DatabaseName { get; }

        /// <summary>
        /// Create database
        /// </summary>
        /// <param name="databaseFolder">The folder that will appear in a mobile device path</param>
        /// <param name="databaseName">Name of database</param>
        void CreateDatabase(string databaseFolder, string databaseName);

        /// <summary>
        /// Create tables by entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void CreateTable<T>() where T : class;     
    }
}
