using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Caisse1
{
    class FamilleRepository
    {
        public Famille save(Famille famille, SqlConnection conn)
        {
            try
            {
                SqlCommand myCommand;
                if (famille.Id == 0)
                { 
                    myCommand = new SqlCommand("INSERT INTO dbo.famille(Nom) values(@Nom)", conn);
                }
                else
                {
                    myCommand = new SqlCommand("UPDATE dbo.article set Nom = @Nom where id = @id", conn);
                    myCommand.Parameters.AddWithValue("@id", famille.Id);
                }
                
                myCommand.Parameters.AddWithValue("@Nom", famille.Nom);
                CaisseLogger.LogInfo("Triyng to save artice : " + famille.ToString());
                conn.Open();
                myCommand.ExecuteNonQuery();
                CaisseLogger.LogInfo("Article " + famille.ToString()+" saved.");
                conn.Close();
                return famille;

            }
            catch (Exception ex)
            {
                CaisseLogger.LogError(ex.ToString());
                return famille;
            }
        }
    }
}
