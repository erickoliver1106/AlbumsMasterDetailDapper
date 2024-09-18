using System.Data.SqlClient;

namespace AlbumsMasterDetailDapper.Data
{
    public abstract class GenericRepository
    {
        protected SqlConnection dbConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-7K0593G;Initial Catalog=AlbumsMasterDetail;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
