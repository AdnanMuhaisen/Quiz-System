using Quiz_System___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_System___Middle_Layer
{
    public class clsUser
    {
        public enum eUserMode { New, Update }

        public string UserNameOrEmail { set; get; }

        public string Password { set; get; }

        private string HashValue { set; get; }

        private int Salt { set; get; }

        private eUserMode UserMode { set; get; }

        public clsUser() => (this.UserNameOrEmail, this.Password) = (string.Empty, string.Empty);

        public clsUser(string UserNameOrEmail,string Password)
        {
            this.UserNameOrEmail = UserNameOrEmail;
            this.Password = Password;
            this.UserMode = eUserMode.Update;
        }

        public clsUser(string UserNameOrEmail, string Password,string HashValue)
        {
            this.UserNameOrEmail = UserNameOrEmail;
            this.Password = Password;
            this.HashValue = HashValue;
            this.UserMode = eUserMode.Update;
        }


        public static bool IsUserExist(string UserNameOrEmail)
        {
            return DataAccess.IsUserExist(UserNameOrEmail);
        }

        private bool _AddNewUser()
        {
            this.Salt = clsHasher.GenerateSaltValue();
            this.HashValue = clsHasher.EncryptHashValue(clsHasher.ComputeSha256Hash(this.Password + Convert.ToString(this.Salt)));
            return DataAccess.AddNewUser(this.UserNameOrEmail, this.HashValue, this.Salt);
        }

        public bool VerifyPassword()
        {
            Tuple<string, int> T = DataAccess.GetHashValueAndSalt(this.UserNameOrEmail);
            if (T != null)
            {
                this.HashValue = clsHasher.ComputeSha256Hash(this.Password + T.Item2.ToString());
                if (this.HashValue.Equals(clsHasher.DecryptHashValue(T.Item1)))
                    return true;
                else
                    return false;
            }
            return false;
        }

        public static clsUser FindUser(string UserNameOrEmail)
        {
            string HashValue = default; int Salt = default;
            if(DataAccess.FindUser(UserNameOrEmail,ref HashValue,ref Salt))
            {
                // To Return Original Password :
                HashValue = clsHasher.DecryptHashValue(HashValue);
                clsUser Temp = new clsUser(UserNameOrEmail, default, HashValue);
                Temp.Salt = Salt;
                return Temp;
            }
            return null;
        }

        private bool _Update()
        {
            this.Salt = clsHasher.GenerateSaltValue();
            this.HashValue = clsHasher.EncryptHashValue(clsHasher.ComputeSha256Hash(this.Password + this.Salt.ToString()));
            return DataAccess.UpdateUserInformation(this.UserNameOrEmail, this.HashValue, this.Salt);
        }

        public bool Save()
        {
            switch (this.UserMode)
            {
                case eUserMode.New:
                    if (!IsUserExist(this.UserNameOrEmail))
                    {
                        this.UserMode=eUserMode.Update;
                        return this._AddNewUser();
                    }
                    break;

                case eUserMode.Update:
                    return this._Update();
            }
            return false;
        }

    }
}
