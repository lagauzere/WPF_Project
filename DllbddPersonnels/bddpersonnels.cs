using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;

namespace DllbddPersonnels
{
    public class bddpersonnels
    {

        private BddpersonnelDataContext bdd;

        public bddpersonnels(string username, string password, string ipadress, string port)
        {
            bdd = new BddpersonnelDataContext("User Id=" + username + ";Password=" + password + ";Host=" + ipadress + ";Port=" + port + ";Database=bddpersonnels;Persist Security Info=True");
        }

        public static void InsertPeople(string newpeople)
        {
            Personnel perso = new Personnel();

        }




    }
}
