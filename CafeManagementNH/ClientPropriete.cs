using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementNH
{
    class ClientPropriete
    {
        private int _idUser;
        private string _UserName;

        public int IdUser
        {
            get
            {
                return _idUser;
            }

            set
            {
                _idUser = value;
            }
        }

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

       public ClientPropriete()
        {

        }
       public ClientPropriete(int iduser,string username)
        {
            IdUser = iduser;
            UserName = username;
        }
    }
}
