using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContext
    {
        public static void AddTask(TASK task)
        {
            try
            {
                db.TASK.InsertOnSubmit(task);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void ApproveTask(int taskID, bool isAdmin)
        {
            try
            {
                TASK tsk = db.TASK.First(x => x.ID == taskID);
                if (isAdmin)
                    tsk.TaskState = TaskStates.Approved;
                else
                    tsk.TaskState = TaskStates.Delivered;
                tsk.TaskDeliveryDate = DateTime.Today;
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void DeleteTask(int taskID)
        {
            try
            {
                TASK ts = db.TASK.First(x => x.ID == taskID);
                db.TASK.DeleteOnSubmit(ts);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<TaskDetailDTO> GetTasks()
        {
            List<TaskDetailDTO> tasklist = new List<TaskDetailDTO>();
            var list = (from t in db.TASK
                        join s in db.TASKSTATE on t.TaskState equals s.ID
                        join e in db.EMPLOYEE on t.EmployeeID equals e.ID
                        join d in db.Department on e.DepartmentID equals d.ID
                        join p in db.POSITION on e.PositionID equals p.ID
                        select new
                        {
                            taskID = t.ID,
                            title = t.TaskTitle,
                            content = t.TaskContent,
                            startdate = t.TaskStarDate,
                            deliveryDate = t.TaskDeliveryDate,
                            taskStateName = s.StateName,
                            taskStateID = t.TaskState,
                            UserNo = e.UserNo,
                            Name = e.Name,
                            Employeeid = t.EmployeeID,
                            Surname = e.SurName,
                            positionName = p.PositionName,
                            departmentName=d.DepartmentName,
                            positionID=e.PositionID,
                            departamentId=e.DepartmentID,

                        }).OrderBy(x => x.startdate).ToList();
            foreach ( var item in list)
            {
                TaskDetailDTO dto = new TaskDetailDTO();
                dto.TaskID = item.taskID;
                dto.Title = item.title;
                dto.Content = item.content;
                dto.TaskSartDate= item.startdate;
                dto.TackDeliveryDate = item.deliveryDate;
                dto.TaskSateName= item.taskStateName;
                dto.taskStateID= item.taskStateID;
                dto.UserNo= item.UserNo;
                dto.Name = item.Name;
                dto.SurName=item.Surname;
                dto.DepartmentName=item.departmentName;
                dto.PositionID=item.positionID;
                dto.PositionName= item.positionName;
                dto.EmployeeID=item.Employeeid;
                tasklist.Add(dto);

            }
            return tasklist;
        }

        public static List<TASKSTATE> GettaskSatate()
        {
            return db.TASKSTATE.ToList();
        }

        public static void UpdateTask(TASK task)
        {
            try
            {
                TASK ts = db.TASK.First(x => x.ID == task.ID);
                ts.TaskTitle = task.TaskTitle;
                ts.TaskContent = task.TaskContent;
                ts.TaskState = task.TaskState;
                ts.EmployeeID = task.EmployeeID;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
