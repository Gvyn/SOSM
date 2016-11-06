using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace SOSM1
{
    static class InterfaceToDataBaseUserMethods
    {
        /// <summary>
        /// Checks if user with user name equal to UserName exists in database and is Active or Created.
        /// </summary>
        /// <param name="UserName">String with user name that we want to check.</param>
        /// <returns>True if exists, false otherwise.</returns>
        public static bool UserExists(string UserName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates User data object from the user with specified name in the database.
        /// </summary>
        /// <param name="UserName">Nameof the user we want to get data from.</param>
        /// <returns>User data object if user exists, null otherwise.</returns>
        public static User GetUserData(string UserName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds new user to database created from the User data object
        /// </summary>
        /// <param name="NewUser">User data object for creating new user.</param>
        /// <returns>True if it could add, false otherwise.</returns>
        public static bool AddUser(User NewUser)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the state of a specified user in database.
        /// If user state is Active, sets him as Archival.
        /// If user state is Created, sets him as Active.
        /// If user state is Archival, does nothing.
        /// </summary>
        /// <param name="UserName">User name of the user we want to modify.</param>
        /// <returns>True if success, false otherwise.</returns>
        public static bool DeleteUser(string UserName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to log in using specified Username and password.
        /// Checks Active and Created users.
        /// If the state is Created changes state to Active.
        /// </summary>
        /// <param name="Username">Username to be checked.</param>
        /// <param name="Password">Password to be checked.</param>
        /// <returns>True if succeded. False otherwise.</returns>
        public static bool LogIn(string Username, SecureString Password)
        {
            throw new NotImplementedException();
        }

    }
}
