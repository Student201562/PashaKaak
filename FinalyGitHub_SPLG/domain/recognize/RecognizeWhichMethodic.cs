using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SemesterSportsСlub.domain.recognize {
    class RecognizeWhichMethodic {
        private readonly int _idOfMethod;

        public string NameMethod { get; set; }

        public string DescriptionOfMethod { get; set; }

        public RecognizeWhichMethodic(int idOfMethod) {
            _idOfMethod = idOfMethod;
            SearchDescription();
        }

        public void SearchDescription() {
            ListOfMethods listOfMethods = new ListOfMethods();

            foreach (var e in listOfMethods.listOfMethods) {
                if (e._MethodicIds == _idOfMethod) {
                    DescriptionOfMethod = e._discriptionOfMethods;
                    NameMethod = e._nameMethods;
                }
            }
        }
    }
}
