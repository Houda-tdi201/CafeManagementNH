using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementNH
{
    class CatPropriete
    {
        private int _idCat;
        private string _catName;

        public int IdCat
        {
            get
            {
                return _idCat;
            }

            set
            {
                _idCat = value;
            }
        }

        public string CatName
        {
            get
            {
                return _catName;
            }

            set
            {
                _catName = value;
            }
        }

       public CatPropriete()
        {

        }
       public CatPropriete(int Id_Cat,string Cat_Name)
        {
            IdCat = Id_Cat;
            CatName = Cat_Name;
        }
    }
}
