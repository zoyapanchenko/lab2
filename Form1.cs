using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab2
{
    public partial class Form1 : Form
    {
        List<Actor> final = new List<Actor>();
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += MainForm_FormClosing;

            dataGridView1.RowHeadersWidth = 30;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Чи дійсно ви хочете завершити роботу з програмою?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSelectXMLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtXmlPath.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectXSLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XSL Files|*.xsl";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtXslPath.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectHTMLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML Files|*.html";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtHtmlPath.Text = openFileDialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            string xmlPath = txtXmlPath.Text;
            string xslPath = txtXslPath.Text;
            string htmlPath = txtHtmlPath.Text;

            if (!IsValidPath(xmlPath, ".xml"))
            {
                errors.Add("Невірний шлях до XML файлу.");
            }

            if (!IsValidPath(xslPath, ".xsl"))
            {
                errors.Add("Невірний шлях до XSL файлу.");
            }

            if (!IsValidPath(htmlPath, ".html"))
            {
                errors.Add("Невірний шлях до HTML файлу.");
            }

            if (errors.Count > 0)
            {
                ShowErrorMessageBox(string.Join("\n", errors));
                return;
            }

            Transformator transformator = new Transformator();
            List<Actor> filteredActor = final;
            transformator.Transform(filteredActor, xmlPath, xslPath, htmlPath);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cmbDirector.Text = null;
            cmbYear.Text = null;
            cmbMovie.Text = null;
            cmbActorName.Text = null;

            final = null;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            string xmlPath = txtXmlPath.Text;

            if (!IsValidPath(xmlPath, ".xml"))
            {
                errors.Add("Невірний шлях до XML файлу.");
            }
            
            if (cmbStrategy.SelectedItem == null)
            {
                errors.Add("Будь ласка, виберіть спосіб аналізу документа.");
            }

            if (errors.Count > 0)
            {
                ShowErrorMessageBox(string.Join("\n", errors));
                return;
            }

            dataGridView1.Rows.Clear();

            Actor _actor = OurActor();

            string selectedStrategy = cmbStrategy.SelectedItem.ToString();

            if (selectedStrategy == "SAX API")
            {
                IXmlParserStrategy strategy = new SAXParsingStrategy();
                final = strategy.Analyze(_actor, xmlPath);
                Output(final);
            }
            else if (selectedStrategy == "DOM API")
            {
                IXmlParserStrategy strategy = new DOMParsingStrategy();
                final = strategy.Analyze(_actor, xmlPath);
                Output(final);
            }
            else if (selectedStrategy == "LINQ to XML")
            {
                IXmlParserStrategy strategy = new LINQParsingStrategy();
                final = strategy.Analyze(_actor, xmlPath);
                Output(final);
            }
        }

        private void txtXmlPath_TextChanged(object sender, EventArgs e)
        {
            LoadDirectors();
            LoadYears();
            LoadMovies();
            LoadActorNames();
        }

        //
        //FUNCTIONS
        //

        private Actor OurActor()
        {
            string[] info = new string[5];
            if (cmbDirector.SelectedItem != null) { info[0] = Convert.ToString(cmbDirector.Text); }
            else if (cmbDirector.SelectedItem == null && cmbDirector.Text != "") { info[0] = Convert.ToString(cmbDirector.Text); }

            if (cmbYear.SelectedItem != null) info[1] = Convert.ToString(cmbYear.Text);
            else if (cmbYear.SelectedItem == null && cmbYear.Text != "") { info[0] = Convert.ToString(cmbYear.Text); }

            if (cmbMovie.SelectedItem != null) info[2] = Convert.ToString(cmbMovie.Text);
            else if (cmbMovie.SelectedItem == null && cmbMovie.Text != "") { info[0] = Convert.ToString(cmbMovie.Text); }

            if (cmbActorName.SelectedItem != null) info[3] = Convert.ToString(cmbActorName.Text);
            else if (cmbActorName.SelectedItem == null && cmbActorName.Text != "") { info[0] = Convert.ToString(cmbActorName.Text); }

            Actor filteredActor = new Actor(info);

            return filteredActor;
        }

        private void Output(List<Actor> actors)
        {
            dataGridView1.Rows.Clear();

            foreach (Actor actor in actors)
            {
                if (int.TryParse(actor.Screentime, out int screentime))
                {
                    dataGridView1.Rows.Add(actor.Director, actor.Year, actor.Movie, actor.Name, screentime);
                }
                else
                {
                    dataGridView1.Rows.Add(actor.Director, actor.Year, actor.Movie, actor.Name, null);
                }
            }

            dataGridView1.CurrentCell = null;
        }

        private void ShowErrorMessageBox(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Отакої!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsValidPath(string path, string fileType)
        {
            try
            {
                if (Path.IsPathRooted(path) && File.Exists(path))
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
                    if (!string.IsNullOrWhiteSpace(fileNameWithoutExtension) && Path.GetExtension(path).Equals(fileType, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }

            return false;
        }

        private void LoadComboBoxItems(string xpath, ComboBox comboBox)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(txtXmlPath.Text);

                XmlNodeList nodes = xmlDoc.SelectNodes(xpath);

                HashSet<string> unique = new HashSet<string>();

                if (nodes.Count > 0)
                {
                    foreach (XmlNode node in nodes)
                    {
                        string nodeName = node.Attributes["name"].Value;
                        unique.Add(nodeName);
                    }

                    comboBox.Items.Clear();
                    comboBox.Items.AddRange(unique.ToArray());
                    comboBox.DropDownHeight = 106;
                }
                else
                {
                    comboBox.Items.Clear();
                    comboBox.DropDownHeight = 106;
                }
            }
            catch (Exception ex)
            {
                
                comboBox.Items.Clear();
                comboBox.DropDownHeight = 106;
            }
        }

        private void LoadDirectors()
        {
            LoadComboBoxItems("/cinema/director", cmbDirector);
        }

        private void LoadYears()
        {
            LoadComboBoxItems("//year", cmbYear);
        }

        private void LoadMovies()
        {
            LoadComboBoxItems("//movie", cmbMovie);
        }

        private void LoadActorNames()
        {
            LoadComboBoxItems("//actor", cmbActorName);
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
