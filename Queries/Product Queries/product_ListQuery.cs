using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEğitimKampi501.Dtos;
using CSharpEğitimKampi501.ConnectionString;
using Dapper;
using System.Runtime.InteropServices;

namespace CSharpEğitimKampi501.Queries.Product_Queries
{
    public class product_ListQuery
    {
        public async Task ExecuteAsync(System.Windows.Forms.DataGridView dataGridView)
        {
            string query =
                            @"SELECT Product_ID AS productID," +
                            "Product_Name AS productName," +
                            "Product_Stock AS productStock," +
                            "Product_Price AS productPrice," +
                            "Product_Category AS productCategory " +
                            "FROM TblProduct";

            using (var connection = ConnectionString.DatabaseConnectionString.GetConnectionString())
            {
                await connection.OpenAsync();
                var values = await connection.QueryAsync<ProductDto>(query);
                dataGridView.DataSource = values;
            }
        }
    }
}
