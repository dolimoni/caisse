using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Caisse1
{
    public partial class Form1 : Form
    {
        ArticleRepository articleRepository = new ArticleRepository();
        FamilleRepository familleRepository = new FamilleRepository();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CaisseConnectionString"].ConnectionString);
        Form2 form2;
        FamilleFormGlobal familleFormGlobal;
        Article produit;
        Famille famille;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            produit = new Article();
            famille = new Famille();
            SqlDataAdapter articles= new SqlDataAdapter("Select * From dbo.article where id>1", conn);
            DataSet ds = new DataSet("articlesDS");
            DataTable dt = new DataTable();
            //articles.SelectCommand = new SqlCommand(@"SELECT * FROM FooTable", connString);
            articles.Fill(ds, "dbo.article");
            dt = ds.Tables["dbo.article"];
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            }

        private void button1_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.Id = 3;

            try
            {
                conn.Open();
                article = articleRepository.save(article, conn);
                conn.Close();

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.VisibleChanged += new EventHandler(this.form2_VisibleChanged);
            form2.ShowDialog();
        }

        private void form2_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.form2.Visible)
            {
                try
                {
                    this.produit = this.form2.Produit;
                    articleRepository.save(produit, conn);
                }
                catch(Exception ex)
                {
                    CaisseLogger.LogError(ex.ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'caisseDataSet1.article'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.articleTableAdapter.Fill(this.caisseDataSet1.article);
            // TODO: cette ligne de code charge les données dans la table 'caisseDataSet1.test'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.testTableAdapter.Fill(this.caisseDataSet1.article);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            familleFormGlobal = new FamilleFormGlobal(conn);
            familleFormGlobal.VisibleChanged += new EventHandler(this.familleFormGlobal_VisibleChanged);
            familleFormGlobal.ShowDialog();
        }
        private void familleFormGlobal_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.familleFormGlobal.Visible)
            {
                try
                {
                    this.famille = this.familleFormGlobal.Famille;
                    familleRepository.save(this.famille, conn);
                }
                catch (Exception ex)
                {
                    CaisseLogger.LogError(ex.ToString());
                }
            }

        }

        
    }

}
