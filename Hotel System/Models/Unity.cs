using System.Configuration;

namespace Hotel_System.Models
{
    static class Unity
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["LocalMoh"].ConnectionString;

        //#region Important String used in Table Configurations

        public static string RoomPrice => "RoomPrice";


        public static int I { set; get; } = 0;
        //#endregion
    }
}
