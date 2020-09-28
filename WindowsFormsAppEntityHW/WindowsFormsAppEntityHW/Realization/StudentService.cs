using Serilog;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WindowsFormsAppEntityHW.Data;
using WindowsFormsAppEntityHW.Service;

namespace WindowsFormsAppEntityHW.Realizatoin
{
    class StudentService : IStudentsService
    {

        public event EventHandler<ErrorEventArgs> NotifyClientErrorEvent;
        public void AddStudent(Student student)
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    context.Students.Add(student);

                    context.SaveChanges();
                }
            }

            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public void AddGroup(Group group)
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    context.Groups.Add(group);

                    context.SaveChanges();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public void DeleteAllGroups()
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    context.Groups.RemoveRange(context.Groups);

                    context.SaveChanges();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public void DeleteAllStudents()
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    context.Students.RemoveRange(context.Students);

                    context.SaveChanges();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public void DeleteGroup(int id)
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    context.Groups.Remove(context.Groups.ToList().ElementAt(id));

                    context.SaveChanges();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public void DeleteStudent(int id)
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    //context.Students.Remove(context.Students.FirstOrDefault(x => x.Id == id));
                    context.Students.Remove(context.Students.ToList().ElementAt(id));

                    context.SaveChanges();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }
        public List<Group> GetAllGroups()
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    return context.Groups.ToList();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public List<Student> GetAllStudents()
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    return context.Students.ToList();
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public Group GetGroup(int id)
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    return context.Groups.ElementAt(id);
                }
            }


            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public Student GetStudent(int id)
        {
            try
            {
                using (var context = new SchoolDBEntities())
                {
                    return context.Students.ElementAt(id);
                }
            }

            catch (DbException ex)
            {
            }
            catch (Exception ex)
            {
            }

            return null;
        }
        public void UpdateStudent(int id, Student student)
        {
            DeleteStudent(id);
            AddStudent(student);
        }
        public void UpdateGroup(int id, Group group)
        {
            DeleteGroup(id);
            AddGroup(group);
        }
    }
}
