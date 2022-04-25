using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_Матриц1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 1) //устанавливаю размер матрицы не больше 9
            {
                MessageBox.Show("Слишком большое количество столбцов!");
                textBox1.Clear();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 48 || e.KeyChar >= 54) && number != 8) // цифры и удаление
            {
                e.Handled = true;
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 48 || e.KeyChar >= 54) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBox2.Text); //считываю колво строк
            int column = Convert.ToInt32(textBox1.Text); // считываю колво столбцов
            double[,] matrix = new double[row, column]; //создаю матрицу
            panel1.Controls.Clear(); // очистка предыдущей матрицы
            panel2.Controls.Clear();
            double[] MatrixA = new double[row * column];
            double[] MatrixB = new double[row * column];
            for ( int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                { 
         
                    var textBox3 = new TextBox();
                    double a = Convert.ToDouble(textBox3.Text);
                    MatrixA[i] = a;
                    textBox3.Location = new Point(i * 30, j * 30);  // матрица A в текстбоксах
                    textBox3.Size = new Size(26, 26);
                    panel1.Controls.Add(textBox3);
                    var textBox4 = new TextBox();
                    double b = Convert.ToDouble(textBox4.Text);
                    MatrixB[i] = b;
                    textBox4.Location = new Point(i * 30, j * 30);  // матрица B в текстбоксах
                    textBox4.Size = new Size(26, 26);
                    panel2.Controls.Add(textBox4);
                    Label label = new Label();
                    label.Location = new Point(i * 30, j * 30);
                    label.Size = new Size(26, 26);
                    panel3.Controls.Add(label);
                    


                }
            }

           
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 1)
            {
                MessageBox.Show("Слишком большое количество строк!"); 
                textBox2.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
