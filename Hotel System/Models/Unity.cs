using System.Configuration;

namespace Hotel_System.Models
{
    public enum Properties
    {
        Id ,UserName , Email , Password ,
        NId, Name ,Age , Gender , Address,

        Salary, Attend,

        Nationality, Points, MemberShipId
    }
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
