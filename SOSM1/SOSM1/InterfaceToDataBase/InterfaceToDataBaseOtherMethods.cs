using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public static class InterfaceToDataBaseOtherMethods
    {
        /// <summary>
        /// Gets Welcome Message from database.
        /// </summary>
        /// <returns>WelcomeMessage</returns>
        public static string GetWelcomeMessage()
        {
            using (var context = new SOSMEntities())
            {
                var message = context.Other.First();
                return message.Welcome_message;
            }
        }

        /// <summary>
        /// Sets Welcome Message in database.
        /// </summary>
        /// <param name="newMessage">A new message.</param>
        /// <returns>True if succeded, false otherwise.</returns>
        public static bool SetWelcomeMessage(string newMessage)
        {
            using (var context = new SOSMEntities())
            {
                var message = context.Other.FirstOrDefault();
                if (message == null)
                {
                    Other dbOther = new Other();
                    dbOther.Welcome_message = newMessage;
                    context.Other.Add(dbOther);
                    context.SaveChanges();
                }
                else
                {
                    message.Welcome_message = newMessage;
                    context.Entry(message).Property(e => e.Welcome_message).IsModified = true;
                    context.SaveChanges();
                }
                return true;
            }
        }

        /// <summary>
        /// Gets Contact Info from database.
        /// </summary>
        /// <returns>ContactInfo</returns>
        public static string GetContactInfo()
        {
            using (var context = new SOSMEntities())
            {
                var message = context.Other.First();
                return message.Contact_info;
            }
        }

        /// <summary>
        /// Sets Contact Info in database.
        /// </summary>
        /// <param name="newMessage">A new message.</param>
        /// <returns>True if succeded, false otherwise.</returns>
        public static bool SetContactInfo(string newContactInfo)
        {
            using (var context = new SOSMEntities())
            {
                var message = context.Other.FirstOrDefault();
                if (message == null)
                {
                    Other dbOther = new Other();
                    dbOther.Contact_info = newContactInfo;
                    context.Other.Add(dbOther);
                    context.SaveChanges();
                }
                else
                {
                    message.Contact_info = newContactInfo;
                    context.Entry(message).Property(e => e.Contact_info).IsModified = true;
                    context.SaveChanges();
                }
                return true;
            }
        }
    }
}
