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
            var message = await context.Other.FirstOrDefaultAsync();
            if (message == null)
                return null;
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
                dbOther.Contact_info = "";
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
            var message = await context.Other.FirstOrDefaultAsync();
            if (message == null)
                return null;
            return message.Contact_info;
        }

        /// <summary>
        /// Sets Contact Info in database.
        /// </summary>
        /// <param name="newMessage">A new message.</param>
        /// <returns>True if succeded, false otherwise.</returns>
        public async Task<bool> SetContactInfo(string newContactInfo)
        {
            var message = await context.Other.FirstOrDefaultAsync();
            if (message == null)
            {
                Other dbOther = new Other();
                dbOther.Welcome_message = "";
                dbOther.Contact_info = newContactInfo;
                context.Other.Add(dbOther);
            }
            else
            {
                message.Contact_info = newContactInfo;
                context.Entry(message).Property(e => e.Contact_info).IsModified = true;
            }
            await context.SaveChangesAsync();
            return true;
        }
    }
}
