using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13
{
    public partial class Form1 : Form
    {
        private WolfCollection collection = new WolfCollection();
        public Form1()
        {
            InitializeComponent();

            Wolf[] initial = new Wolf[]
            {
                new Wolf(40, 5, 150, "Арктичний", "Гренландія"),
                new Wolf(42, 3, 140, "Сірий", "Україна"),
                new Wolf(38, 4, 130, "Степовий", "Україна")
            };

            foreach (var wolf in initial)
            {
                collection.AddToArrayList((Wolf)wolf.Clone());
                collection.AddToGenericList((Wolf)wolf.Clone());
            }

            radioButtonArrayList.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonGenericList.CheckedChanged += RadioButton_CheckedChanged;

            UpdateListBox();
        }
        private void UpdateListBox()
        {
            listBoxWolves.Items.Clear();

            if (radioButtonArrayList.Checked)
            {
                int i = 1;
                foreach (var w in collection.IterateArrayList())
                {
                    listBoxWolves.Items.Add($"ArrayList Вовк №{i}:\n{w.Info()}\n");
                    i++;
                }
            }
            else if (radioButtonGenericList.Checked)
            {
                int i = 1;
                foreach (var w in collection.IterateGenericList())
                {
                    listBoxWolves.Items.Add($"List Вовк №{i}:\n{w.Info()}\n");
                    i++;
                }
            }
        }
        private void btnShowElement_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxIndex.Text, out int index))
            {
                string info = "";

                if (radioButtonArrayList.Checked)
                {
                    info = collection.GetFromArrayList(index - 1); //індексація з 0
                    MessageBox.Show("ArrayList:\n" + info);
                }
                else if (radioButtonGenericList.Checked)
                {
                    info = collection.GetFromGenericList(index - 1);
                    MessageBox.Show("Generic List:\n" + info);
                }
            }
            else
            {
                MessageBox.Show("Введіть коректний індекс.");
            }

        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (radioButtonArrayList.Checked)
            {
                List<Wolf> clones = new List<Wolf>();
                foreach (Wolf w in collection.IterateArrayList())
                {
                    clones.Add((Wolf)w.Clone());
                }
                foreach (var clone in clones)
                {
                    collection.AddToArrayList(clone);
                }
            }
            else if (radioButtonGenericList.Checked)
            {
                List<Wolf> clones = new List<Wolf>();
                foreach (Wolf w in collection.IterateGenericList())
                {
                    clones.Add((Wolf)w.Clone());
                }
                foreach (var clone in clones)
                {
                    collection.AddToGenericList(clone);
                }
            }

            MessageBox.Show("Клонування виконано");
            UpdateListBox();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxWolves.Items.Clear();

            if (radioButtonArrayList.Checked)
            {
                List<Wolf> sorted = new List<Wolf>(collection.IterateArrayList());
                sorted.Sort();

                int i = 1;
                foreach (var w in sorted)
                {
                    listBoxWolves.Items.Add($"ArrayList Відсортований вовк №{i}:\n{w.Info()}\n");
                    i++;
                }
            }
            else if (radioButtonGenericList.Checked)
            {
                List<Wolf> sorted = new List<Wolf>(collection.IterateGenericList());
                sorted.Sort();

                int i = 1;
                foreach (var w in sorted)
                {
                    listBoxWolves.Items.Add($"List Відсортований вовк №{i}:\n{w.Info()}\n");
                    i++;
                }
            }
            MessageBox.Show("Сортування виконано");
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxWolves.Items.Clear();

            if (radioButtonArrayList.Checked)
            {
                int i = 1;
                int index = 0;
                foreach (var w in collection.IterateArrayList())
                {
                    if (index % 2 == 0) 
                    {
                        listBoxWolves.Items.Add($"ArrayList Вовк №{index + 1}:\n{w.Info()}\n");
                        i++;
                    }
                    index++;
                }
            }
            else if (radioButtonGenericList.Checked)
            {
                int i = 1;
                int index = 0;
                foreach (var w in collection.IterateGenericList())
                {
                    if (index % 2 == 0)
                    {
                        listBoxWolves.Items.Add($"List Вовк №{index + 1}:\n{w.Info()}\n");
                        i++;
                    }
                    index++;
                }
            }
        }
    }
}
