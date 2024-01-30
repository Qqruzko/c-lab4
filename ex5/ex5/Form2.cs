using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
{
    public partial class Form2 : Form
    {
        private Form1 mainForm = null;
        public Form2(Form1 start_form)
        {
            mainForm = start_form;
            InitializeComponent();
            
        }
       

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int x1 = int.Parse(first_x.Text);
            int xlast = int.Parse(first_x.Text);
            if (x1 < 0)
            {
                x1=x1 * -1;
            }

            if (xlast < 0)
            {
                xlast = xlast * -1;
            }

            int counter_max = xlast - x1;
            int counter = 0;

            int x = x1;
            int y = x * 2;

            for (int i = 1; i < 4; i++)
            {
                this.mainForm.rich_text += "ada";
                this.mainForm.rich_text += Environment.NewLine;
            }

            for (int i = counter; counter < counter_max; i++)
            {
                this.mainform.rich_text += "ada";
                this.mainform.rich_text += environment.newline;
                counter++;
                y = x * 2;
                x1++;
            }


        }
    }
}
