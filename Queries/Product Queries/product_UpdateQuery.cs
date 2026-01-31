using CSharpEğitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampi501.Queries
{
    public class product_UpdateQuery
    {
        public async Task ExecuteAsync(ProductDto data)
        {
            string updateQuery =
                    (
                        "UPDATE TblProduct " +
                        "SET Product_Name = @ProductName, Product_Price = @ProductPrice, Product_Stock = @ProductStock, Product_Category = @ProductCategory " +
                        "WHERE Product_ID = @ProductID"
                    );
            var parameters = new
            {
                ProductID = data.productID,
                ProductName = data.productName,
                ProductPrice = data.productPrice,
                ProductStock = data.productStock,
                ProductCategory = data.productCategory
            };

            using (var connection = ConnectionString.DatabaseConnectionString.GetConnectionString())
            {
                await connection.OpenAsync();
                await connection.ExecuteAsync(updateQuery, parameters);
            }
        }
    }
}
