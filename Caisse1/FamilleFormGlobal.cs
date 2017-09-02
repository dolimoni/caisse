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

namespace Caisse1
{
    public partial class FamilleFormGlobal : Form
    {
        Famille famille;

        public Famille Famille { get => famille; set => famille = value; }

        public FamilleFormGlobal(SqlConnection conn)
        {
            InitializeComponent();
            init();
            FillData(conn);
        }

        private void init()
        {
            Famille = new Famille();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String familleName = familleTB.Text;
            this.famille.Nom = familleName;
            this.Hide();
        }

        private void FamilleFormGlobal_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'caisse_famille_DataSet.famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.caisse_famille_DataSet.famille);

        }

        private void FillData(SqlConnection conn)
        {
            try
            {
                conn.Open();
                // use a SqlAdapter to execute the query
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM dbo.famille order by id", conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);

                    // Bind the table to the list box
                    comboBox1.DisplayMember = "nom";

                    comboBox1.DataSource = t;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                CaisseLogger.LogError(ex.ToString());
            }
        }
    }
}
