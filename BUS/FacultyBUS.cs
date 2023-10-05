using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FacultyBUS
    {
        public List<Faculty> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Faculties.ToList();
        }
    }
}
