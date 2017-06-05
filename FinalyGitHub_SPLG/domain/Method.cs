using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterSportsСlub.domain {
    class Method
    {
        public int _MethodicIds = new int();
        public string _nameMethods;
        public string _discriptionOfMethods;

        public Method(string methodicId, string nameMethod, string discriptionOfMethod)
        {
            this._MethodicIds = int.Parse(methodicId);
            this._nameMethods = nameMethod;
            this._discriptionOfMethods = discriptionOfMethod;
        }

        
        
    }
}
