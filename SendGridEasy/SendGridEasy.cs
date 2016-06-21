using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendGridEasy
{
    public class SendGridEasy
    {
        public SendGridEasy()
        {
            
        }

        //1 recipient constructor params:
        //string of from email (email + name)
        //string of recipient email
        //string of subject
        //string of message body
        public SendGridEasy(string sgFromEmail, string sgToEmail, string sgSubject, string sgMessageBody)
        {
            
        }

        //multiple recipient constructor params:
        //string of from email (email + name)
        //string[] of recipient emails
        //string of subject
        //string of message body
        public SendGridEasy(string sgFromEmail, string[] sgToEmail, string sgSubject, string sgMessageBody)
        {

        }


        private void sgConfig()
        {
            //configure sendgrid credentials here
        }

        private void sgSendMessage()
        {
            
        }
    }
}