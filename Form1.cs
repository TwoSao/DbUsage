
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(
       @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\WinFormsApp1\tooded_DB.mdf;Integrated Security=True");

        SqlCommand command;
        SqlDataAdapter adapter_toode, adapter_kategooria;
        public Form1()
        {

            InitializeComponent();
            NaitaKategooriad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        SaveFileDialog save;
        OpenFileDialog open;
        private void otsifailBtn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "C:\\Users\\opilane\\source\\repos\\WinFormsApp1\\images";
            open.Multiselect = true;
            open.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK && toodeTextB.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = "C:\\Users\\opilane\\source\\repos\\WinFormsApp1\\images";
                save.FileName = toodeTextB.Text;
                if (save.ShowDialog() == DialogResult.OK && toodeTextB.Text != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    toode_pb.Image = Image.FromFile(save.FileName);
                }
                else
                {
                    MessageBox.Show("Palun sisesta toote nimi!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in kat_box.Items)
            {
                if (item.ToString() == kat_box.Text)
                {
                    on = true;
                }
            }
            if (on == false)
            {
                connect.Open();
                command = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)", connect);
                command.Parameters.AddWithValue("kat", kat_box.Text.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                kat_box.Items.Add(kat_box.Text);

                kat_box.Items.Clear();
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Sama kategooria on juba olemas!");
            }
        }

        private void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, kategooria_nimetus FROM Kategooria", connect);
            DataTable tabel_kat = new DataTable();
            adapter_kategooria.Fill(tabel_kat);
            foreach (DataRow item in tabel_kat.Rows)

            {
                if (!kat_box.Items.Contains(item["kategooria_nimetus"]))
                {
                    kat_box.Items.Add(item["kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("DELETE FROM Kategooria WHERE kategooria_nimetus=@id", connect);
                    command.Parameters.AddWithValue("@id", item["Id"].ToString());
                    command.ExecuteNonQuery();

                }

            }
            connect.Close();
        }

        private void kustutakategorBtn_Click(object sender, EventArgs e)
        {
            if (kat_box.SelectedItem != null)
            {
                connect.Open();
                command = new SqlCommand("DELETE FROM Kategooria WHERE kategooria_nimetus=@kat", connect);
                command.Parameters.AddWithValue("@kat", kat_box.SelectedItem.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                kat_box.Items.Remove(kat_box.SelectedItem);
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Palun vali kategooria, mida soovid kustutada!");
            } 
        }
    }
}
