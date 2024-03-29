using Npgsql;
namespace Infrastructure;
using Dapper;
public class DapperContext
{
private readonly string _connectionString =
        "Server=localhost;Port=5432;Database=HomeClassTask28.03;User Id=postgres;Password=20082003";

 public NpgsqlConnection Connection(){

    return new NpgsqlConnection(_connectionString);

 }          

}
