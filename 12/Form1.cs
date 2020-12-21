using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_5;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // расчет первой задачи
        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверяем конвертацию
            try
            {
                int a = Convert.ToInt32(textBoxA.Text);
                int b = Convert.ToInt32(textBoxB.Text);
                int c = Convert.ToInt32(textBoxC.Text);
                int v,
                    s;
                // вызываем метод расчета
                Class1.First(a, b, c, out v, out s);
                // выводим результат
                textBoxV.Text = v.ToString();
                textBoxS.Text = s.ToString();
            }
            // при ошибке конвертации выводим подсказку
            catch
            {
                MessageBox.Show("Ошибка конвертации! Хотя бы одно из введенных значений не является целым числом!");
            }
        }
        // сброс первой задачи
        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сбросToolStripMenuItem2.PerformClick();
            сбросToolStripMenuItem3.PerformClick();
        }
        // расчет второй задачи
        private void рассчитатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int sum, proiz;
            // проверяем конвертацию
            try
            {
                int a = Convert.ToInt32(textBoxChislo.Text);
                // вызываем метод расчета
                Class1.Second(a, out sum, out proiz);
                textBoxSum.Text = sum.ToString();
                textBoxProiz.Text = proiz.ToString();
            }
            // при ошибке конвертации выводим подсказку
            catch
            {
                MessageBox.Show("Ошибка конвертации! Количество секунд должно быть целым числом!");
            }
        }
        // сброс второй задачи
        private void сбросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.PerformClick();
            toolStripMenuItem3.PerformClick();
        }
        // о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 1:\nДаны длины ребер a, b, c прямоугольного параллелепипеда. " +
                "Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c)." +
                "\nЗадание 2:\nДано двузначное число. Найти сумму и произведение его цифр.");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // переключение на 1 вкладку TabControl 
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Задание 1";
            сбросToolStripMenuItem1.PerformClick();
            сбросToolStripMenuItem.PerformClick();
        }
        // переключение на 2 вкладку TabControl 
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Задание 2";
            сбросToolStripMenuItem.PerformClick();
            сбросToolStripMenuItem1.PerformClick();
        } 
        // таймер для обновления даты и времени в статусстрипе
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            statusStrip1.Items[1].Text = "Дата: " + now.Day + "." + now.Month + "." + now.Year;
            statusStrip1.Items[2].Text = "Время: " + now.Hour + ":" + now.Minute;
        }
        // Пояснение к входным данный первой задачи (вызвано в контекстном меню)
        private void чтоВводитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A, b и c - длины рёбер прямоугольного параллелепипеда.\nПрограмма рассчитает объем и площадь поверхности фигуры.");
        }
        // Сброс входных данных первой задачи (вызвано в контекстном меню)
        private void сбросToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
        }
        // Сброс выходных данных первой задачи (вызвано в контекстном меню)
        private void сбросToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBoxS.Clear();
            textBoxV.Clear();
            textBoxSum.Clear();
        }
        // Пояснение к входным данный второй задачи (вызвано в контекстном меню)
        private void чтоВводитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Число - двузначное число.\nПрограмма рассчитает сумму и произведение его цифр.");
        }
        // Сброс входных данных первой задачи (вызвано в контекстном меню)
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBoxChislo.Clear();
        }
        // Сброс выходных данных первой задачи (вызвано в контекстном меню)
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBoxSum.Clear();
            textBoxProiz.Clear();
        }
        // при изменнении входных данных очищать поле результата
        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            сбросToolStripMenuItem3.PerformClick();
        }
        // при изменнении входных данных очищать поле результата
        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            сбросToolStripMenuItem3.PerformClick();
        }
        // при изменнении входных данных очищать поле результата
        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            сбросToolStripMenuItem3.PerformClick();
        }
        // при изменнении входных данных очищать поле результата
        private void textBoxSec_TextChanged(object sender, EventArgs e)
        {
            toolStripMenuItem3.PerformClick();
        }
    }
}
