using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace MailSenderApplication
{
    class Program
    {// Console application for taking users input 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Gmail address:");
            string senderEmail = Console.ReadLine();

            Console.WriteLine("Enter your Gmail password:");
            string password = Console.ReadLine();

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, password),
                EnableSsl = true,
            };

            try
            {
                using (var message = new MailMessage(senderEmail, "vikas.singh@krishmark.com"))
                {
                    Console.WriteLine("Enter email subject:");
                    message.Subject = Console.ReadLine();

                    Console.WriteLine("Enter email body:");
                    message.Body = Console.ReadLine();

                    Console.WriteLine("Enter file path (e.g., C:\\Path\\To\\Your\\File.xlsx):");
                    string filePath = Console.ReadLine();
                    Attachment attachment = new Attachment(filePath, MediaTypeNames.Application.Octet);
                    message.Attachments.Add(attachment);

                    smtpClient.Send(message);
                    Console.WriteLine("Email sent successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}


//using System;
//using System.Net;
//using System.Net.Mail;
//using System.Net.Mime;

//namespace MailSenderApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var smtpClient = new SmtpClient("smtp.gmail.com")
//            {
//                Port = 587,
//                Credentials = new NetworkCredential("singhviba19et@student.mes.ac.in", "fqaj pbuu vfof atpt"),
//                EnableSsl = true,
//            };

//            try
//            {
//                using (var message = new MailMessage("singhviba19et@student.mes.ac.in", "vikas.singh@krishmark.com"))
//                {
//                    message.Subject = "add your subject";
//                    message.Body = "Add your body ";

//                    // Attach the PDF file
//                    string filePath = @"C:\Users\C4R2Y32-PC\Downloads\CBcommunication.xlsx";
//                    Attachment attachment = new Attachment(filePath, MediaTypeNames.Application.Pdf);
//                    message.Attachments.Add(attachment);

//                    smtpClient.Send(message);
//                    Console.WriteLine("Email sent successfully.");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Failed to send email: {ex.Message}");
//            }

//            Console.ReadLine();
//        }
//    }
//}














//using System;
//using System.Net;
//using System.Net.Mail;

//namespace MailSenderApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var smtpClient = new SmtpClient("smtp.gmail.com")
//            {
//                Port = 587,
//                Credentials = new NetworkCredential("singhviba19et@student.mes.ac.in", "fqaj pbuu vfof atpt"),
//                EnableSsl = true,
//            };

//            try
//            {
//                smtpClient.Send("singhviba19et@student.mes.ac.in", "vikas.singh@krishmark.com", "subject", "body");
//                //smtpClient.Send("your-email@domain.com", "recipient-email@domain.com", "subject", "body");
//                Console.WriteLine("Email sent successfully.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Failed to send email: {ex.Message}");
//            }

//            Console.ReadLine();
//        }
//    }
//}

//setx SMTP_USERNAME "vikas.singh@krishmark.com"
//setx SMTP_PASSWORD "Relax@123"


//using System;
//using System.Net;
//using System.Net.Mail;

//namespace MailSenderApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var smtpClient = new SmtpClient("smtp.gmail.com")
//            {
//                Port = 587,
//                Credentials = new NetworkCredential("vikas.singh@krishmark.com", "Relax@123"),
//                EnableSsl = true,
//            };

//            smtpClient.Send("vikas.singh@krishmark.com", "vikash.khatri@krishmark.com", "subject", "body");
//            //Console.WriteLine("Hello World!");
//            Console.ReadLine();
//        }
//    }
//}
