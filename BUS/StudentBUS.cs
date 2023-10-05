﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using System.Data.Entity.Migrations;

namespace BUS
{
    public class StudentBUS
    {
        StudentModel context;
        public List<Student> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public Student FindById(string studentId)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }
        public void InsertNew(Student s)
        {
            context = new StudentModel();
            context.Students.Add(s);
            context.SaveChanges();
        }
        public void InsertUpdate(Student s)
        {
            context = new StudentModel();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

    }
}
