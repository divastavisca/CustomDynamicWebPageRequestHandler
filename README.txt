This project is meant to develop a dynamic web page request handler arising on a server.

The dynamic rendering of the requested web form is assumed to handle only those web forms having an extension of ".dwps", standing for "Dynamic Web Page Script" as the script which is used as a server side scrpipt (similar to ASP)

These "dwps" scripts start with <dwps:----------------> and they have meaning only for the DWPS Parser which reads the code behind file written in C# and processes all the events at the page level to generate HTML.

The server side tags are to be converted to the corresponding universally understandable HTML tags and are to be returned to callie (Worker process of the client request).