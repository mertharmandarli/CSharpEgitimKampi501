using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEğitimKampi501.Dtos;
using CSharpEğitimKampi501.ConnectionString;
using Dapper;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharpEğitimKampi501.Queries.Product_Queries
{
    public class product_GetByIdQuery
    {
        public async Task ExecuteAsync(int productId, DataGridView grid)
        {
            string sql = 
                (
                    "SELECT " +
                            "Product_ID AS productID, " +       
                            "Product_Name AS productName, " +   
                            "Product_Stock AS productStock, " + 
                            "Product_Price AS productPrice, " + 
                            "Product_Category AS productCategory " +
                    "FROM TblProduct " +
                    "WHERE Product_ID = @ProductID"
                );

            var parameters = new 
            {
                ProductID = productId
            };

            using (var connection = ConnectionString.DatabaseConnectionString.GetConnectionString())
            {

                var result = await connection.QueryFirstOrDefaultAsync<ProductDto>(sql, parameters);
                grid.DataSource = result != null ? new List<ProductDto> { result } : null;

            }
        }
    }
}
