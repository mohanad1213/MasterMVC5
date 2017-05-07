using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterConsole.ServiceLayer
{
    class Grade
    {


        List<float> grades;
        public void Add(float grade)
        {
            grades.Add(grade);
        }
    }
}
