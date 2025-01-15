using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHT.SHTDATA;

namespace SHT.SHTBLL
{
    public class User
    {
        public string OldUserName { get; set; }
        public string OldPassword { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public string SportField { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool DeleteUser()
        {
                SHTDATA.User userCrud = new SHTDATA.User()
                {
                    Password = this.Password,
                    UserName = this.UserName,
                };
                bool message = userCrud.DeleteUser();
            if (message)
                return true;
            else
                return false;
        }
        public bool UpdateUser()
        {
            if(CheckLen() && CheckPhone(Phone) && CheckAge(Age))
            {
                SHTDATA.User userCrud = new SHTDATA.User()
                {
                    Name = this.Name,
                    UserName = this.UserName,
                    SportField = this.SportField,
                    Phone = this.Phone,
                    Age = this.Age,
                    Password = this.Password,
                    LastName = this.LastName,
                };
                bool message = userCrud.UpdateUser(OldUserName, OldPassword);
                if (message)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool InsertUser()
        {
            if (CheckLen() && CheckPhone(Phone) && CheckAge(Age))
            {
                SHTDATA.User userCrud = new SHTDATA.User()
                {
                    Name = this.Name,
                    UserName = this.UserName,
                    SportField = this.SportField,
                    Phone = this.Phone,
                    Age = this.Age,
                    Password = this.Password,
                    LastName = this.LastName,
                };
                userCrud.InsertUser();
                return true;
            }
            else
                return false;

        }
        private bool lenght(string text,int len)
        {
            if (text.Length > len)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckLen()
        {
            bool Check = true;
            Check = lenght(Name, 80);
            if (Check)
            {
                Check = lenght(LastName, 80);
                if (Check)
                {
                    Check = lenght(Phone, 11);
                    if (Check)
                    {
                        Check = lenght(SportField, 4);
                        if (Check)
                        {
                            Check = lenght(UserName, 80);
                            if (true)
                            {
                                Check = lenght(Password, 10);
                            }
                        }
                    }
                }
            }
            return Check;
        }
        
        private bool CheckPhone(string phone)
        {
            if (phone != "")
            {
                char[] phon = phone.ToCharArray();
                if (phon[0] == '0' && phon[1] == '9')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        private bool CheckAge(string age)
        {
            bool Check = true;
            if (age.Length < 11)
            {
                string[] number = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    number[i] = i.ToString();
                }
                string year = "", mounth = "", day = "";
                year = age.Substring(0, 4);
                mounth = age.Substring(5, 2);
                day = age.Substring(8, 2);
                foreach (var item in year)
                {
                    int che = Array.IndexOf(number, item.ToString());
                    if (che == -1)
                    {
                        Check = false;
                        break;
                    }
                }
                foreach (var item in mounth)
                {
                    int che = Array.IndexOf(number, item.ToString());
                    if (che == -1)
                    {
                        Check = false;
                        break;
                    }
                }
                foreach (var item in day)
                {
                    int che = Array.IndexOf(number, item.ToString());
                    if (che == -1)
                    {
                        Check = false;
                        break;
                    }
                }
                int m, d;
                m = int.Parse(mounth);
                d = int.Parse(day);
                if (m < 1 || m > 12)
                {
                    Check = false;
                }
                if (d < 1 || d > 31)
                {
                    Check = false;
                }
            }
            else
            {
                Check = false;
            }
            return Check;
        }

    }
}
