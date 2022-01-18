using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPWebApp.models
{
    //variable? (each variable needs a setter and a getter
    public class gradecalcmodel
    {
        [Range(0,100)]
        public float Assignments { get; set; }
        [Range(0, 100)]
        public float GroupProject { get; set; }
        [Range(0, 100)]
        public float Quizzes { get; set; }
        [Range(0, 100)]
        public float Test { get; set; }
        [Range(0, 100)]
        public float Intex { get; set; }
        // the {get; set;} is doing what the following lines would do

        //setter
        //public void setAssignments( float input)
        //{
          //  this.Assignments = input;
        //}

        //getter
        //public float getAssignments()
       // {
        //    return this.Assignments;
       // }
    }
}
