using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuddly_Red_Waffle_app
{ 
    public partial class RequestsUserControl : UserControl
    {
        public RequestsUserControl()
        {
            InitializeComponent();
        }

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            addRequestForm form = new addRequestForm();
            form.Show();
        }

        private void RequestsUserControl_Load(object sender, EventArgs e)
        {
            this.requestTableAdapter.Fill(this.uSANA_DBDataSet.Request);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RequestsUserControl_Load(sender, e);
        }
    }
}
