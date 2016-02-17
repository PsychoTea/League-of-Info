using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Json;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace League_of_Info
{
    [Serializable()]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TextSummonerName.Text) || string.IsNullOrWhiteSpace(DropdownRegion.Text)))
            {
                string json = "";
                    using (var webClient = new System.Net.WebClient())
                    {
                        string json2dl = string.Format("http://sparkyserver.no-ip.org/getinfo.php?action=summoner&region={0}&summonerName={1}", DropdownRegion.Text, TextSummonerName.Text);
                        json = webClient.DownloadString(json2dl);
                        JObject lolData = JObject.Parse(json);

                        string SummonerNameLC = TextSummonerName.Text.ToLower();
                        LabelSummonerID.Text = "ID: " + lolData[SummonerNameLC]["id"];
                        LabelSummonerNameOut.Text = "Name: " + lolData[SummonerNameLC]["name"];
                        LabelSummonerProfileIconID.Text = "Profile Icon ID: " + lolData[SummonerNameLC]["profileIconId"];
                        LabelSummonerLevel.Text = "Level: " + lolData[SummonerNameLC]["summonerLevel"];
                    }
            }
            else MessageBox.Show("Error!" + "\n" + "Please enter all the information!");
        }

        private void ButtonLMI_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TextSummonerName.Text) || string.IsNullOrWhiteSpace(DropdownRegion.Text)))
            {
                Form2 lmiForm = new Form2();
                lmiForm.region = DropdownRegion.Text;
                lmiForm.summonerName = TextSummonerName.Text.ToLower();
                lmiForm.Show();
            }
            else MessageBox.Show("Error!" + "\n" + "Please enter all the information!");
        }
    }
}