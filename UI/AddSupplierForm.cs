using System;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Controller.Error;

namespace 一盒蛋玩具店.UI
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text == null || !MtxPhone.MaskCompleted)
                {
                    MessageBox.Show("輸入錯誤");
                }
                else
                {
                    if (!Controllers.HasSupplier(p => p.Name == TxtName.Text))
                    {
                        Controllers.AddSupplier(TxtName.Text, MtxPhone.Text);
                    }

                    this.Close();
                }
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
