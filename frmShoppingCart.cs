﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP21_Final_Project
{
    public partial class frmShoppingCart : Form
    {
        public static List<ProductPanel> lstCart = new List<ProductPanel>();
        public static List<int> lstQuantities = new List<int>();

        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            if (lstCart.Count > 0)
            {
                for (int intCurrentItem = 0; intCurrentItem < lstCart.Count; intCurrentItem++)
                {
                    lbxItemsInCart.Items.Add(lstCart[intCurrentItem].strProductName + " x" + lstQuantities[intCurrentItem]);
                }

                pbxProductImage.Image = lstCart[0].pbxProductImage.Image;
                lblProductName.Text = lstCart[0].strProductName;
                lblProductPrice.Text = lstCart[0].dblPrice.ToString();
                lblAmountOrdered.Text = "x" + lstQuantities[0];
                if(lstCart[0].GetDiscount() > 0)
                {
                    lblDiscount.Text = "-" + lstCart[0].GetDiscount() + "%";
                }
            }
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxItemsInCart.SelectedIndex >= 0)
            {
                lstCart.RemoveAt(lbxItemsInCart.SelectedIndex);
                lstQuantities.RemoveAt(lbxItemsInCart.SelectedIndex);
                lbxItemsInCart.Items.RemoveAt(lbxItemsInCart.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select an item in the list before removing.", "Select an Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbxItemsInCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxItemsInCart.SelectedIndex >= 0)
            {
                pbxProductImage.Image = lstCart[lbxItemsInCart.SelectedIndex].pbxProductImage.Image;
                lblProductName.Text = lstCart[lbxItemsInCart.SelectedIndex].strProductName;
                lblProductPrice.Text = lstCart[lbxItemsInCart.SelectedIndex].dblPrice.ToString();
                lblAmountOrdered.Text = "x" + lstQuantities[lbxItemsInCart.SelectedIndex];
                if (lstCart[lbxItemsInCart.SelectedIndex].GetDiscount() > 0)
                {
                    lblDiscount.Text = "-" + lstCart[lbxItemsInCart.SelectedIndex].GetDiscount() + "%";
                }
                else
                {
                    lblDiscount.Text = "";
                }
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (tbxCity.Text.Length <= 100 && tbxAddress.Text.Length <= 100)
            {
                DB.CreateInvoice(tbxCity.Text, tbxAddress.Text, lstCart, lstQuantities);
            }
            else
            {
                MessageBox.Show("City and address can only be 100 characters long.", "Error Making Purchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
