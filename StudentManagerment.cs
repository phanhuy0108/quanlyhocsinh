using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MANAGERMENT
{
    public class StudentManagerment
    {
        public List<PM20483> GetStudent()
        {
            var db = new OOPCSEntities1();
            List<PM20483> student = db.PM20483.ToList();
            return student;
        }

        public PM20483 getStudents(int ID)
        {
            var db = new OOPCSEntities1();
            var students = db.PM20483.Find(ID);
            return students;
        }
        public void createStudent(string code, string name, string gender, string hometown)
        {
            var db = new OOPCSEntities1();
            var newStudent = new PM20483();
            newStudent.CODE = code;
            newStudent.NAME = name;
            bool isMale = true;
            if (gender == "Male")
                isMale = false;
            else
                isMale = true;
            newStudent.GENDER = isMale;
            newStudent.HOME_TOWN = hometown;

            db.PM20483.Add(newStudent);
            db.SaveChanges();
        }
        public void UpdateStudent( int id, string code ,string name, string gender, string hometown)
        {
            var db = new OOPCSEntities1();
            var currentStudent = db.PM20483.Find(id);

            currentStudent.CODE = code;
            currentStudent.NAME = name;
            bool isMale = true;
            if (gender == "Male")
                isMale = false;
            else
                isMale = true;
            currentStudent.GENDER = isMale;
            currentStudent.HOME_TOWN = hometown;
            db.Entry(currentStudent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void deleteStudent(int id)
        {
            var db = new OOPCSEntities1();
            var student = db.PM20483.Find(id);
            db.PM20483.Remove(student);
            db.SaveChanges();
        }
    }
    
}
