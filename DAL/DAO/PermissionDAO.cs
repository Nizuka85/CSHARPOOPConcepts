using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PermissionDAO : EmployeeContext
    {
        public static void AddPermission(PERMISSION permission)
        {
			try
			{
				db.PERMISSION.InsertOnSubmit(permission);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public static List<PermissionDetailDTO> GetPermission()
        {
            List<PermissionDetailDTO> permissions = new List<PermissionDetailDTO>();

            var list  = (from p in db.PERMISSION
                         join s in db.PERMISSIONSTATE on p.PermissionState equals s.ID
                         join e in db.EMPLOYEE on p.EmployeeID equals e.ID
                         select new
                         {
                             UserNo=e.UserNo,
                             name=e.Name,
                             Surname=e.SurName,
                             statename=s.StateName,
                             stateID=p.PermissionState,
                             startdate=p.PermissionStarDate,
                             enddate=p.PermissionEndDate,
                             employeeID=p.EmployeeID,
                             PermissionID=p.ID,
                             explanation=p.PermissionExplanation,
                             dayamount=p.PermissionDay,
                             DepartmentID=e.DepartmentID,
                             positionID=e.PositionID,

                         }).OrderBy(x => x.startdate).ToList();
            foreach (var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();
                dto.UserNo = item.UserNo;
                dto.Name = item.name;
                dto.SurName = item.Surname;
                dto.EmployeeID = item.employeeID;
                dto.PermissionDayAmout =item.dayamount;
                dto.StarDate=item.startdate;
                dto.EndDate=item.enddate;
                dto.DepartmentID=item.DepartmentID;
                dto.PositionID=item.positionID;
                dto.State=item.stateID;
                dto.StateName = item.statename;
                dto.Explanation = item.explanation;
                dto.PermissionID= item.PermissionID;
                permissions.Add(dto);

            }
            return permissions;
        }

        public static void UpdatePermission(PERMISSION permission)
        {
            try
            {
                PERMISSION pr = db.PERMISSION.First(x => x.ID == permission.ID);
                pr.PermissionStarDate = permission.PermissionStarDate;
                pr.PermissionEndDate = permission.PermissionEndDate;
                pr.PermissionExplanation = permission.PermissionExplanation;
                pr.PermissionDay = permission.PermissionDay;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdatePermission(int permissionID, int approved)
        {
            try
            {
                PERMISSION pr =db.PERMISSION.First(x =>x.ID == permissionID);
                pr.PermissionState = approved;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
