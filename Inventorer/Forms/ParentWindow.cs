using System.Windows.Forms;

namespace Inventorer
{
    public partial class ParentWindow : Form
    {
        public ParentWindow()
        {
            InitializeComponent();
            var main = new MainScreenForm
            {
                MdiParent = this
            };
            main.Show();
        }

    }

}
