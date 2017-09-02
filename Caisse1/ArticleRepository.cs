using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caisse1
{
    class ArticleRepository
    {

        public Article getById(Article article, SqlConnection conn)
        {
         
             SqlDataReader myReader = null;
             SqlCommand myCommand = new SqlCommand("select * from dbo.article where id = @id",
                                                         conn);

            myCommand.Parameters.AddWithValue("@id", article.Id);

            myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                article.Nom = myReader["Nom"].ToString();
                article.Prix = (double)myReader["Prix"];
            }
            return article;
        }

        public Article save(Article article, SqlConnection conn)
        {
            try
            {
                SqlCommand myCommand;
                if (article.Id == 0)
                {
                    myCommand = new SqlCommand("INSERT INTO dbo.article(Nom,Prix,Stock,Image,TVA,PrixAchat) values(@Nom,@Prix,@Stock,@Image,@TVA,@PrixAchat)", conn);
                }
                else
                {
                    myCommand = new SqlCommand("UPDATE dbo.article set Nom = @Nom, Prix = @Prix, Stock = @Stock, Image = @Image, TVA = @TVA, PrixAchat = @PrixAchat where id=@id", conn);
                }
                myCommand.Parameters.AddWithValue("@id", article.Id);
                myCommand.Parameters.AddWithValue("@Nom", article.Nom);
                myCommand.Parameters.AddWithValue("@Prix", article.Prix);
                myCommand.Parameters.AddWithValue("@Stock", article.Stock);
                myCommand.Parameters.AddWithValue("@Image", article.Image);
                myCommand.Parameters.AddWithValue("@TVA", article.Tva);
                myCommand.Parameters.AddWithValue("@PrixAchat", article.PrixAchat);
                CaisseLogger.LogInfo("Triyng to save artice : "+article.ToString());
                conn.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
                return article;

            }
            catch (Exception ex)
            {
                CaisseLogger.LogError(ex.ToString());
                return article;
            }            
        }

       
    }
    
}
