# Welcome to my Email Service Application! 

This application is used to send emails using an ASP.NET Core dependency injection system. It allows developers to create custom controllers, Endpoints API Explorer, Swagger/OpenAPI, custom (scoped) instance of an EmailService, middleware for HTTPS redirection and authorization, and maps controllers. 

At the heart of the system is the IEmailService interface, which defines the methods for sending an email. This is implemented by the EmailService class, which takes an IConfiguration parameter to set up the SMTP server and send emails. The SendEmail method creates a new MimeMessage, sets the “From”, “To”, “Subject”, and “Body” of the email, and uses the IConfiguration parameter to set up a new SmtpClient in order to send the email to its destination. Once done, the SmtpClient is disconnected and a “NotImplementedException” is thrown.

To create an email I use the EmailDto class. This class contains three properties, "To", "Subject", and "Body", and also provides a constructor for the user to input the To address, Subject and Body for the message. 
## Authors

- [@itsmemarius](https://www.github.com/itsmemarius)

