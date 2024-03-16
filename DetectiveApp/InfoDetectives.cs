using System;
using System.Collections.Generic;
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
            List<string> occupations1 = new List<string> { "Ограбления", "Убийства" };
            PlaceOfBirth PlaceOfBirth1 = new PlaceOfBirth("Севастополь", "Россия");
            Detective detective1 = new Detective("Иванов Федор", "Уголовные дела", occupations1, 45, PlaceOfBirth1, 57);
            List<string> occupations2 = new List<string> { "Штрафы", "Нарушения порядка" };
            PlaceOfBirth PlaceOfBirth2 = new PlaceOfBirth("Мурманск", "Россия");
            Detective detective2 = new Detective("Петров Александр", "Административные дела", occupations2, 60, PlaceOfBirth2, 89);
            List<string> occupations3 = new List<string> { "Кража данных", "Взломы" };
            PlaceOfBirth PlaceOfBirth3 = new PlaceOfBirth("Владивосток", "Россия");
            Detective detective3 = new Detective("Сидоров Антон", "Кибербезопасность", occupations3, 32, PlaceOfBirth3, 24);

            Violation violation1 = new Violation("Убийство", "Лишение свободы");
            Address address1 = new Address("Россия", "Москва");
            Suspect suspect1 = new Suspect(1, "Александр Александров", 48, address1, violation1);
            Violation violation2 = new Violation("Парковка в неположенном месте", "Штраф");
            Address address2 = new Address("Россия", "Норильск");
            Suspect suspect2 = new Suspect(2, "Константин Ефремов", 33, address2, violation2);
            Violation violation3 = new Violation("Взлом государственных баз данных", "Лишение свободы");
            Address address3 = new Address("Россия", "Санкт-Петербург");
            Suspect suspect3 = new Suspect(3, "Илья Алексеев", 19, address3, violation3);

            Employee employee1 = new Employee("Федор", "Иванов");
            Offender offender1 = new Offender("Александр", "Александров");
            Case case1 = new Case(1, "Убийство", employee1, offender1, "Лишение свободы");
            Employee employee2 = new Employee("Александр", "Петров");
            Offender offender2 = new Offender("Константин", "Ефремов");
            Case case2 = new Case(2, "Парковка в неположенном месте", employee2, offender2, "Штраф");
            Employee employee3 = new Employee("Антон", "Сидоров");
            Offender offender3 = new Offender("Илья", "Алексеев");
            Case case3 = new Case(3, "Взлом государственных баз данных", employee3, offender3, "Лишение свободы");

            List<Detective> detectives = new List<Detective>();
            detectives.Add(detective1);
            detectives.Add(detective2);
            detectives.Add(detective3);

            List<Suspect> suspects = new List<Suspect>();
            suspects.Add(suspect1);
            suspects.Add(suspect2);
            suspects.Add(suspect3);

            List<Case> cases = new List<Case>();
            cases.Add(case1);
            cases.Add(case2);
            cases.Add(case3);

            _selectedObject = selectedObject;
            if (_selectedObject is Detective)
            {
                dataGridInfo.Columns.Add("Имя", "Имя");
                dataGridInfo.Columns.Add("Возраст", "Возраст");
                dataGridInfo.Columns.Add("Направление", "Направление");
                dataGridInfo.Columns.Add("Раскрытых дел", "Раскрытых дел");
                foreach (Detective detective in detectives)
                {
                    dataGridInfo.Rows.Add(detective.Name, detective.Age, detective.Direction, detective.CasesSolved);
                }
            }
            else if (_selectedObject is Suspect)
            {
                dataGridInfo.Columns.Add("Id", "Id");
                dataGridInfo.Columns.Add("Имя", "Имя");
                dataGridInfo.Columns.Add("Возраст", "Возраст");
                foreach (Suspect suspect in suspects)
                {
                    dataGridInfo.Rows.Add(suspect.Id, suspect.Name, suspect.Age);
                }
            }
            else if (_selectedObject is Case)
            {
                dataGridInfo.Columns.Add("Id", "Id");
                dataGridInfo.Columns.Add("Название", "Название");
                dataGridInfo.Columns.Add("Наказание", "Наказание");
                foreach (Case casess in cases)
                {
                    dataGridInfo.Rows.Add(casess.Id, casess.Title, casess.Punishment);
                }
            }
        }


    }
}
