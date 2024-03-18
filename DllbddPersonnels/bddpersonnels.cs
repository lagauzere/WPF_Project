using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BddpersonnelContext;

namespace DllbddPersonnels
{
    public class bddpersonnels
    {
        public static Boolean Gestionnaire { get; set; }
        private BddpersonnelDataContext bdd;
        private Boolean connexionStatus = false;

        public bddpersonnels(string username, string password, string ipadress, string port)
        {
            Bdd = new BddpersonnelDataContext("User Id=" + username + ";Password=" + password + ";Host=" + ipadress + ";Port=" + port + ";Database=bddpersonnels;Persist Security Info=True");
            try
            {
                Bdd.Connection.Open();
              
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ConnexionStatus = true;
        }

        public BddpersonnelDataContext Bdd { get => bdd; set => bdd = value; }
        public bool ConnexionStatus { get => connexionStatus; set => connexionStatus = value; }


        public Boolean ConnexionGestionnaire(string login, string mdp)
        {

            return false;
        }

        public List<Service> fetchallservice()
        {
            return bdd.Services.ToList();
        }

        public List<Personnel> fetchallpersonnels()
        {
            return bdd.Personnels.ToList();
        }

        public List<Fonction> fetchallfonction()
        {
            return bdd.Fonctions.ToList();
        }



    

    }

  

}
