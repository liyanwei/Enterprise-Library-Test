using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class College
    {
        /// <summary>
        /// CollegeID
        /// </summary>
        public int CollegeID { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public String Name { get; set; }


        public College()
        { 
        }

        public College(int collegeID, string name)
        {
            this.CollegeID = collegeID;
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("CollegeID:{0} Name:{1}", this.CollegeID, this.Name);
        }
    }
}
