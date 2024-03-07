using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace DetectiveApp
{
    public partial class DetectiveForm : Form
    {
        public DetectivesBase alldetectives;
        private string dataFilePath;
        public string json;
        public DetectiveForm()
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
            DetectivesBase detectivesBase = new DetectivesBase(detectives, suspects, cases);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DetectivesBase));

            using (FileStream fs = new FileStream("detective.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, detectivesBase);
            }

            json = SerializeObjectToJson(detectivesBase);
            File.WriteAllText("detective.json", json);
        }

        private void Downloadbutton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            alldetectives = null;
            dataFilePath = openFileDialog.FileName;
            FileStream dataFile = new FileStream(dataFilePath, FileMode.OpenOrCreate);
            try
            {
                if (Path.GetExtension(dataFilePath) == ".xml")
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(DetectivesBase));
                    alldetectives = xmlSerializer.Deserialize(dataFile) as DetectivesBase;
                }
                else if (Path.GetExtension(dataFilePath) == ".json")
                {
                    alldetectives = DeserializeJsonToObject<DetectivesBase>(json);
                }
                dataFile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл", "Загрузка файла");
                return;
            }
            MessageBox.Show("Файл загружен", "Загрузка файлов");
        }
        public string SerializeObjectToJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
        public T DeserializeJsonToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            if (alldetectives == null)
            {
                return;
            }

            treeDetective.Nodes.Clear();

            DataTable dataTable1 = new DataTable();

            dataTable1.Columns.Add("Имя", typeof(string));
            dataTable1.Columns.Add("Возраст", typeof(int));
            dataTable1.Columns.Add("Направление", typeof(string));
            dataTable1.Columns.Add("Раскрытых дел", typeof(int));

            foreach (Detective detective in alldetectives.Detectives)
            {
                dataTable1.Rows.Add(detective.Name, detective.Age, detective.Direction, detective.CasesSolved);
            }

            dataGridDetectives.DataSource = dataTable1;

            DataTable dataTable2 = new DataTable();

            dataTable2.Columns.Add("Id", typeof(int));
            dataTable2.Columns.Add("Имя", typeof(string));
            dataTable2.Columns.Add("Возраст", typeof(int));

            foreach (Suspect suspect in alldetectives.Suspects)
            {
                dataTable2.Rows.Add(suspect.Id, suspect.Name, suspect.Age);
            }

            dataGridSuspect.DataSource = dataTable2;

            DataTable dataTable3 = new DataTable();

            // Add columns for detective information
            dataTable3.Columns.Add("Id", typeof(int));
            dataTable3.Columns.Add("Название", typeof(string));
            dataTable3.Columns.Add("Наказание", typeof(string));

            foreach (Case cases in alldetectives.Cases)
            {
                dataTable3.Rows.Add(cases.Id, cases.Title, cases.Punishment);
            }

            dataGridCases.DataSource = dataTable3;

            TreeNode detectivesTreeView = new TreeNode("Следователи");
            detectivesTreeView.Name = "detectivesCard";
            treeDetective.Nodes.Add(detectivesTreeView);
            TreeNode suspectsTreeView = new TreeNode("Подозреваемые");
            suspectsTreeView.Name = "suspectsCard";
            treeDetective.Nodes.Add(suspectsTreeView);
            TreeNode casesTreeView = new TreeNode("Дела");
            casesTreeView.Name = "casesCard";
            treeDetective.Nodes.Add(casesTreeView);
            foreach (Detective detective in alldetectives.Detectives)
            {
                TreeNode detectiveNode = new TreeNode(detective.Name);
                detectiveNode.Tag = detective;
                detectivesTreeView.Nodes.Add(detectiveNode);
            }
            foreach (Suspect suspect in alldetectives.Suspects)
            {
                TreeNode suspectNode = new TreeNode(suspect.Name);
                suspectNode.Tag = suspect;
                suspectsTreeView.Nodes.Add(suspectNode);
            }
            foreach (Case cases in alldetectives.Cases)
            {
                TreeNode casesNode = new TreeNode(cases.Title);
                casesNode.Tag = cases;
                casesTreeView.Nodes.Add(casesNode);
            }
        }
        private void OpenDetailsForm(object selectedObject)
        {
            if (selectedObject == null)
            {
                return;
            }

            InfoDetectives infoForm = new InfoDetectives(selectedObject);
            infoForm.Show();

            infoForm._selectedObject = selectedObject;
        }

        private void treeDetective_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                OpenDetailsForm(e.Node.Tag);
            }
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }   
}