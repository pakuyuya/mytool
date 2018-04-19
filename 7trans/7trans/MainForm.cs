using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _7trans.Encoder;
using _7trans.Common;

namespace _7trans
{
    public partial class MainForm : Form
    {
        private RingBuffer<string> undolog = new RingBuffer<string>(100);

        CsvValueEncoder csv = new CsvValueEncoder();
        SqlStringEncoder sql = new SqlStringEncoder();
        XmlValueEncoder xml = new XmlValueEncoder();

        public bool CloseGuard { get; set; } = true;

        public int autoUndologStage = 0;
        public string autoUndoPrevText = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void setTextFocus()
        {
            textBox.Focus();
            textBox.SelectAll();
        }

        private void PushUndolog()
        {
            undolog.Push(textBox.Text);
            autoUndologStage = 0;
        }
        private void Undo()
        {
            if (!undolog.IsEmpty) {
                textBox.Text = undolog.Pop();
            }
        }
        private void ExitApp()
        {
            CloseGuard = false;
            this.Close();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            setTextFocus();
        }

        private void btEncodeCSV_Click(object sender, EventArgs e)
        {
            PushUndolog();
            textBox.Text = csv.encode(textBox.Text);
            setTextFocus();
        }

        private void btDecodeCSV_Click(object sender, EventArgs e)
        {
            PushUndolog();
            textBox.Text = csv.decode(textBox.Text);
        }

        private void btEncodeSQLString_Click(object sender, EventArgs e)
        {
            PushUndolog();
            textBox.Text = sql.encode(textBox.Text);
            setTextFocus();
        }

        private void btDecodeSqlString_Click(object sender, EventArgs e)
        {
            PushUndolog();
            textBox.Text = sql.decode(textBox.Text);
            setTextFocus();
        }

        private void btEncodeXml_Click(object sender, EventArgs e)
        {
            PushUndolog();
            textBox.Text = xml.encode(textBox.Text);
            setTextFocus();
        }

        private void btDecodeXml_Click(object sender, EventArgs e)
        {
            PushUndolog();
            textBox.Text = xml.decode(textBox.Text);
            setTextFocus();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseGuard)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            textBox.Text = "z";
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenu.Show();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control) {

                switch (e.KeyCode) {
                    case Keys.Z: Undo(); break;
                    case Keys.D1: btEncodeCSV_Click(btEncodeCSV, new EventArgs()); break;
                    case Keys.D2: btDecodeCSV_Click(btEncodeCSV, new EventArgs()); break;
                    case Keys.D3: btEncodeSQLString_Click(btEncodeCSV, new EventArgs()); break;
                    case Keys.D4: btDecodeSqlString_Click(btEncodeCSV, new EventArgs()); break;
                    case Keys.D5: btEncodeXml_Click(btEncodeCSV, new EventArgs()); break;
                    case Keys.D6: btDecodeXml_Click(btEncodeCSV, new EventArgs()); break;
                    case Keys.W: ExitApp(); break;
                }
            }

        }

        private void undologTimer_Tick(object sender, EventArgs e)
        {
            if (autoUndologStage == 0)
            {
                if (autoUndoPrevText != textBox.Text)
                {
                    autoUndologStage = 1;
                }
            } else if (autoUndologStage == 1)
            {
                if (autoUndoPrevText == textBox.Text)
                {
                    PushUndolog();
                }
            }

            autoUndoPrevText = textBox.Text;
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            textBox.ClearUndo();
        }
    }
}
