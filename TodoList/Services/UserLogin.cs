using Microsoft.AspNetCore.Mvc;
using TodoList.Database;
using TodoList.Shared;

namespace TodoList.Services
{
    public class UserLogin
    {
        static private readonly TodoListDbContext _db = new TodoListDbContext();


        static public User? user;
        static public User? SignUp(UserDto userDto)
        {
            User user = new User();
            try
            {
                var exist = _db.Users.Where(x => x.Email == userDto.Email).FirstOrDefault();
                if (exist == null)
                {
                    user.UserName = userDto.UserName;
                    user.Password = userDto.Password;
                    user.Email = userDto.Email;
                    user.CreatedOn = DateTime.Now;
                    user.ModifyOn = DateTime.Now;
                    user.IsDeleted = false;
                    _db.Users.Add(user);
                    _db.SaveChanges();
                    return user;
                }
                else
                {

                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        static public User? SignIn(UserDto userDto)
        {
            User user = new User();
            try
            {
                var exist = _db.Users.Where(x => x.Email == userDto.Email && x.Password == userDto.Password).FirstOrDefault();
                if (exist != null)
                {

                    return exist;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
