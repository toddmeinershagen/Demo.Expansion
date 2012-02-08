using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo.Expansion
{
    public partial class K1OptionsControl : UserControl
    {
        public K1OptionsControl()
        {
            InitializeComponent();
        }

        public List<string> DataSource { get; set; }

        public void BindData()
        {
            OptionsTableLayout.RowCount = DataSource.Count;
            OptionsTableLayout.Controls.Clear();

            for (int i = 0; i < DataSource.Count; i++)
            {
                var button = new RadioButton();
                button.Text = DataSource[i];

                var position = new TableLayoutPanelCellPosition(0, i);
                OptionsTableLayout.SetCellPosition(button, position);

                OptionsTableLayout.Controls.Add(button);
            }
        }
    }
}
