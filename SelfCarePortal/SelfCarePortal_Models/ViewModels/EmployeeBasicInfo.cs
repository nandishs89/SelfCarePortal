using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCarePortal_Models.ViewModels
{
    public class EmployeeBasicInfo
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Gender { get; set; }
        public string Designation { get; set; }
        public bool IsActive { get; set; }

    }

}
