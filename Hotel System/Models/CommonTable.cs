using System.ComponentModel.DataAnnotations;

namespace Hotel_System.Models
{
    /// <summary>
    /// Represent the Shared/General Configuration Values 
    /// </summary>
    public class CommonTable
    {
        // Proprieties
        public string Key { get; private set; } = null!;
        public string Value { get; private set; } = null!;

        ///// <summary>
        ///// Get Value By Key Propriety
        ///// </summary>
        ///// <param name="key">Key PK</param>
        ///// <returns>Value</returns>
        //public string this[string key]
        //{
        //    set
        //    {
        //        if (key == Key) // if key exist, update value 
        //            Value = value;
        //        else // if key not exist, add key and assign value 
        //        {
        //            Key = key;
        //            Value = value;
        //        }
        //    }
        //    get
        //    {
        //        // get the 
        //        if (key == Key)
        //            return Value;
        //        return null!;
        //    }
        //}
    }
}
