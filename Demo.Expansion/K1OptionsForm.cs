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

        private void BindOptions()
        {
            OptionsTableLayout.RowCount = Options.Count;
            OptionsTableLayout.Controls.Clear();

            for (int i = 0; i < Options.Count; i++)
            {
                var button = new RadioButton();
                button.Text = Options[i];

                var position = new TableLayoutPanelCellPosition(0, i);
                OptionsTableLayout.SetCellPosition(button, position);
                
                OptionsTableLayout.Controls.Add(button);
            }
        }

        private int _currentRowNumber = 0;

        private List<string> GetOptions()
        {
            const int maxOptions = 20;
            var numberGenerator = new Random();
            var numberOfOptions = numberGenerator.Next(maxOptions);

            if (_currentRowNumber < maxOptions)
                _currentRowNumber++;

            var options = new List<string>();
            for (int i = 0; i < numberOfOptions; i++)
            //for (int i = 0; i < _currentRowNumber; i++)
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
    }
}
