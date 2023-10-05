using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MajorBUS
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();

        }
    }
}
