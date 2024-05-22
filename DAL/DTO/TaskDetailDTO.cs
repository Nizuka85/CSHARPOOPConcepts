using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class TaskDetailDTO
    {
        public int EmployeeID { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public int TackID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TaskSateName { get; set; }
        public DateTime TaskSartDate { get; set; }
        public DateTime TackDeliveryDate { get; set;}
    }
}
