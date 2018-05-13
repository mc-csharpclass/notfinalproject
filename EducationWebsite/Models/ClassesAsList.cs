using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationWebsite.Models
{
    public class ClassesAsList<T>
    {
        public List<T> classesAsList { get; set; }

        public ClassesAsList(List<T> list)
        {
            classesAsList = list;
        }
    }
}