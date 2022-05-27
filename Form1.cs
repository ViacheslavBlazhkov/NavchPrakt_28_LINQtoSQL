using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace NavchPrakt_28_LINQtoSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = SQLConnection.GetDBConnection();
        FillTables ft = new FillTables();
        string query = "";
        

        private void buttonVyrAll_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                query = "SELECT * FROM vyrobnyk";
            if (radioButton2.Checked)
                query = "SELECT * FROM tovar";
            ft.FillTable(query, conn, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = $"SELECT * FROM Tovar WHERE nazvaTovar LIKE '%{textBox1.Text}%'";

            ft.FillTable(query, conn, dataGridView1);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Код товару") { query = "SELECT * FROM Tovar ORDER BY idTovar"; }
            if (comboBox1.SelectedItem.ToString() == "Назва товару") { query = "SELECT * FROM Tovar ORDER BY nazvaTovar"; }
            if (comboBox1.SelectedItem.ToString() == "Вага товару") { query = "SELECT * FROM Tovar ORDER BY vagaTovar"; }
            if (comboBox1.SelectedItem.ToString() == "Ціна товару") { query = "SELECT * FROM Tovar ORDER BY cinaTovar"; }
            if (comboBox1.SelectedItem.ToString() == "Код виробника") { query = "SELECT * FROM Tovar ORDER BY idVyrobnyk"; }

            ft.FillTable(query, conn, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValue = (textBox2.Text != string.Empty ? double.Parse(textBox2.Text) : 0).ToString().Replace(',','.');

            
            if (radioButton3.Checked) query = $"SELECT * FROM Tovar WHERE idTovar BETWEEN {firstValue} " +
                    $"AND (SELECT MAX(idTovar) FROM Tovar)";
            if (radioButton4.Checked) query = $"SELECT * FROM tovar WHERE vagaTovar BETWEEN {firstValue} " +
                    $"AND (SELECT MAX(vagaTovar) FROM Tovar)";
            if (radioButton5.Checked) query = $"SELECT * FROM tovar WHERE cinaTovar BETWEEN {firstValue} " +
                    $"AND (SELECT MAX(cinaTovar) FROM Tovar)";
            if (radioButton6.Checked) query = $"SELECT * FROM tovar WHERE idVyrobnyk BETWEEN {firstValue} " +
                    $"AND (SELECT MAX(idVyrobnyk) FROM Tovar)";

            ft.FillTable(query, conn, dataGridView1);
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = textBox4.Text;
            MySqlCommand cmd3 = new MySqlCommand(query, conn);
            int number1 = cmd3.ExecuteNonQuery();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = @"INSERT INTO Vyrobnyk values (@idVyrobnyk, @nazvaVyrobnyk, @adresaVyrobnyk)";
            MySqlCommand cmd3 = new MySqlCommand(query, conn);

            cmd3.Parameters.AddWithValue("@idVyrobnyk", int.Parse(textBox7.Text));
            cmd3.Parameters.AddWithValue("@nazvaVyrobnyk", textBox6.Text);
            cmd3.Parameters.AddWithValue("@adresaVyrobnyk", textBox5.Text);

            MessageBox.Show($"Додано об'єктів: {cmd3.ExecuteNonQuery()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = @"INSERT INTO Tovar values (@idTovar, @nazvaTovar, @vagaTovar, @cinaTovar, @idVyrobnyk)";
            MySqlCommand cmd3 = new MySqlCommand(query, conn);

            cmd3.Parameters.AddWithValue("@idTovar", int.Parse(textBox12.Text));
            cmd3.Parameters.AddWithValue("@nazvaTovar", textBox11.Text);
            cmd3.Parameters.AddWithValue("@vagaTovar", double.Parse(textBox10.Text));
            cmd3.Parameters.AddWithValue("@cinaTovar", double.Parse(textBox8.Text));
            cmd3.Parameters.AddWithValue("@idVyrobnyk", int.Parse(textBox9.Text));

            MessageBox.Show($"Додано об'єктів: {cmd3.ExecuteNonQuery()}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = textBox21.Text;
            MySqlCommand cmd3 = new MySqlCommand(query, conn);
            int number1 = cmd3.ExecuteNonQuery();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = textBox8.Text;
            MySqlCommand cmd3 = new MySqlCommand(query, conn);
            int number1 = cmd3.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = $"DELETE FROM Vyrobnyk WHERE idVyrobnyk = '{textBox19.Text}'";
            MySqlCommand cmd3 = new MySqlCommand(query, conn);

            MessageBox.Show($"Видалено об'єктів: {cmd3.ExecuteNonQuery()}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = $"DELETE FROM Tovar WHERE idTovar = '{textBox16.Text}'";
            MySqlCommand cmd3 = new MySqlCommand(query, conn);

            MessageBox.Show($"Видалено об'єктів: {cmd3.ExecuteNonQuery()}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = $"UPDATE Vyrobnyk SET adresaVyrobnyk = '{textBox15.Text}' WHERE idVyrobnyk = {textBox14.Text}";
            MySqlCommand cmd3 = new MySqlCommand(query, conn);

            MessageBox.Show($"Оновлено об'єктів: {cmd3.ExecuteNonQuery()}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.Close(); conn.Open();
            query = $"UPDATE Tovar SET cinaTovar = '{textBox17.Text}' WHERE idTovar = {textBox13.Text}";
            MySqlCommand cmd3 = new MySqlCommand(query, conn);

            MessageBox.Show($"Оновлено об'єктів: {cmd3.ExecuteNonQuery()}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Program.lf.button1.Focused == true)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
            }
        }
    }
}
