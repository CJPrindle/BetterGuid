namespace BetterGUID
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class frmMain : Form
    {
        public string CurrentGuid { get; set; }
        public frmMain()
        {
            InitializeComponent();

            GenerateGuid();
            SetOutputValue();
        }

        private void GenerateGuid()
        {
            CurrentGuid = Guid.NewGuid().ToString().ToUpper();

            lblValueOnly.Text = CurrentGuid;
            lblWithBrackets.Text = $"{{{CurrentGuid}}}";
            lblGuidParse.Text = $@"var guid = Guid.Parse(""{CurrentGuid}"");";

            SetOutputValue();
        }

        private void SetOutputValue()
        {
            lblOutValue.Text =
                  rdoValueOnly.Checked ? lblValueOnly.Text
                : rdoEmpty.Checked ? lblGuidEmpty.Text
                : rdoWithBrackets.Checked ? lblWithBrackets.Text
                : rdoGuidParse.Checked ? lblGuidParse.Text
                : lblGuidEmpty.Text;

            Clipboard.SetText(lblOutValue.Text);
        }
        private void rdoGuidBrackets_CheckedChanged(object sender, EventArgs e) => SetOutputValue();
        
        private void rdoValueOnly_CheckedChanged(object sender, EventArgs e) => SetOutputValue();

        private void rdoGuidParse_CheckedChanged(object sender, EventArgs e) => SetOutputValue();

        private void rdoEmpty_CheckedChanged(object sender, EventArgs e) => SetOutputValue();

        private void btnNewGuid_Click(object sender, EventArgs e) => GenerateGuid();

        private void linkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
