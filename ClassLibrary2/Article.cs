using System;
using System.Collections.Generic;
using System.Text;

namespace Caisse1
{
    class Article
    {
        private int id;
        private String nom;
        private double prix;
        private int stock;
        private String image;
        private int tva;
        private double prixAchat;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public double Prix { get => prix; set => prix = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Image { get => image; set => image = value; }
        public int Tva { get => tva; set => tva = value; }
        public double PrixAchat { get => prixAchat; set => prixAchat = value; }
    }
}
