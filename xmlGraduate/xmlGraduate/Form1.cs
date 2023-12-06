using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using xmlGraduate.Models;
using xmlGraduate.Patterns;

namespace xmlGraduate
{
    public partial class Form1 : Form
    {
        private XMLConverter converter;
        private IEnumerable<Graduate> data;
        private IEnumerable<Graduate> postFilterData;

        private string filepath = string.Empty;

        public Form1()
        {
            this.converter = new XMLConverter();
            this.data = new List<Graduate>();
            this.postFilterData = new List<Graduate>();

            InitializeComponent();

            this.saxButton.Checked = true;
        }

        private void htmlButton_Click(object sender, EventArgs e)
        {
            var xsltDialog = new OpenFileDialog();
            xsltDialog.Filter = "XSLT Files|*.xslt|All Files|*.*";

            if (xsltDialog.ShowDialog() == DialogResult.OK)
            {
                var xsltFilePath = xsltDialog.FileName;

                var htmlDialog = new SaveFileDialog();

                if (htmlDialog.ShowDialog() == DialogResult.OK)
                {
                    this.converter.SaveInHTML(this.filepath, xsltFilePath, htmlDialog.FileName + ".html");

                    MessageBox.Show("Çáåðåæåíî â HTML");
                }
            }
        }

        private void â³äêðèòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files|*.xml|All Files|*.*";
            openFileDialog.Title = "Select an XML File";

            this.ResetAll();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                this.LoadDataBasedOnStrategy(openFileDialog.FileName);
                this.InsertFiltered();
            }
        }

        private void ResetAll()
        {
            this.richTextBox1.Clear();
            this.data = new List<Graduate>();
            this.postFilterData = new List<Graduate>();
            this.nameComboBox.Items.Clear();
            this.faculcyComboBox.Items.Clear();
            this.departamentComboBox.Items.Clear();
            this.nameComboBox.SelectedIndex = -1;
            this.faculcyComboBox.SelectedIndex = -1;
            this.departamentComboBox.SelectedIndex = -1;
            this.nameComboBox.Text = "";
            this.faculcyComboBox.Text = "";
            this.departamentComboBox.Text = "";
        }

        private void LoadDataBasedOnStrategy(string xmlFilePath)
        {
            IXMLStrategy s = default;
            if (this.saxButton.Checked)
            {
                s = new SAXStrategy();
            }
            else
            {
                if (this.domButton.Checked)
                {
                    s = new DOMStrategy();
                }
                else
                {
                    s = new LINQStrategy();
                }
            }

            var dataFromXML = s.Analyze(xmlFilePath);

            this.AppendToVisualization(dataFromXML, isLoading: true);

        }

        private void AppendToVisualization(IEnumerable<Graduate> graduates, bool isLoading = false)
        {
            if (isLoading)
            {
                this.data = graduates;
            }

            this.richTextBox1.Text = "";

            foreach (var graduate in graduates)
            {
                string formatedGraduateToString = string.Empty;

                formatedGraduateToString += $"-----------------------------------------\n";
                formatedGraduateToString += $"ID = {graduate.Id}\n";
                formatedGraduateToString += $"{graduate.Name}\n";
                formatedGraduateToString += $"{graduate.FaculcyName}\n";
                formatedGraduateToString += $"{graduate.Departament}\n";
                formatedGraduateToString += $"{graduate.Occupation}\n";
                formatedGraduateToString += $"{graduate.EnterDate}\n";
                formatedGraduateToString += $"{graduate.EndDate}\n";

                this.richTextBox1.Text += formatedGraduateToString;
            }


        }

        private void InsertFiltered()
        {
            var names = this.data.Select(x => x.Name).Distinct().ToList();
            this.nameComboBox.Items.Add(string.Empty);
            this.nameComboBox.Items.AddRange(names.ToArray());

            var faculcies = this.data.Select(x => x.FaculcyName).Distinct().ToList();
            this.faculcyComboBox.Items.Add(string.Empty);
            this.faculcyComboBox.Items.AddRange(faculcies.ToArray());

            var departaments = this.data.Select(x => x.Departament).Distinct().ToList();
            this.departamentComboBox.Items.Add(string.Empty);
            this.departamentComboBox.Items.AddRange(departaments.ToArray());
        }

        private void SaveToXML(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Graduate>));

            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, postFilterData);
            }
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Filter();
        }

        private void Filter()
        {
            var author = nameComboBox.SelectedItem?.ToString();
            var faculcy = faculcyComboBox.SelectedItem?.ToString();
            var departament = departamentComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(author) || !string.IsNullOrEmpty(faculcy) || !string.IsNullOrEmpty(departament))
            {
                this.postFilterData = this.data.Where(x =>
                        (string.IsNullOrEmpty(author) || x.Name == author) &&
                        (string.IsNullOrEmpty(faculcy) || x.FaculcyName == faculcy) &&
                        (string.IsNullOrEmpty(departament) || x.Departament == departament)).ToList();
            }
            else
            {
                this.postFilterData = this.data;
            }

            this.AppendToVisualization(this.postFilterData);
        }

        private void faculcyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Filter();
        }

        private void departamentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Filter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void çáåðåãòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                SaveToXML(filePath);

                MessageBox.Show("Çáåðåæåíî.");
            }
        }
    }
}