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
    Salary, Attend, Nationality, Points, 
    MemberShipId, Rate, FoodQuality, Rest,
    Description, Date, Advantages, Amount,
    TargetAmount, ReservationDate, Number,
    CheckInDate, CheckOutDate, DurationDays,
    Type, IsAvailable, Price, RoomNumber,
    IsCompleted, Paid, 
    ClientId, RoomId, PaymentId

}
internal static class Unity
{
    public static string ConnectionString =>
        ConfigurationManager.ConnectionStrings["OnLine"].ConnectionString;

    //#region Important String used in Table Configurations

    public static string RoomPrice => "RoomPrice";
    public static string UpgradePercentage => "UpgradePercentage";

    public static int MangerId => 1;
    //#endregion
}