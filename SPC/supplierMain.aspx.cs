using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SPC
{
    public partial class supplierMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Req_Click(object sender, EventArgs e)
        {
            try
            {
                var from = "selithasasmitha98@gmail.com";
                var to = "selithasasmitha@gmail.com";
                const string Password = "selitha7096260";
                string mail_message = "Item Code Number :" + txt_itm.Text + "\n";
                mail_message += "Tender Number :" + txt_tender.Text + "\n";
                mail_message += "Email :" + txt_email.Text + "\n";
                mail_message += "Phone :" + txt_phone.Text + "\n";
                mail_message += "Company Name :" + txt_com.Text + "\n";
                mail_message += "Message :" + txt_msg.Text + "\n";

                var smtp = new SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, Password);
                    smtp.Timeout = 20000;

                }

                smtp.Send(from, to, mail_message);

                txt_itm.Text = "";
                txt_tender.Text = "";
                txt_email.Text = "";
                txt_phone.Text = "";
                txt_com.Text = "";
                txt_msg.Text = "";

            }
            catch(Exception)
            {

            }
        }
    }
}