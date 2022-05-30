using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string namaTim;
        string namaManager;
        string namaStadium;

        int PosisiSekarang;

        string concatTopskor;
        string concatDiscipline;

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtInfoKlub = new DataTable();

        DataTable dtTeamManagerStadium = new DataTable();

        DataTable dtTopSkor = new DataTable();
        DataTable dtWorstDiscipline = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "Select t.team_name as 'Nama Tim', concat(m.manager_name,' (', n.nation, ')') as 'Manager', concat(t.home_stadium,', ',t.city,' (',t.capacity,')') as 'Stadium' from team t, manager m, nationality n where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id;";
            
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamManagerStadium);

            IsiDataTeamManagerStadium(0);

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            IsiDataTeamManagerStadium(0);
            
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataTeamManagerStadium(PosisiSekarang);                

            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTeamManagerStadium.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataTeamManagerStadium(PosisiSekarang);
               

            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            IsiDataTeamManagerStadium(dtTeamManagerStadium.Rows.Count - 1);
        }

        public void IsiDataTeamManagerStadium(int Posisi)
        {
            labelIsiNamaTim.Text = dtTeamManagerStadium.Rows[Posisi][0].ToString();
            labelIsiNamaManager.Text = dtTeamManagerStadium.Rows[Posisi][1].ToString();
            labelIsiNamaStadium.Text = dtTeamManagerStadium.Rows[Posisi][2].ToString();          
            PosisiSekarang = Posisi;

            IsiDataTopSkor();
            IsiDataDiscipline();
        }

        public void IsiDataTopSkor()
        {
            dtTopSkor = new DataTable();
            sqlQuery = "SELECT p.player_name as 'Nama Pemain', sum(if(dm.`type`='GO',1,0)) as 'Jumlah Goal', sum(if(dm.`type`='GP',1,0)) as 'Jumlah Goal Penalty' FROM player p, dmatch dm, team t WHERE p.player_id = dm.player_id and p.team_id = t.team_id and t.team_name = '" +labelIsiNamaTim.Text+"' GROUP BY 1 ORDER BY 2 DESC;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopSkor);

            int totalGolNP = Convert.ToInt32(dtTopSkor.Rows[0][1].ToString());
            int totalGolP = Convert.ToInt32(dtTopSkor.Rows[0][2].ToString());
            int jumlahGol = totalGolNP + totalGolP;

            concatTopskor = dtTopSkor.Rows[0][0].ToString() + " " + jumlahGol + "(" + dtTopSkor.Rows[0][2].ToString() + ")";
            

            labelIsiNamaTopSkor.Text = concatTopskor;

        }

        public void IsiDataDiscipline()
        {
            dtWorstDiscipline = new DataTable();
            sqlQuery = "SELECT p.player_name as 'Nama Player', sum(if(dm.`type` = 'CY',1,0)) as 'Jumlah Yellow Card', sum(if(dm.`type` = 'CR',1,0)) as 'Jumlah Red Card',sum(if(dm.`type` = 'CY',1,0)) + sum(if(dm.`type` = 'CR',3,0)) as 'Total Value' FROM dmatch dm, team t, player p WHERE p.player_id = dm.player_id and p.team_id = t.team_id and t.team_name = '"+ labelIsiNamaTim.Text +"' GROUP BY 1 ORDER BY 4 DESC;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorstDiscipline);

            concatDiscipline = dtWorstDiscipline.Rows[0][0].ToString() + ", " + dtWorstDiscipline.Rows[0][1].ToString() + " Yellow Card and " + dtWorstDiscipline.Rows[0][2] + " Red Card";

            labelIsiNamaWorstDiscipline.Text = concatDiscipline;
        }
    }
}
