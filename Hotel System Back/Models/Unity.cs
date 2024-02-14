using System.Configuration;
namespace Hotel_System_Back.Models;

public enum UserType
{
    Client, Employee
}
public enum Properties
{
    Id ,UserName , Email , Password ,
    NId, Name ,Age , Gender , Address,

    Salary, Attend,

    Nationality, Points, MemberShipId
}
internal static class Unity
{
    public static string ConnectionString =>
        ConfigurationManager.ConnectionStrings["LocalMoh"].ConnectionString;

    //#region Important String used in Table Configurations

    public static string RoomPrice => "RoomPrice";
    public static string UpgradePercentage => "10";

    public static int MangerId { get; } = 1;
    //#endregion
}