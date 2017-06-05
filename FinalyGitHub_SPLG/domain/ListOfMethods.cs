using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemesterSportsСlub.Infrastructure;

namespace SemesterSportsСlub.domain {
    class ListOfMethods {
        public List<Method> listOfMethods;

        public ListOfMethods() {
            listOfMethods = new DataBaseConnectionMethdos().AddMethods();
        }
    }
}
