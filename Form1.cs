using CSharpEğitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using CSharpEğitimKampi501.ConnectionString;
using CSharpEğitimKampi501.Queries.Product_Queries;
using CSharpEğitimKampi501.Queries;


namespace CSharpEğitimKampi501
{
    public partial class Form1 : Form
    {
        private void cleanTexts()  // Formdaki Alanları Temizleme Metodu
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void autoList(object sender, EventArgs e)  // Otomatik Listeleme Metodu
        {
            await new product_ListQuery().ExecuteAsync(dataGridView1);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await new product_ListQuery().ExecuteAsync(dataGridView1);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await new product_ListQuery().ExecuteAsync(dataGridView1);
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            ProductDto newProduct = new ProductDto(); // New Struct Variable For Button

            #region Data Input

            newProduct.productName = txtProductName.Text;
            newProduct.productPrice = Convert.ToDecimal(txtProductPrice.Text);
            newProduct.productStock = Convert.ToInt32(txtProductStock.Text);
            newProduct.productCategory = txtProductCategory.Text;

            #endregion

            await new product_InsertQuery().ExecuteAsync(newProduct);  // Insert Product Query

            MessageBox.Show("The process of adding new products was successful." + MessageBoxButtons.OK + MessageBoxIcon.Information);  // Notification Message

            await new product_ListQuery().ExecuteAsync(dataGridView1);  // Product Get All Query

            cleanTexts();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDto deletedProduct = new ProductDto(); // New Struct Variable For Button

            #region Data Input

            deletedProduct.productID = Convert.ToInt32(txtProductID.Text);

            #endregion

            await new product_DeleteQuery().ExecuteAsync(deletedProduct);  // Delete Product Query

            MessageBox.Show("Product deletion process successfully completed." + MessageBoxButtons.OK + MessageBoxIcon.Information);  // Notification Message

            await new product_ListQuery().ExecuteAsync(dataGridView1);  // Product Get All Query

            cleanTexts();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductDto updatedProduct = new ProductDto();  // New Struct Variable For Button

            #region Data Input

            updatedProduct.productID = Convert.ToInt32(txtProductID.Text);
            updatedProduct.productName = txtProductName.Text;
            updatedProduct.productPrice = Convert.ToDecimal(txtProductPrice.Text);
            updatedProduct.productStock = Convert.ToInt32(txtProductStock.Text);
            updatedProduct.productCategory = txtProductCategory.Text;

            #endregion

            await new product_UpdateQuery().ExecuteAsync(updatedProduct);  // Update Product Query

            MessageBox.Show("Product update process successfully completed." + MessageBoxButtons.OK + MessageBoxIcon.Information);  // Notification Message

            await new product_ListQuery().ExecuteAsync(dataGridView1);  // Product Get All Query

            cleanTexts();
        }

        private async void btnGetByID_Click(object sender, EventArgs e)
        {
            ProductDto getbyidProduct = new ProductDto();

            #region Data Input

            getbyidProduct.productID = Convert.ToInt32(txtProductID.Text);

            #endregion

            await new product_GetByIdQuery().ExecuteAsync(getbyidProduct.productID, dataGridView1);  // Get By ID Product Query

            cleanTexts();

        }
    }
}
