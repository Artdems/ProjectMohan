using ProjectMohan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMohan.BD
{
    public class DAL
    {

        public DatabaseContexte db = new DatabaseContexte();

        public List<Nouvelle> GetNouvelles()
        {
            return db.Nouvelles.ToList();
        }

        public Nouvelle GetNouvelle( int ID)
        {
            return db.Nouvelles.Where(b => b.ID.Equals(ID)).First();
        }

        public void AjouterNouvelle(string Titre, string Text)
        {
            Nouvelle nouvelle = new Nouvelle();
            nouvelle.Titre = Titre;
            nouvelle.Text = Text;

            db.Add(nouvelle);
            db.SaveChanges();
        }

        public void SupprimerNouvelle(int ID)
        {
            Nouvelle nouvelle = db.Nouvelles.Where(b => b.ID.Equals(ID)).First();

            db.Remove(nouvelle);
            db.SaveChanges();
        }
    }
}
