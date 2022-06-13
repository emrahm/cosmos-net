using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millicent.Net.Crypto;
using Millicent.Net.Crypto.Implemetations;

namespace Millicent.Net.Backend.Business.Account
{  
/// <summary>
    /// `millivaloper-` prefixed validator operator address
    /// </summary>
    public class ValidatorAddress
    {
        private ValidatorAddress(string value)
        {
            Value = value;
        }


        public string Value { get; set; }

        public static ValidatorAddress New(string value)
        {
            return new ValidatorAddress(value);
        }
        /// <summary>
        /// Checks if a string is a milli validator address.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return Validate(Value);
        }

        public bool Validate(string value)
        {
            return Bech32Helper.CheckPrefixAndLength("millivaloper", value, 51);
        }

        /// <summary>
        /// Converts a milli account address to a validator address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static ValidatorAddress FromAccAddress(AccountAddress address)
        {
            var vals = Bech32.Decode(address.Value);
            return new ValidatorAddress(Bech32.Encode("millivaloper", vals.words));
        }
    }
}
