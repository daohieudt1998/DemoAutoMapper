using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public class ClassStudent
    {
        public int id { get; set; }
        public string className { get; set; }

        public virtual Student student { get; set; }
    }
}
