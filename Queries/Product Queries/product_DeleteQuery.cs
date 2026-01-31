using CSharpEğitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampi501.Queries.Product_Queries
{
    public class product_DeleteQuery
    {
        public async Task ExecuteAsync(ProductDto data)
        {
            string deleteQuery =
            (
                "DELETE FROM TblProduct " +
                "WHERE Product_ID = @ProductID"
            );


            var parameters = new
            {
                ProductID = data.productID
            };

            using (var connection = ConnectionString.DatabaseConnectionString.GetConnectionString())
            {
                await connection.OpenAsync();
                await connection.ExecuteAsync(deleteQuery, parameters);
            }
        }
    }
}
