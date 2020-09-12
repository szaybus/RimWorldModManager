using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace RimWorldModManager
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            var productInformation = new ProductHeaderValue("machinacyfrowa");
            var client = new GitHubClient(productInformation);
            Repository repo = await client.Repository.Get("CombatExtended-Continued", "CombatExtended");
            Release r = await client.Repository.Release.GetLatest("CombatExtended-Continued", "CombatExtended");
            label1.Text = r.TagName+r.Name;

        }
    }
}
