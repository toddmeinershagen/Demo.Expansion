using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo.Expansion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Options = new List<string>();
            //Options = new List<string> { "Option1" };
            //Options = new List<string> {"Option1", "Option2", "Option3", "Option4", "Option5"};
            //Options = GetOptions();
            //BindOptions();
        }

        private void BindOptions()
        {

            OptionsLayoutPanel.RowCount = Options.Count;
            
            for (int i = 0; i < Options.Count; i++)
            {
                var button = new RadioButton();
                button.Text = Options[i];

                var position = new TableLayoutPanelCellPosition(0, i);
                OptionsLayoutPanel.SetCellPosition(button, position);
                OptionsLayoutPanel.Controls.Add(button);
            }
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
            Options = GetOptions();
            BindOptions();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HorizontalLine_Click(object sender, EventArgs e)
        {

        }
    }
}
