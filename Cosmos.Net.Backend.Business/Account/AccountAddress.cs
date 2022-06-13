using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millicent.Net.Crypto;
using Millicent.Net.Crypto.Implemetations;

namespace Millicent.Net.Backend.Business.Account
{
    public class AccountAddress
    {
        public AccountAddress(string value)
        {
            Value = value;
        }
        public string Value { get; }

        /// <summary>
        /// Checks if a string is a valid Terra account address.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return Validate(Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Validate(string value)
        {
            return Bech32Helper.CheckPrefixAndLength("milli", value, 44);
        }

        /// <summary>
        /// Converts a validator address into an account address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static AccountAddress FromValAddress(ValidatorAddress address)
        {
            var vals = Bech32.Decode(address.Value);
            return new AccountAddress(Bech32.Encode("milli", vals.words));
        }

        
        /// <summary>
        /// New Mnemonic Key
        /// </summary>
        public static string NewMnemonicKey()
        {
            var key = new MnemonicKey();
            return key.Mnemonic;
        }

        /// <summary>
        /// Mnemonic Key Address
        /// </summary>
        public static string GetActualAddress(string mnemonicKey)
        {
            var key = new MnemonicKey(mnemonicKey);
            return GetAccountAddress(key.RawAddress).Value;
        }

         /// <summary>
        /// Millicent account address. `milli-` prefixed.
        /// </summary>
        private static AccountAddress GetAccountAddress(byte[] rawAddres)
        {
            return new AccountAddress(Bech32.Encode("milli", rawAddres));
        }

        /// <summary>
        /// Millicent validator address. `millivaloper-` prefixed.
        /// </summary>
        private static ValidatorAddress GetValidatorAddress(byte[] rawAddres)
        {
            return ValidatorAddress.New(Bech32.Encode("millivaloper", rawAddres));
        }
    }
}
