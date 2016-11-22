using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class InterfaceToDataBaseOtherMethods
    {

        SOSMEntities context;

        public InterfaceToDataBaseOtherMethods()
        {
            context = new SOSMEntities();
        }
        /// <summary>
        /// Gets Welcome Message from database.
        /// </summary>
        /// <returns>WelcomeMessage</returns>
        public async Task<string> GetWelcomeMessage()
        {
                var message = await context.Other.FirstAsync();
                return message.Welcome_message;
        }

        /// <summary>
        /// Sets Welcome Message in database.
        /// </summary>
        /// <param name="newMessage">A new message.</param>
        /// <returns>True if succeded, false otherwise.</returns>
        public async Task<bool> SetWelcomeMessage(string newMessage)
        {
            var message = await context.Other.FirstOrDefaultAsync();
            if (message == null)
            {
                Other dbOther = new Other();
                dbOther.Welcome_message = newMessage;
                context.Other.Add(dbOther);
                await context.SaveChangesAsync();
            }
            else
            {
                message.Welcome_message = newMessage;
                context.Entry(message).Property(e => e.Welcome_message).IsModified = true;
                await context.SaveChangesAsync();
            }
            return true;
        }

        /// <summary>
        /// Gets Contact Info from database.
        /// </summary>
        /// <returns>ContactInfo</returns>
        public async Task<string> GetContactInfo()
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
