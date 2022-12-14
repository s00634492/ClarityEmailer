using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClarityEmailer.Models;
using Emailer;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting.Internal;
using Hangfire;

namespace ClarityEmailer.Controllers
{
    public class EmailController : Controller
    {
        Emailer.Emailer emailer;
        EmailContext context;

        public EmailController(Emailer.Emailer emailer, EmailContext context)
        {
            this.emailer = emailer;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // show blank form
            return View(new EmailModel());
        }

        [HttpPost]
        public IActionResult Index(EmailModel model)
        {

            if (ModelState.IsValid)
            {
                // accept the form, try to send the email
                bool testing = !String.IsNullOrEmpty(Request.Form["EmailTesting"]);
                TempData["alert"] = "Your email is sending...";
                BackgroundJob.Enqueue(() => TrySendingEmail(model, 1, testing));

                return RedirectToAction("ViewEmails", "Email");
            }
            else
            {
                // return the invalid form
                TempData["FormError"] = true;
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult ViewEmails()
        {
            // show log of emails sent
            var emails = context.Emails
                .OrderByDescending(m => m.Id)
                .ToList();
            return View(emails);
        }

        [HttpPost]
        public IActionResult ClearEmails()
        {
            // clear records, refesh the page
            var records = context.Emails.ToList();
            foreach (var r in records)
            {
                context.Emails.Remove(r);
            }
            context.SaveChanges();
            TempData["alert"] = "Email records have been cleared.";
            return RedirectToAction("ViewEmails");
        }

        [NonAction]
        public void TrySendingEmail(EmailModel model, int attempt=1, bool testing=false)
        {
            /* 
             * Attempts to send an email.
             * Will make 3 attempts.
             * 
             * */

            // clone the given email object
            EmailModel tempModel = new EmailModel();
            tempModel.Recipient = model.Recipient;
            tempModel.Subject = model.Subject;
            tempModel.Body = model.Body;
            tempModel.Timestamp = DateTime.Now;

            try
            {
                // Email testing does not send email.
                // It pretends to.
                // It always fails, unless Subject == "Hello".
                // Toggle this feature with the form checkbox.
                if (testing)
                {
                    if (tempModel.Subject == "Hello") ;       // pretend success
                    else throw new Exception("Fake Failure"); // pretend failure
                }
                else
                {
                    emailer.SendEmail(new Email(tempModel.Recipient,tempModel.Subject,tempModel.Body));
                }
            }
            catch
            {
                // failure
                tempModel.Status = $"Fail {attempt}";
                context.Add(tempModel);
                context.SaveChanges();

                if (attempt < 3) // retry
                {
                    attempt++;
                    BackgroundJob.Schedule(
                        () => TrySendingEmail(model, attempt, testing),
                        TimeSpan.FromSeconds(5));
                }
                return;
            }
            // success
            tempModel.Status = $"Success {attempt}";
            context.Add(tempModel);
            context.SaveChanges();
        }
    }
}
