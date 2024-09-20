using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class monitorItem : Form
    {
        public monitorItem()
        {
            InitializeComponent();
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            string itemId = txt_Item_Id.Text;
            string itemName = txt_Item_Name.Text;
            string Description = txtDesc.Text;
            string department = cmbDep.SelectedItem.ToString();
            int Quantity = int.Parse(txtQty.Text);
            double unitprice = double.Parse(txtUnitPrice.Text);
            double totalprice = double.Parse(txtTotalPrice.Text);
            string Category = cmbCategory.SelectedItem.ToString();
            DateTime manufactureDate = dtpMD.Value;
            DateTime expiryDate = dtpED.Value;
            string manufacturer = txtManufacturer.Text;

            CItem newItem = new CItem();
            newItem.addItem(itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category,manufactureDate,expiryDate,manufacturer);
            txt_Item_Name.Text = "";
            txtDesc.Text = "";
            cmbDep.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtUnitPrice.Text = "";
            txtTotalPrice.Text = "";
            cmbCategory.SelectedIndex = -1; // Reset the combobox
            dtpMD.Value = DateTime.Now;
            dtpED.Value = DateTime.Now;
            txtManufacturer.Text = "";

        }

        private void btn_Update_Item_Click(object sender, EventArgs e)
        {
            string itemId = txt_Item_Id.Text;
            string itemName = txt_Item_Name.Text;
            string Description = txtDesc.Text;
            string department = cmbDep.SelectedItem.ToString();
            int Quantity = int.Parse(txtQty.Text);
            double unitprice = double.Parse(txtUnitPrice.Text);
            double totalprice = double.Parse(txtTotalPrice.Text);
            string Category = cmbCategory.SelectedItem.ToString();
            DateTime manufactureDate = dtpMD.Value;
            DateTime expiryDate = dtpED.Value;
            string manufacturer = txtManufacturer.Text;

            CItem newItem = new CItem();
            newItem.editItem(itemId, itemName, Description, department, Quantity, unitprice, totalprice, Category, manufactureDate, expiryDate, manufacturer);
            txt_Item_Name.Text = "";
            txtDesc.Text = "";
            cmbDep.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtUnitPrice.Text = "";
            txtTotalPrice.Text = "";
            cmbCategory.SelectedIndex = -1; // Reset the combobox
            dtpMD.Value = DateTime.Now;
            dtpED.Value = DateTime.Now;
            txtManufacturer.Text = "";
        }

        private void btn_Delete_Item_Click(object sender, EventArgs e)
        {
            string itemId = txt_Item_Id.Text;
           

            CItem newItem = new CItem();
            newItem.removeItem(itemId);
            txt_Item_Name.Text = "";
            txtDesc.Text = "";
            cmbDep.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtUnitPrice.Text = "";
            txtTotalPrice.Text = "";
            cmbCategory.SelectedIndex = -1; // Reset the combobox
            dtpMD.Value = DateTime.Now;
            dtpED.Value = DateTime.Now;
            txtManufacturer.Text = "";
        }

        private void btn_Search_Item_Click(object sender, EventArgs e)
        {
            if (txt_Item_Id.Text != "")
            {
                string itemId = txt_Item_Id.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidItemId(itemId))
                {
                    CItem newItem = new CItem();
                    DataTable itemDetails = newItem.viewItem(itemId);

                    if (itemDetails.Rows.Count > 0)
                    {
                        DataRow row = itemDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txt_Item_Name.Text = row["itemName"].ToString();
                        txtDesc.Text = row["description"].ToString();
                        cmbDep.SelectedItem = row["department"].ToString();
                        txtQty.Text = row["quantity"].ToString();
                        txtUnitPrice.Text = row["unitPrice"].ToString();
                        txtTotalPrice.Text = row["totalPrice"].ToString();
                        cmbCategory.SelectedItem = row["category"].ToString();
                        dtpMD.Value = Convert.ToDateTime(row["manufactureDate"]);
                        dtpED.Value = Convert.ToDateTime(row["expiryDate"]);
                        txtManufacturer.Text = row["manufacturer"].ToString();

                        // Assuming cmbCategory has items matching the categories in your database
                        if (cmbCategory.Items.Contains(row["category"].ToString()))
                        {
                            cmbCategory.SelectedItem = row["category"].ToString();
                        }
                        else
                        {
                            cmbCategory.SelectedIndex = -1; // or set to a default value
                        }
                    }
                    else
                    {
                        MessageBox.Show("No item found with the provided Item ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no item is found
                        txt_Item_Name.Text = "";
                        txtDesc.Text = "";
                        cmbDep.SelectedIndex = -1; // Reset the combobox
                        txtQty.Text = "";
                        txtUnitPrice.Text = "";
                        txtTotalPrice.Text = "";
                        cmbCategory.SelectedIndex = -1; // Reset the combobox
                        dtpMD.Value = DateTime.Now;
                        dtpED.Value = DateTime.Now;
                        txtManufacturer.Text = "";
                    }
                }
                else
                {
                    // Do nothing, the ID is not valid
                }
            }
            else
            {
                // Clear or reset the fields if the text box is empty
                txt_Item_Name.Text = "";
                txtDesc.Text = "";
                cmbDep.SelectedIndex = -1; // Reset the combobox
                txtQty.Text = "";
                txtUnitPrice.Text = "";
                txtTotalPrice.Text = "";
                cmbCategory.SelectedIndex = -1; // Reset the combobox
                dtpMD.Value = DateTime.Now;
                dtpED.Value = DateTime.Now;
                txtManufacturer.Text = "";
            }
        }
        private bool IsValidItemId(string itemId)
        {
            // Implement your ID validation logic here
            // For example:
            return itemId.Length > 0; // Assuming the ID should not be empty
        }

        private void btn_Clear_Item_Click(object sender, EventArgs e)
        {
            txt_Item_Name.Text = "";
            txtDesc.Text = "";
            cmbDep.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtUnitPrice.Text = "";
            txtTotalPrice.Text = "";
            cmbCategory.SelectedIndex = -1; // Reset the combobox
            dtpMD.Value = DateTime.Now;
            dtpED.Value = DateTime.Now;
            txtManufacturer.Text = "";
        }
        private void CalculateTotalPrice()
        {
            if (txtQty.Text != "" && txtUnitPrice.Text != "")
            {
                int quantity = int.Parse(txtQty.Text);
                double unitPrice = double.Parse(txtUnitPrice.Text);
                double totalPrice = quantity * unitPrice;
                txtTotalPrice.Text = totalPrice.ToString();
            }
            else
            {
                txtTotalPrice.Text = "";
            }
        }

        private void pic_Sale_Dash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txt_Item_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
