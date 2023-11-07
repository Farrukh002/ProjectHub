using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetakeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "accdb File|*.accdb";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextbox.Text = fileDialog.FileName;
                string nameFile = fileDialog.SafeFileName;
                string [] names = nameFile.Split('.');
                string name1 = names[0];
                MessageBox.Show(nameFile);

                if(pathTextbox.Text != "")
                {
                    ReadAccessDB(name1, pathTextbox.Text);
                }
            }
        }
        
        public void ReadAccessDB(string name, string filePath)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath;
            string query = "select * from " + name;
            OleDbConnection connect = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, connect);
            connect.Open(); 
            OleDbDataReader reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                int ID = (int)reader["ID"];
                string Name = reader["name"].ToString();
                string color = reader["color"].ToString();
                int coordinate1 = (int)reader["coordinate1"];
                int coordinate2 = (int)reader["coordinate2"];
                int coordinate3 = (int)reader["coordinate3"];
                int coordinate4 = (int)reader["coordinate4"];
                int coordinate5 = (int)reader["coordinate5"];
                int coordinate6 = (int)reader["coordinate6"];

                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 3);
                if ( coordinate1 == 10 & coordinate2 == 10 & coordinate3 == 250 & coordinate4 == 250 &
                    coordinate5 == 50 & coordinate6 == 230)
                {
                    g.DrawArc(pen, coordinate1, coordinate2, coordinate3, coordinate4, coordinate5, coordinate6);
                }
                else if (coordinate1 == 30 & coordinate2 == 30 & coordinate3 == 210 & coordinate4 == 210 &
                    coordinate5 == 50 & coordinate6 == 230)
                {
                    g.DrawArc(pen, coordinate1, coordinate2, coordinate3, coordinate4, coordinate5, coordinate6);
                }
                else if (coordinate1 == 155 & coordinate2 == 12 & coordinate3 == 153 & coordinate4 == 30)
                {
                    g.DrawLine(pen, coordinate1, coordinate2, coordinate3, coordinate4);

                }
                else if (coordinate1 == 200 & coordinate2 == 215 & coordinate3 == 212 & coordinate4 == 230)
                {
                    g.DrawLine(pen, coordinate1, coordinate2, coordinate3, coordinate4);

                }
                else if (coordinate1 == 200 & coordinate2 == 60 & coordinate3 == 20 & coordinate4 == 120)
                {
                    g.FillRectangle(Brushes.Yellow, coordinate1, coordinate2, coordinate3, coordinate4);

                }
                else if (coordinate1 == 250 & coordinate2 == 60 & coordinate3 == 20 & coordinate4 == 120)
                {
                    g.FillRectangle(Brushes.Red, coordinate1, coordinate2, coordinate3, coordinate4);

                }
                else if (coordinate1 == 180 & coordinate2 == 80 & coordinate3 == 120 & coordinate4 == 20)
                {
                    g.FillRectangle(Brushes.Green, coordinate1, coordinate2, coordinate3, coordinate4);

                }
                else if (coordinate1 == 180 & coordinate2 == 140 & coordinate3 == 120 & coordinate4 == 20)
                {
                    g.FillRectangle(Brushes.Gray, coordinate1, coordinate2, coordinate3, coordinate4);

                }
                else
                {
                    MessageBox.Show("Something is wrong in coordinates");
                }
  
            }

            connect.Close();

        }
    }
}
