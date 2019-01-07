using Platform.Shared.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;

namespace Platform.Datasource.Repository
{
    public class PlatformDatabase : IPlatformDatabase, IDisposable
    {      
        #region Fields        

        private string _databaseFolder;

        #endregion

        #region Properties        

        //database path
        public string DatabasePath { get { return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/" + _databaseFolder; } }

        //database name
        public string DatabaseName { get; private set; }

        //sqlite connection
        public SQLiteConnection SQLiteConnection { get; private set; }

        #endregion

        #region Methods        

        /// <summary>
        /// Create database by path
        /// </summary>
        public void CreateDatabase(string databaseFolder, string databaseName)
        {
            _databaseFolder = databaseFolder;
            DatabaseName = databaseName;

            if (!string.IsNullOrEmpty(databaseFolder) && !string.IsNullOrEmpty(databaseName))
            {
                if (!Directory.Exists(DatabasePath))
                    Directory.CreateDirectory(DatabasePath);

                SQLiteConnection = new SQLiteConnection(Path.Combine(DatabasePath + "/" + DatabaseName));
            }
        }

        /// <summary>
        /// Create tables by entity parameter
        /// </summary>
        /// <typeparam name="T">Entity / Table</typeparam>
        public void CreateTable<T>() where T : class
        {
            SQLiteConnection.CreateTable<T>(CreateFlags.None);
        }

        /// <summary>
        /// Dispose database connection
        /// </summary>
        public void Dispose()
        {
            SQLiteConnection.Dispose();
        }

        #endregion
    }
}
