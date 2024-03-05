using SQLite;

namespace ExamenFinal.Repository
{
    public class TableData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}