using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo.Expansion
{
    public partial class K1OptionsControlStatic : UserControl
    {
        public K1OptionsControlStatic()
        {
            InitializeComponent();
        }

        public List<string> DataSource { get; set; }

        public void BindData()
        {
            var height = 2;
            const int optionHeight = 20;
            OptionsPanel.Height = height;

            OptionsPanel.Controls.Clear();

            const int maxNumberOfOptions = 2;
            var numberOfOptionsToDisplay = DataSource.Count < maxNumberOfOptions ? DataSource.Count : maxNumberOfOptions;
 
            for (int i = 0; i < numberOfOptionsToDisplay; i++)
            {
                height += optionHeight;
                var optionTitle = DataSource[i];
                var option = new RadioButton {Text = optionTitle};

                OptionsPanel.Height = height;
                OptionsPanel.Controls.Add(option);
            }

            OptionsPanel.Refresh();
        }
    }
}
