using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
   public partial class frmMain : Form
   {
      public frmMain()
      {
         InitializeComponent();
      }




      /// <summary>
      /// Event raised on change of value in Bill Amount
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void txtBillAmount_TextChanged(object sender, EventArgs e)
      {
         try
         {
            if (!string.IsNullOrEmpty(txtBillAmount.Text))
            {
               if (Convert.ToDouble(txtBillAmount.Text) <= 0)
                  MessageBox.Show("Bill value can't be zero or below zero");
               else
                  UpdateTotals();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }




      /// <summary>
      /// Event raised on change of value in Tip %
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void txtTip_ValueChanged(object sender, EventArgs e)
      {
         UpdateTotals();
      }




      /// <summary>
      /// Event raised on change of value in number of People
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void txtPeople_ValueChanged(object sender, EventArgs e)
      {
         UpdateTotals();
      }



      /// <summary>
      /// Update the tip on the basis of Bill, Tip % and number of people
      /// </summary>
      private void UpdateTotals()
      {
         try
         {
            decimal perPersonBill = Convert.ToDecimal(txtBillAmount.Text) / txtPeople.Value;
            decimal tip = perPersonBill * (txtTip.Value / 100);
            lblTip.Text = "$" + tip.ToString("N2");
            lblTotal.Text = "$" + (tip + perPersonBill).ToString("N2");
         }
         catch (FormatException ex)
         {
            MessageBox.Show("Enter only numbers in bill amount");
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
   }
}
