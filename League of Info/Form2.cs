using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace League_of_Info
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            Form1 loiForm = new Form1();
        }

        public string region { get; set; }
        public string summonerName { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            string summonerID;
            string json2dl;

            using (var webClient = new System.Net.WebClient())
            {
                json2dl = string.Format("http://sparkyserver.no-ip.org/getinfo.php?action=summoner&region={0}&summonerName={1}", region, summonerName);
                webClient.Encoding = Encoding.UTF8;
                string json = webClient.DownloadString(json2dl);
                JObject lolData = JObject.Parse(json);
                
                summonerID = lolData[summonerName]["id"].ToString();
            }

            using (var webClient2 = new System.Net.WebClient())
            {
                string json = webClient2.DownloadString(string.Format("http://sparkyserver.no-ip.org/getinfo.php?action=matchhistory&region={0}&summonerID={1}", region, summonerID));
                JObject lolData = JObject.Parse(json);

                LabelWinner.Text = (lolData["games"][0]["stats"]["win"].ToString() == "True") ? "Won: Yes" : "Won: No";
                LabelKills.Text = "Kills: " + lolData["games"][0]["stats"]["championsKilled"].ToString();
                LabelDeaths.Text = "Deaths: " + lolData["games"][0]["stats"]["numDeaths"].ToString();
                LabelAssists.Text = "Assists: " + lolData["games"][0]["stats"]["assists"].ToString();

                //LabelLargestCrit.Text = "Large Crit: " + lolData["games"][0]["stats"]["largestCriticalStrike"].ToString();
                LabelLargestMultiKill.Text = "Largest Multi Kill: " + lolData["games"][0]["stats"]["largestMultiKill"].ToString();

                LabelPhysicalDamageDealt.Text = "Physical Damage Dealt: " + lolData["games"][0]["stats"]["physicalDamageDealtPlayer"].ToString();
                LabelMagicDamageDealt.Text = "Magic Damage Dealt: " + lolData["games"][0]["stats"]["magicDamageDealtPlayer"].ToString();
                LabelTrueDamageDealt.Text = "True Damage Dealt: " + lolData["games"][0]["stats"]["trueDamageDealtPlayer"].ToString();
                LabelTotalDamageDealt.Text = "Total Damage Dealt: " + lolData["games"][0]["stats"]["totalDamageDealt"].ToString();

                LabelPhysicalDamageTaken.Text = "Physical Damage Taken: " + lolData["games"][0]["stats"]["physicalDamageTaken"].ToString();
                LabelMagicDamageTaken.Text = "Magic Damage Taken: " + lolData["games"][0]["stats"]["magicDamageTaken"].ToString();
                LabelTrueDamageTaken.Text = "True Damage Taken: " + lolData["games"][0]["stats"]["trueDamageTaken"].ToString();
                LabelTotalDamageTaken.Text = "Total Damage Taken: " + lolData["games"][0]["stats"]["totalDamageTaken"].ToString();

                LabelMinionsKilled.Text = "Minions Killed: " + lolData["games"][0]["stats"]["minionsKilled"].ToString();
                LabelGoldEarnt.Text = "Gold Earnt: " + lolData["games"][0]["stats"]["goldEarned"].ToString();
                LabelGoldSpent.Text = "Gold Spent: " + lolData["games"][0]["stats"]["goldSpent"].ToString();
            }
        }
    }
}

