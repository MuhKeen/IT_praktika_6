using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_praktika_6
{
  public partial class Form1 : Form
  {
    int[] Mas = new int[15];
    int[] MasOld = new int[15];
    public Form1()
    {
      InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(-50, 50);
        MasOld[i] = Mas[i];
        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }
    // 10 
    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";
      for (int i = 0; i < 15; i++)
      {
        if (i % 2 == 0) Mas[i] += 1;
        else Mas[i] += 2;
        textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }

    }
    // 4
    int count1, count2 = 0;

    private void button4_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < 15; i++)
      {
        if (Mas[i] <= 0) count2 += 1;
      }
      textBox4.Text = "Чисел <= 0: " + count2;
      count2 = 0;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < 15; i++)
      {
        if (MasOld[i] <= 0 ) count1 += 1;
      }
      textBox3.Text = "Чисел <= 0: " + count1;
      count1 = 0;
    }
  }
}
