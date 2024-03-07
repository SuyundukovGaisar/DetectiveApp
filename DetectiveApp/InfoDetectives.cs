using System;
using System.Data;
using System.Windows.Forms;

namespace DetectiveApp
{
    public partial class InfoDetectives : Form
    {
        public object _selectedObject;
        public InfoDetectives()
        {
            InitializeComponent();
        }
        public InfoDetectives(object selectedObject)
        {
            InitializeComponent();
            _selectedObject = selectedObject;
            if (_selectedObject is Detective)
            {
                dataGridInfo.Columns.Add("Имя", "Name");
                dataGridInfo.Columns.Add("Возраст", "Age");
            }
            else if (_selectedObject is Suspect)
            {
                dataGridInfo.Columns.Add("Id", "Id");
                dataGridInfo.Columns.Add("Имя", "Name");
                dataGridInfo.Columns.Add("Возраст", "Age");
            }
            else if (_selectedObject is Case)
            {
                dataGridInfo.Columns.Add("Id", "Id");
                dataGridInfo.Columns.Add("Название", "Title");
                dataGridInfo.Columns.Add("Наказание", "Punishment");
            }
        }


    }
}
