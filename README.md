# ClarityEmailer
Created by Kevin Karosy, for Clarity.

I'm happy to demonstrate this project live.

## Overview
- This repository has 2 projects inside.
  - ClarityEmailer is a web app with 3 pages.
  - Emailer is capable of sending an email.
- The two projects are NOT referenced with each other.
  - The Emailer project is included for your inspection.
  - The ClarityEmailer project uses a DLL of Emailer.
- "Home page" does nothing.
- "Send Emails" page has a form to send an email.
- "View Emails" page shows a log of all email attempts.
  
## Instructions to operate
- Download the repository, and open it with Visual Studio.
- Modify appsettings.json file.
  - The "EmailerSettings" object needs an email address and password for you to send emails.
  - The "ConnectionStrings" object currently creates local databases. Change if necessary.
- Update the database, by opening the PMC (Package Manager Console) and entering the "update-database" command.
- Run the program.

## Email Testing
- The email form has a checkbox for "Email Testing".
- When activated, it will not send emails. It will pretend to fail, allowing you to see the reattempts.
- It will pretend to succeed if the email form's subject value is "Hello".
