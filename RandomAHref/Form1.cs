using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAHref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void AHrefButton_Click(object sender, EventArgs e)
        {
            string[] arr1 = textBox1.Text.Split('\n');
            string[] arr2 = textBox2.Text.Split('\n');

            //string[] arr1_r = RandomSort(arr1);

            foreach (var a in arr2)
            {
                if (a.Trim() != "")
                {
                    Random rand = new Random();
                    string value = arr1[rand.Next(arr1.Length)];
                    textBox3.Text += "<a href=\"" + a + "\">" + value + "</a>" + Environment.NewLine;

                }

            }

        }

        public static T[] RandomSort<T>(T[] array)
        {
            int len = array.Length;
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            T[] ret = new T[len];
            Random rand = new Random();
            int i = 0;
            while (list.Count < len)
            {
                int iter = rand.Next(0, len);
                if (!list.Contains(iter))
                {
                    list.Add(iter);
                    ret[i] = array[iter];
                    i++;
                }

            }
            return ret;
        }

        private void ClearKeywordButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ClearURLButton_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void ClearResultButton_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
