using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _115SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int datetime = Int32.Parse(textBox2.Text);
            String result = "";
            for (int i = datetime + 1; i <= datetime+78; i++)
            {
                result += "select " + i + ",(select A1 FROM oneone WHERE QISHU = " + i + "),SUM(A1),count(A1),SUM(A1)/count(A1) from oneone where QISHU >" + datetime + " AND QISHU <= " + i + " UNION" + "\r\n";
            }
            textBox1.Text = result.Substring(0,result.Length-7) +";";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                textBox1.SelectAll();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
            }
        }
    }
}
