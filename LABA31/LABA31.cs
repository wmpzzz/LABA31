using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace LABA31
{
    public partial class LABA31 : Form
    {

        public LABA31()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "безымянный";
            FileTextRichTextBox.Text = "";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            FileTextRichTextBox.Text = fileText;
            this.Text = System.IO.Path.GetFileNameWithoutExtension(filename);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SaveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, FileTextRichTextBox.Text);
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            FileTextRichTextBox.SelectionColor = colorDialog.Color;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            FileTextRichTextBox.SelectionFont = fontDialog.Font;
        }

        private void LeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTextRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void CenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTextRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTextRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            DateToolStripStatusLabel.Text = DateTime.Now.ToLongDateString();
            TimeToolStripStatusLabel.Text = DateTime.Now.ToLongTimeString();

        }
        private void FileTextRichTextBox_TextChanged(object sender, EventArgs e)
        {

            
            NumbersToolStripStatusLabel.Text = $"Количество символов: {FileTextRichTextBox.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Length.ToString()}";
        }

        private void LABA31_Load(object sender, EventArgs e)
        {
            NumbersToolStripStatusLabel.Text = "Количество символов: 0";
        }
    }
}
