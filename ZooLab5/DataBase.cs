using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZooLab5
{
    class DataBase
    {
        /// <summary>
        /// Рядок підключення бази даних
        /// </summary>
        SqlConnection sqlConnection = new SqlConnection(@"Server=tcp:testsqldb12.database.windows.net,1433;Initial Catalog=ZOOLAB;Persist Security Info=False;User ID=db12;Password=12321SdV;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        /// <summary>
        /// Відкрити базу даних
        /// </summary>
        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        /// <summary>
        /// Закрити базу даних
        /// </summary>
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Зв'язок з базой даних
        /// </summary>
        /// <returns></returns>
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
