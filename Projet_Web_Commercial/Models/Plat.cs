using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Web_Commercial
{
    public class Plat
    {

        private String nom;
        private float prix;
        private float poid;

        public Plat(float prix, String nom, float poid)
        {
            this.nom = nom;
            this.prix = prix;
            this.poid = poid;
        }

        public String Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Le nom du plat est trop court");
                }
                nom = value;
            }
        }

        public float Prix
        {
            get
            {
                return this.prix;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Un prix ne peut pas être négatif");
                }
                prix = value;
            }
        }

        public float Poid
        {
            get
            {
                return this.poid;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Un poid ne peut être négatif");
                }
                poid = value;
            }
        }
    }
}
