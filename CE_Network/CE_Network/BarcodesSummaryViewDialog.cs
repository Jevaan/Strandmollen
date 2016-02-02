using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CE_Network
{
    public partial class BarcodesSummaryViewDialog : Form
    {
        public BarcodesSummaryViewDialog()
        {
            InitializeComponent();
            // Attach event handlers to auto-hide controls.
            this.AttachVisibilityBindings(this.Controls);
        }

        private void editMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            CE_Network.BarcodesEditViewDialog barcodesEditViewDialog = CE_Network.BarcodesEditViewDialog.Instance(this.barcodesBindingSource);
            barcodesEditViewDialog.ShowDialog();
            this.Close();

        }

        private void BarcodesSummaryViewDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                this.AutoScrollPosition = new System.Drawing.Point(0, ((0 - this.AutoScrollPosition.Y)
                                - 16));
                e.Handled = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                this.AutoScrollPosition = new System.Drawing.Point(0, ((0 - this.AutoScrollPosition.Y)
                                + 16));
                e.Handled = true;
            }

        }
    }
}