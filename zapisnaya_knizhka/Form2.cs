using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace zapisnaya_knizhka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            timer1.Start();
        }
               
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zapisnaya_knizhkaDataSet11.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.zapisnaya_knizhkaDataSet1.Таблица1);
                        
            int month = System.DateTime.Now.Month;
            int year = System.DateTime.Now.Year;          

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string sMonth = dataGridView1.Rows[i].Cells[5].Value.ToString().Remove(5, 13).Remove(0, 3);
                int iMonth = Convert.ToInt32(sMonth);
                if (iMonth == month)
                 {
                    string sYear = dataGridView1.Rows[i].Cells[5].Value.ToString().Remove(10, 8).Remove(0, 6);
                    int iYear = Convert.ToInt32(sYear);
                    int iAge = year - iYear;
                    richTextBox2.Text += dataGridView1.Rows[i].Cells[1].Value.ToString() + " " + dataGridView1.Rows[i].Cells[2].Value.ToString() + " " + dataGridView1.Rows[i].Cells[3].Value.ToString() + ", " + iAge.ToString() + " лет." + "\n";
                 }
            }

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Visible = false;
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                          
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "Редактировать", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[4].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[5].Value = textBox5.Text;
                dataGridView1.CurrentRow.Cells[6].Value = textBox6.Text;
                dataGridView1.CurrentRow.Cells[7].Value = textBox7.Text;
                dataGridView1.CurrentRow.Cells[8].Value = DateTime.Today;
                Thread.Sleep(1000);
                this.Validate();
                this.таблица1BindingSource.EndEdit();
                this.таблица1TableAdapter.Update(this.zapisnaya_knizhkaDataSet1);
                MessageBox.Show("Изменения сохранены!");                
            }
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;
            }            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                richTextBox1.Text = "С днем рождения, " + dataGridView1.CurrentRow.Cells[2].Value + " ! Поздравлять тебя с днем рождения мне всегда очень приятно и легко! Ведь я тебе хочу пожелать того же, чего желаю себе и самым близким родным людям! Будь здоровым – когда человек здоров, он может все преодолеть и всего добиться. Будь любимым - когда в жизни есть настоящая любовь, мы можем горы свернуть! Будь успешным – пусть тебе удается все, за что ты берешься! Будь удачливым – пусть ее Величество Фортуна всегда будет к тебе благосклонна! Будь богатым – ведь так приятно, когда твои мечты воплощаются в жизнь!";
            }

            if (radioButton2.Checked)
            {
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value + " "+ dataGridView1.CurrentRow.Cells[3].Value + ", примите наши поздравления! \n С днем рожденья, пусть подарит радость \n Каждый день и каждая минута, \n Пусть работа будет вам не в тягость. \n Мы Вам желаем крепкого здоровья, \n Благополучия, в бизнесе успехов, \n Иметь возможность чаще отдыхать \n На даче, среди яблонь и орехов. \n Желаем счастья и тепла в семье, \n Пусть Ваши близкие здоровы будут. \n И в главке, раздавая ордена, \n Пускай заслуги Ваши не забудут.";
            }

            if (radioButton3.Checked)
            {
                richTextBox1.Text = "Волнуется сегодня небо, сбились с ног почтальоны, опустели цветочные магазины. Все потому, что сегодня Вы, " + dataGridView1.CurrentRow.Cells[2].Value + ", появились на свет. У Вас два крыла за спиной. Это ангелы подарили белоснежные паруса, которые хранят Вас и ведут по жизни. У Вас – горячее сердце. Пусть оно сжигает огорчения и неприятности, а притягивает удачу и мечты. Пусть годы, как дорогое вино, дарят вкус жизни, дни – радость и головокружение от счастья. Пусть рядом всегда будут те, кто любит Вас и ценит, Желаю Вам, " + dataGridView1.CurrentRow.Cells[2].Value + ", чтобы мечты сбывались, задуманное – осуществлялось, а на пути встречались интересные люди и дела. В День Рождения звучит много хороших слов и пожеланий. Так пусть же они доходят до неба и возвращаются к Вам маленькими и большими радостями, крупинками счастья и ворохом материальных благ!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text != "")
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.rtf";
                saveFile1.Filter = "RTF Files|*.rtf";
                saveFile1.FileName = "Поздравление";
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   saveFile1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            else MessageBox.Show("Выберите тип поздравления, имя получателя и нажмите кнопку генерировать!");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {            
            if (textBox8.Text != "" && textBox9.Text == "" && textBox10.Text == "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == textBox8.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

            if (textBox8.Text == "" && textBox9.Text != "" && textBox10.Text == "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == textBox9.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

            if (textBox8.Text == "" && textBox9.Text == "" && textBox10.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == textBox10.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

            if (textBox8.Text != "" && textBox9.Text == "" && textBox10.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox8.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == textBox10.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

            if (textBox8.Text != "" && textBox9.Text != "" && textBox10.Text == "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox8.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == textBox9.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

            if (textBox8.Text == "" && textBox9.Text != "" && textBox10.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == textBox9.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == textBox10.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

            if (textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox8.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == textBox9.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == textBox10.Text)
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;                
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" | textBox2.Text != "" | textBox3.Text != "" | textBox4.Text != "" | textBox5.Text != "" | textBox6.Text != "" | textBox7.Text != "")
            {
                DataRow newCustomersRow = zapisnaya_knizhkaDataSet1.Tables["таблица1"].NewRow();

                newCustomersRow["Фамилия"] = textBox1.Text;
                newCustomersRow["Имя"] = textBox2.Text;
                newCustomersRow["Отчество"] = textBox3.Text;
                newCustomersRow["Номер телефона"] = textBox4.Text;
                
                newCustomersRow["Характер знакомства"] = textBox6.Text;
                newCustomersRow["Примечания"] = textBox7.Text;
                newCustomersRow["Дата редактирования"] = DateTime.Today;

                DateTime dateValue = default(DateTime);
                if (textBox5.Text != "")
                {
                    if (DateTime.TryParse(textBox5.Text, out dateValue))
                    {
                        newCustomersRow["Дата рождения"] = textBox5.Text;
                        zapisnaya_knizhkaDataSet1.Tables["таблица1"].Rows.Add(newCustomersRow);
                    }
                    else MessageBox.Show("Некорректный формат даты! (ДД.ММ.ГГГГ)");
                }
                else zapisnaya_knizhkaDataSet1.Tables["таблица1"].Rows.Add(newCustomersRow);
                Thread.Sleep(1000);
                this.Validate();
                this.таблица1BindingSource.EndEdit();
                this.таблица1TableAdapter.Update(this.zapisnaya_knizhkaDataSet1);

                
            }
            else MessageBox.Show("Заполните хотя бы одно поле!");
                  
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Выйти из приложения?", "Выход", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;
            }          
        }

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    int current = dataGridView1.CurrentCell.RowIndex;
        //    zapisnaya_knizhkaDataSet1.Tables["таблица1"].Rows[current].Delete();
        //}

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "Удалить", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                int selectedCount = dataGridView1.SelectedRows.Count;
                while (selectedCount > 0)
                {
                    if (!dataGridView1.SelectedRows[0].IsNewRow)
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    selectedCount--;
                }
                Thread.Sleep(1000);
                this.Validate();
                this.таблица1BindingSource.EndEdit();
                this.таблица1TableAdapter.Update(this.zapisnaya_knizhkaDataSet1);                
            }
            if (res == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                if (textBox5.Text != "") { textBox5.Text = textBox5.Text.Remove(10, 8); }
                textBox6.Text = row.Cells[6].Value.ToString();
                textBox7.Text = row.Cells[7].Value.ToString();

            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        
    }
}
