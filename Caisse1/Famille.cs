using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caisse1
{
    public class Famille
    {
        private int id;
        private String nom;
        List<Article> article;

        public int Id { get => id; set => id = value; }
        public String Nom { get => nom; set => nom = value; }
        public List<Article> Article { get => article; set => article = value; }
    }
}
