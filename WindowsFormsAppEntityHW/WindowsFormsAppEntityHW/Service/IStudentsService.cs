using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsAppEntityHW.Data;

namespace WindowsFormsAppEntityHW.Service
{
    public interface IStudentsService
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        List<Student> GetAllStudents();
        void DeleteStudent(int id);
        void DeleteAllStudents();
        void UpdateStudent(int id , Student student);

        void AddGroup(Group group);
        Group GetGroup(int id);
        List<Group> GetAllGroups();
        void DeleteGroup(int id);
        void DeleteAllGroups();
        void UpdateGroup(int id , Group group);
    }
}
