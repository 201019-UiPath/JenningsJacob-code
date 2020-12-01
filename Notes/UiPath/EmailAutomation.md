# Email Automation

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Email Automation](#email-automation)
  - [Interacting with Emails](#interacting-with-emails)
      - [Email Options](#email-options)
      - [Activities](#activities)
  - [Sending Emails](#sending-emails)

<!-- /code_chunk_output -->

## Interacting with Emails
From an RPA perspective, there are 2 situtations for interacting with email are:
1. Email as the input for our business process
   - Receive data in textual form
   - in subject, body, or as attachment
2. Email as the output of the process
    - most commonly used for sending status updates to human supervisors
    - also used when business or application exceptions occur

#### Email Options
`SMTP`
- short for Simple Mail Transfer Protocol
- basic protocol used for only sending messages

`POP3`
- Post Office Protocol
  - almost obsolete
  - used for reading messages

`IMAP`
- Internet Message Access Protocol
- used for receiving messages
- offers activities such as mark as read and move emails between folders

`Exchange`
- Microsoft's enterprise email solution
- offers activities:
  - sending and receiving messages
  - moving emails between folders
  - deleting emails

`Outlook`
- work with the API of the desktop application
- actions already have a context
- no need to set up servers, users, or any technical details
- designed to use already existing outlook accounts

`Generic`
- there are 2 generic email activities for saving email messages nad email attachments

#### Activities
`Get Mail`
- used for POP3, Outlook, IMAP, and Exchange
- all offer same functionality of providing email messages
- has options:
  - retrieving email from a particular folder
  - fetching only unread messages and marking them as read
  - limiting the number of incoming emails
- Need to set up server connection with server address and port
- Need user email and password
- IMAP and POP3 show validation warnings because they require connection parameters
- save as System.Net.Mail variable
  - use properties to get diffent parts of the email

## Sending Emails
`Send Email`
- used by SMTP, outlook and Exchange
- for SMTP, we need to set up connection parameters to the server
- fill out To, Subject, Body
  - use template files as txt or html doc
  - use String.Format to dynamically fill data within the template