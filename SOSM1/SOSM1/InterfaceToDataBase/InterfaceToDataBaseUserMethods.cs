using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace SOSM1
{
    public class InterfaceToDataBaseUserMethods
    {
        SOSMEntities context;

        public InterfaceToDataBaseUserMethods()
        {
            context = new SOSMEntities();
        }


        /// <summary>
        /// Attempts to log in using specified user name and password.
        /// Checks Active and Created users.
        /// If the state is Created changes state to Active.
        /// </summary>
        /// <param name="userName">Username to be checked.</param>
        /// <param name="password">Password to be checked.</param>
        /// <returns>If operation succeded returns new User object.
        /// Otherwise returns null</returns>
        public async Task<User> LogIn(string userName, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(
                x => x.Name == userName // search by userName
                && (x.Password == password) // search by password
                && (x.State == 0 || x.State == 1)); //user 'created' or 'active'
            if (user == null)
            {
                return null;
            }
            if (user.State == 0)
            {
                user.State = 1;
                context.Users.Attach(user);
                var entry = context.Entry(user);
                entry.Property(e => e.State).IsModified = true;

                await context.SaveChangesAsync();
            }
            User loggedUserData = new User(
                user.Name,
                user.E_mail,
                user.Type,
                user.State);
            loggedUserData.UserID = user.UserID;
            return loggedUserData;
        }

        /// <summary>
        /// Adds new user to database created from the User data object
        /// </summary>
        /// <param name="newUser">User data object for creating new user.</param>
        /// <param name="password">Password of created user.</param>
        /// <returns>True if it could add, false otherwise.</returns>
        public async Task<bool> AddUser(User newUser, string password)
        {
            int usersAlreadyInDB = await context.Users.Where(
                x => x.Name == newUser.UserName // search by UserName
                && (x.State == 0 || x.State == 1)).CountAsync(); //user 'created' or 'active'
            if (usersAlreadyInDB != 0)
                return false;

            Users user = new Users();
            user.Name = newUser.UserName;
            user.Password = password;
            user.E_mail = newUser.Mail;
            user.Type = newUser.Type;
            user.State = newUser.State;

            context.Users.Add(user);
            await context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Changes the state of a specified user in database / EAREASES HIM.
        /// If user state is Active, sets him as Archival.
        /// If user state is Created, EREASES HIM!!!
        /// If user state is Archival, does nothing.
        /// </summary>
        /// <param name="userID">ID of modified user.</param>
        /// <returns>True if success, false otherwise.</returns>
        public async Task<bool> DeleteUser(long userID)
        {
            Users user = await context.Users.FindAsync(userID);
            if (user == null)
                return false;
            switch (user.State)
            {
                case 0: // state - created, EREASE THEY AND THIER PROPERTY(BASKETS) TOO!!!
                    {
                        context.Users.Remove(user);
                        var baskets = await context.Baskets.Where(x => x.UserID == user.UserID).ToListAsync();
                        foreach (var basket in baskets)
                        {
                            context.Baskets.Remove(basket);
                            var product = await context.Products.FindAsync(basket.ProductID);
                            product.Amount += basket.Amount;
                            context.Entry(product).Property(x => x.Amount).IsModified = true;
                        }
                        await context.SaveChangesAsync();
                        break;
                    }
                case 1: // state - active, set as archival
                    {
                        user.State = 1;
                        var entry = context.Entry(user);
                        entry.Property(e => e.State).IsModified = true;
                        await context.SaveChangesAsync();
                        break;
                    }
                case 2: // state - archival, nothing
                    {
                        return false;
                    }
            }
            return true;
        }

        /// <summary>
        /// Gets User data object from the user with the specified userID
        /// </summary>
        /// <param name="UserID">Specified userID</param>
        /// <returns>User data object if user exists, null otherwise.</returns>
        public async Task<User> GetUserData(long userID)
        {
            Users dbUser = await context.Users.FindAsync(userID);
            if (dbUser == null)
                return null;

            User user = new User(
                dbUser.Name,
                dbUser.E_mail,
                dbUser.Type,
                dbUser.State
            );
            user.UserID = userID;
            return user;
        }

        /// <summary>
        /// Gets list of users who match terms specified by arguments.
        /// If the argument is null, it's not checked.
        /// </summary>
        /// <param name="searchArgument">User contains searchArgument in name or e-mail address.</param>
        /// <param name="type">User is of specified type.</param>
        /// <param name="state">User is of specified state.</param>
        /// <returns>List of User data objects who match the terms.</returns>
        public async Task<List<User>> CatalogUsers(string searchArgument = null, long? type = null, long? state = null)
        {
            var users = context.Users.Where(x => 1 == 1);
            if (searchArgument != null)
                users = users.Where(
                    x => x.Name.Contains(searchArgument)
                    || x.E_mail.Contains(searchArgument));
            if (type != null)
                users = users.Where(x => x.Type == type);
            if (state != null)
                users = users.Where(x => x.State == state);

            var dbUsersList = await users.ToListAsync();
            List<User> usersList = new List<User>();
            foreach (Users dbUser in dbUsersList)
            {
                User kek = new User(
                    dbUser.Name,
                    dbUser.E_mail,
                    dbUser.Type,
                    dbUser.State
                );
                kek.UserID = dbUser.UserID;
                usersList.Add(kek);
            }

            return usersList;
        }

        /// <summary>
        /// Attempts to modify data of user with specified user ID.
        /// If argument is null it's not modified.
        /// </summary>
        /// <param name="userID">Specifies a user.</param>
        /// <param name="userName">New user name.</param>
        /// <param name="mail">New e-mail address.</param>
        /// <param name="password">New password.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public async Task<bool> UserModification(long userID, string userName = null, string mail = null, string password = null)
        {
            Users user = await context.Users.FindAsync(userID);
            if (user == null)
                return false;
            if (userName != null)
            {
                user.Name = userName;
                context.Entry(user).Property(e => e.Name).IsModified = true;
            }
            if (mail != null)
            {
                user.E_mail = mail;
                context.Entry(user).Property(e => e.E_mail).IsModified = true;
            }
            if (password != null)
            {
                user.Password = password;
                context.Entry(user).Property(e => e.Password).IsModified = true;
            }
            await context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Attempts to change the type of user with specified user ID
        /// </summary>
        /// <param name="userID">Specifies a user.</param>
        /// <param name="type">New type.</param>
        /// <returns>True if operation could be completed, false otherwise.</returns>
        public async Task<bool> ChangeType(long userID, long type)
        {
            Users user = await context.Users.FindAsync(userID);
            if (user == null)
                return false;
            user.Type = type;
            context.Entry(user).Property(e => e.Type).IsModified = true;
            await context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Changes the state of user with userID from Created to Active.
        /// </summary>
        /// <param name="userID">Specifies a user.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public async Task<bool> Activate(long userID)
        {
            Users user = await context.Users.FindAsync(userID);
            if (user == null)
                return false;
            if (user.State != 0)
                return false;
            user.State = 1;
            context.Entry(user).Property(e => e.State).IsModified = true;
            await context.SaveChangesAsync();
            return true;
        }

        ///// <summary>
        ///// Checks if there is an active user with specified user name and admin privileges.
        ///// </summary>
        ///// <param name="userName">Specified user name.</param>
        ///// <returns>True if is an admin, false otherwise.</returns>
        //public static bool CheckPrivilege(string userName)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Checks if user with user name equal to UserName exists in database and is Active or Created.
        ///// </summary>
        ///// <param name="userName">String with user name that we want to check.</param>
        ///// <returns>True if exists, false otherwise.</returns>
        //public static bool UserExists(string userName)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Creates User data object from the active user with specified name in the database.
        ///// </summary>
        ///// <param name="userName">Nameof the user we want to get data from.</param>
        ///// <returns>User data object if user exists, null otherwise.</returns>
        //public static User GetUserData(string userName)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
