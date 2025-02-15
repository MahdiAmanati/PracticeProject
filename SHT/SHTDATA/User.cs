using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHT.SHTDATA
{
    public class User : ModelUser
    {
        TestShtDataContext db = new TestShtDataContext();
        public bool InsertUser()
        {
            var user = db.TestUser.Where(x => x.UserName == this.UserName && x.Deleted == "0");
            if(user.Count() == 0)
            {
                db.TestUser.Add(new User
                {
                    Age = this.Age,
                    LastName = this.LastName,
                    Name = this.Name,
                    Password = this.Password,
                    Phone = this.Phone,
                    SportField = this.SportField,
                    UserName = this.UserName,
                });
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateUser(string OldUserName , string OldPassword)
        {
            try
            {
                var users = db.TestUser.Where(x => x.UserName == this.UserName && x.Deleted == "0");
                if (users.Count() == 0)
                {
                    var user = db.TestUser.Where(x => x.UserName == OldUserName 
                    && x.Password == OldPassword && x.Deleted == "0").Single();
                    user.Age = this.Age;
                    user.LastName = this.LastName;
                    user.Name = this.Name;
                    user.Password = this.Password;
                    user.Phone = this.Phone;
                    user.SportField = this.SportField;
                    user.UserName = this.UserName;
                    db.SaveChanges();
                    return true;
                }
                else 
                    return false;
               
            }
            catch (Exception)
            {
                return false;
            }
         
        }
        public bool DeleteUser()
        {
            try
            {
                var user = db.TestUser.Where(x => x.UserName == this.UserName 
                && x.Password == this.Password && x.Deleted == "0").Single();
                user.Deleted = "1";
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
         
        }
        public bool Select_EnrerUser()
        {
            try
            {
                var user = db.TestUser.Where(x => x.UserName == this.UserName 
                && x.Password == this.Password 
                && x.Deleted == "0").Single();
                if (user == null)
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
