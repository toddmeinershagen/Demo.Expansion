using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo.Expansion
{
    public partial class K1OptionsForm : Form
    {
        public K1OptionsForm()
        {
            InitializeComponent();
        }

        private List<string> GetOptions()
        {
            const int maxOptions = 20;
            var numberGenerator = new Random();
            var numberOfOptions = numberGenerator.Next(maxOptions);

            var options = new List<string>();
            for (int i = 0; i < numberOfOptions; i++)
            {
                options.Add(string.Format("Option{0}", i));
            }

            return options;
        }

        public List<string> Options { get; set; }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            K1OptionsControl.DataSource = GetOptions();
            K1OptionsControl.BindData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
