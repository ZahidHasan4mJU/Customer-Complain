using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QueueAndDequeue2
{
    public partial class CustCareForm : Form
    {
        public CustCareForm()
        {
            InitializeComponent();
        }

        private int serial = 0;
        Queue<string> q = new Queue<string>();
        Queue<string> q2 = new Queue<string>(); 
        private void queueButton_Click(object sender, EventArgs e)
        {
            
            serial++;
            
            string name = nameTextBox.Text;
            string complain = complainTextBox.Text;
            nameTextBox.Text = "";
            complainTextBox.Text = "";
            q.Enqueue(serial.ToString());
            q.Enqueue(name);
            q2.Enqueue(complain);
            MessageBox.Show(name + @" 's serial number is " + serial);
            
            ListViewItem items = new ListViewItem(serial.ToString());
            items.SubItems.Add(name);
            items.SubItems.Add(complain);
            listView.Items.Add(items);
            

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (q.Count == 0)
            {
                MessageBox.Show(@"empty Queue !!");
            }
            else
            {
                serialNumTextBox.Text = q.Dequeue();
                nameTextBox2.Text = q.Dequeue();
                complainTextBox2.Text = q2.Dequeue();
                listView.Items[0].Remove();
            }


        }
    }
}
