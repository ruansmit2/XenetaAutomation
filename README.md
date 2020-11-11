<img src="https://www.xeneta.com/hubfs/Xeneta%20Logo%202017/xeneta_logo_dark.png" alt="AutoMapper">

### Xeneta Automation Project

Test Automation Engineer - technical task.

**Detals:**
We would like you to create automated test cases for pages at our public website as it shares some of the features with our main product. Task
details are described below.
The pages to use for the task:
* https://www.xeneta.com/demo
* https://www.xeneta.com/careers

**Tool/technology**

* C#
* Selenuim
* NUnit framework

### How do I get started?

You need to have .NET code version 2.2 or higher. You can download it [here](https://dotnet.microsoft.com/download)


### How do I run the project

In Command prompt or terminal, you need to be in the Xeneta.Tests directory.
This can be achieved by unsinfg  ```cd {path\to\Xeneta.Tests}```

Type the following: 
```
dotnet test --logger trx
```

### List of functional checks I would perform on the above pages

**Demo**
* Can I interact with the three circles and is the icon correct
* Can I interact with the bottom buttons
* Can I interact with the pop ups
* Can does the popups have validation such as a maximum of 10 characters, numbers(0-9), letters(a-z, A-z), special characters (only underscore, period, hyphen allowed) and it cannot be left blank.
* Boundry tests with textboxes
* Security Testing on the popups such as XXS (OWASP)

**Careers**
* Values section tabs work as expected and contains relivant content.
* Global tribe is clickable and that you can use the visit link or the images. It should take you to the correct page
* Is there roles and can I expand the roles and read and interact with the links

### Few test cases to automate from the above list
**Demo**
- Icons on buttons are correct. 
- Can I click on the buttons below the round icons and does a popup show
- Can I interact with the pop up

**Careers**
- Can I interact with the four tabs 
- Can I interact with the current open roles
* Can I interact with global tribe section. Does the view do what it states (Navigate)
