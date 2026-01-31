using CSharpEğitimKampi501.ConnectionString;
using CSharpEğitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampi501.Queries.Product_Queries
{
    public class product_InsertQuery
    {
        public async Task ExecuteAsync(ProductDto data)
        {
            string insertQuery =
                            "INSERT INTO TblProduct (Product_Name, Product_Price, Product_Stock, Product_Category) " +
                            "VALUES (@Product_Name, @Product_Price, @Product_Stock, @Product_Category)";
            var parameters = new
            {
                Product_Name = data.productName,
                Product_Price = data.productPrice,
                Product_Stock = data.productStock,
                Product_Category = data.productCategory
            };

            using (var connection = ConnectionString.DatabaseConnectionString.GetConnectionString())
            {
                await connection.OpenAsync();
                await connection.ExecuteAsync(insertQuery, parameters);
            }
        }
    }
}
