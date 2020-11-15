# Skateshop

.NET Framework Web API (SkateshopApi)

Implementing the web API with the following principles/patterns:

REST architectural design, RESTful web API (CRUD operations through HTTP verbs)
Clean Code
SOA (Service Oriented Architecture)
Dependency Injection

Technologies used:

.NET Framework 4.7 with C#
Autofac

Angular 11 (SkateshopUI)

Instructions to implement and run the UI:
1. Download and install :
  node.js
  npm install -g typescript
  npm install -g @angular/cli
  npm install bootstrap
  npm install jquery
  npm install popper.jsng g service state
2. Run the UI
  ng serve
  
Instructions to play with the Skateshop webpage:
Prerequisites (UI is running : ng serve,
			   Api is running: Ctrl + F5 Visual Studio)

1.  Click Login Button in NavBar
2.  Provide a username and a password
3.a Click "Submit" Button (Validates the user if:
	3.a.1 she/he is already Logged In -> Routes to a Welcome Page
	3.a.2 she/he is registered in the website. -> Shoes an Error Message
	
3.b Click "Cancel" Button and expect to return in Home Page

User is not allowed to type the below characters when she/he provides username or password:
- `\`: backslash
- `/`: slash
- `,`: comma
- `.`: dot
- `^`: caret
