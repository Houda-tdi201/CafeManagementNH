using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementNH
{
     class CApropriete
    {
        private int _iduser;
        private string _username;

        public int Iduser
        {
            get
            {
                return _iduser;
            }

            set
            {
                _iduser = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public CApropriete()
        {

        }
        public CApropriete(int idUser,string username)
        {
            Iduser = idUser ;
            Username = username;
        }
    }
}
