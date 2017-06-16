using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DeployCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = @"Text files | *.PublishSettings",
                Multiselect = false
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;

            var path = dialog.FileName;

            var fileContents = File.ReadAllText(path);

            var document = XDocument.Parse(fileContents);

            var deploys = document.Descendants("publishProfile")
                .Where(x => Get(x, "publishMethod") == "MSDeploy" || Get(x, "publishMethod") == "FTP")
                .Select(x => new
                {
                    DeployType = Get(x, "publishMethod"),
                    Url = Get(x, "publishUrl"),
                    SiteName = Get(x, "msdeploySite"),
                    Account = Get(x, "userName"),
                    Password = Get(x, "userPWD")
                })
                .ToList();

            var ftp = deploys.FirstOrDefault(x => x.DeployType == "FTP");

            tbxFtpUrl.Text = ftp.Url;
            tbxFTPAccount.Text = ftp.Account;
            tbxPassword.Text = ftp.Password;

            var msDeploy = deploys.FirstOrDefault(x => x.DeployType == "MSDeploy");

            tbxWebDeployArg.Text = $@"Y ""/M:https://{msDeploy.Url}/MsDeploy.axd?Site={msDeploy.SiteName.ToLower()}"" /U:{msDeploy.Account} /P:$(DeployPassword) /A:Basic ""-enableRule:DoNotDeleteRule -setParam:name='IIS Web Application Name',value='{msDeploy.SiteName.ToLower()}'""";

        }

        private void btnChose_Click(object sender, EventArgs e)
        {
           
        }

        private string Get(XElement element, string name)
        {
            return (string) element.Attribute(name);
        }
    }
}