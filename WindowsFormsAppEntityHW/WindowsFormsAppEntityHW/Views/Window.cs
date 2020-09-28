using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppEntityHW.Data;
using WindowsFormsAppEntityHW.Realizatoin;
using WindowsFormsAppEntityHW.Service;

namespace WindowsFormsAppEntityHW.Views
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            TableTabPage_SelectedIndexChanged(null, null);
            StudentsListBox.Items.Clear();
            StudentsListBox.Items.AddRange(_studentsService.GetAllStudents().Select(u => u.ToString()).ToArray());
            GroupsListBox.Items.Clear();
            GroupsListBox.Items.AddRange(_studentsService.GetAllGroups().Select(u => u.ToString()).ToArray());
        }

        private IStudentsService _studentsService = new StudentService();

        private void TableTabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableTabPage.SelectedIndex == 0)
            {
                GroupInfoPanel.Visible = false;
            }
            else
            {
                GroupInfoPanel.Visible = true;
            }
            ResetButton_Click(null, null);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TableTabPage.SelectedIndex == 0)
            {
                try
                {
                    _studentsService.AddStudent(new Student { Name = NameTextBox.Text, Age = Convert.ToInt32(AgeTextBox.Text) , Group_Id = Convert.ToInt32(GroupIdTextBox.Text) });
                }
                catch
                {

                }
            }
            else 
                _studentsService.AddGroup(new Group { Title = GroupsTitleTextBox.Text });
            ResetButton_Click(null, null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (TableTabPage.SelectedIndex == 0 && StudentsListBox.SelectedIndex != -1)
            {
                _studentsService.DeleteStudent(StudentsListBox.SelectedIndex);
            }
            else if (GroupsListBox.SelectedIndex != -1)
            {
                _studentsService.DeleteGroup(GroupsListBox.SelectedIndex);
            }
            ResetButton_Click(null, null);
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            if (TableTabPage.SelectedIndex == 0)
                _studentsService.DeleteAllStudents();
            else
                _studentsService.DeleteAllGroups();
            ResetButton_Click(null, null);
        }

        private void UpdtaeButton_Click(object sender, EventArgs e)
        {
            if (TableTabPage.SelectedIndex == 0 && StudentsListBox.SelectedIndex != -1)
            {
                try
                {
                    _studentsService.UpdateStudent(
                        StudentsListBox.SelectedIndex,
                        new Student { Name = NameTextBox.Text, Age = Convert.ToInt32(AgeTextBox.Text), Group_Id = Convert.ToInt32(GroupIdTextBox.Text) });
                }
                catch
                {

                }
            }
            else if (GroupsListBox.SelectedIndex != -1)
            {
                _studentsService.UpdateGroup(
                    GroupsListBox.SelectedIndex,
                  new Group { Title = GroupsTitleTextBox.Text });
            }
            ResetButton_Click(null, null);

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (TableTabPage.SelectedIndex == 0)
            {
                StudentsListBox.Items.Clear();
                StudentsListBox.Items.AddRange(_studentsService.GetAllStudents().Select(u => u.ToString()).ToArray());
               
            }
            else
            {
                GroupsListBox.Items.Clear();
                GroupsListBox.Items.AddRange(_studentsService.GetAllGroups().Select(u => u.ToString()).ToArray());
            }
        }
    }
}
