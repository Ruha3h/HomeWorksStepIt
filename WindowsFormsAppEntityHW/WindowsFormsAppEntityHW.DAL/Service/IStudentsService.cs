using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppEntityHW.DAL.Service
{
    public interface IStudentsService
    {
        void Add();
        void Get();
        void GetAll();
        void Delete();
        void DeleteAll();
    }
}
