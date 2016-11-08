using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace SOSM1
{
    public static class InterfaceToDataBaseUserMethods
    {
        /// <summary>
        /// Attempts to log in using specified user name and password.
        /// Checks Active and Created users.
        /// If the state is Created changes state to Active.
        /// </summary>
        /// <param name="userName">Username to be checked.</param>
        /// <param name="password">Password to be checked.</param>
        /// <param name="loggedUserData">User data object of the logged user.</param>
        /// <returns>If operation succeded returns true, loggedUserDate is new User object.
        /// False otherwise, loggedUserData is null</returns>
        public static bool LogIn(string userName, string password, out User loggedUserData)
        {
            using (var context = new SOSMEntities())
            {
                var user = context.Users.FirstOrDefault(
                    x => x.Name == userName // search by userName
                    && (x.State == 0 || x.State == 1)); //user 'created' or 'active'
                if (user == null)
                {
                    loggedUserData = null;
                    return false;
                }
                if (user.Password != password)
                {
                    loggedUserData = null;
                    return false;
                }
                if (user.State == 0)
                {
                    user.State = 1;
                    context.Users.Attach(user);
                    var entry = context.Entry(user);
                    entry.Property(e => e.State).IsModified = true;

                    context.SaveChanges();
                }
                loggedUserData = new User(
                    user.Name,
                    user.E_mail,
                    user.Type,
                    user.State);
                loggedUserData.UserID = user.UserID;
                return true;
            }
        }

        /// <summary>
        /// Adds new user to database created from the User data object
        /// </summary>
        /// <param name="newUser">User data object for creating new user.</param>
        /// <param name="password">Password of created user.</param>
        /// <returns>True if it could add, false otherwise.</returns>
        public static bool AddUser(User newUser, string password)
        {
            using (var context = new SOSMEntities())
            {
                int usersAlreadyInDB = context.Users.Where(
                    x => x.Name == newUser.UserName // search by UserName
                    && (x.State == 0 || x.State == 1)).Count(); //user 'created' or 'active'
                if (usersAlreadyInDB != 0)
                    return false;

                Users user = new Users();
                user.Name = newUser.UserName;
                user.Password = password;
                user.E_mail = newUser.Mail;
                user.Type = newUser.Type;
                user.State = newUser.State;

                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Changes the state of a specified user in database / EAREASES HIM.
        /// If user state is Active, sets him as Archival.
        /// If user state is Created, EREASES HIM!!!
        /// If user state is Archival, does nothing.
        /// </summary>
        /// <param name="userID">ID of modified user.</param>
        /// <returns>True if success, false otherwise.</returns>
        public static bool DeleteUser(long userID)
        {
            using (var context = new SOSMEntities())
            {
                Users user = context.Users.Find(userID);
                if (user == null)
                    return false;
                switch (user.State)
                {
                    case 0: // state - created, EREASE HIM
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                            break;
                        }
                    case 1: // state - active, set as archival
                        {
                            user.State = 1;
                            var entry = context.Entry(user);
                            entry.Property(e => e.State).IsModified = true;
                            context.SaveChanges();
                            break;
                        }
                    case 2: // state - archival, nothing
                        {
                            return false;
                        }
                }
                return true;
            }
        }

        /// <summary>
        /// Gets User data object from the user with the specified userID
        /// </summary>
        /// <param name="UserID">Specified userID</param>
        /// <returns>User data object if user exists, null otherwise.</returns>
        public static User GetUserData(long userID)
        {
            using (var context = new SOSMEntities())
            {
                Users dbUser = context.Users.Find(userID);
                if (dbUser == null)
                    return null;

                User user = new User(
                    dbUser.Name,
                    dbUser.E_mail,
                    dbUser.Type,
                    dbUser.State
                );
                return user;
            }
        }

        /// <summary>
        /// Gets list of users who match terms specified by arguments.
        /// If the argument is null, it's not checked.
        /// </summary>
        /// <param name="searchArgument">User contains searchArgument in name or e-mail address.</param>
        /// <param name="type">User is of specified type.</param>
        /// <param name="state">User is of specified state.</param>
        /// <returns>List of User data objects who match the terms.</returns>
        public static List<User> CatalogUsers(string searchArgument = null, long? type = null, long? state = null)
        {
            throw new NotImplementedException();
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
        public static bool UserModification(long userID,string userName=null, string mail = null, string password = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to change the type of user with specified user ID
        /// </summary>
        /// <param name="userID">Specifies a user.</param>
        /// <param name="type">New type.</param>
        /// <returns>True if operation could be completed, false otherwise.</returns>
        public static bool ChangeType(long userID, long type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the state of user with userID from Created to Active.
        /// </summary>
        /// <param name="userID">Specifies a user.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public static bool Activate(long userID)
        {
            throw new NotImplementedException();
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
