<img src="https://www.xeneta.com/hubfs/Xeneta%20Logo%202017/xeneta_logo_dark.png" alt="AutoMapper">

### Xeneta Automation Project

Test Automation Engineer - technical task.

**Details:**
We would like you to create automated test cases for pages at our public website as it shares some of the features with our main product. 
The pages to use for the task:
* https://www.xeneta.com/demo
* https://www.xeneta.com/careers

**Tool/technology**

* C#
* Selenuim
* NUnit framework

### How do I get started?

You need to have .NET code version 2.2 or higher installed. You can download it [here](https://dotnet.microsoft.com/download)


### How do I run the project

In Command prompt or terminal, you need to be in the Xeneta.Tests directory.
This can be achieved by using  ```cd {path\to\Xeneta.Tests}```

Type the following: 
```
dotnet test --logger trx
```

### List of functional checks I would perform on the above pages

**Demo**
* Can I interact with the three circles and does the correct icon dispaly
* Can I interact with the bottom buttons
* Can I interact with the popups
* Does theups have validation such as a maximum of 10 characters, numbers(0-9), letters(a-z, A-z), special characters (only underscore, period, hyphen allowed) and it cannot be left blank.
* Boundry tests with textboxes
* Security Testing on the popups such as XXS (OWASP)

**Careers**
* Does the company values section tabs work as expected and contains relevant content.
* Is the global tribe clickable and ensure that you can use the visit link or the images. It should take you to the correct page.
* Are there roles and can I expand the roles and read and interact with the links

### Test cases to automate from the above list
**Demo**
- Icons on buttons are correct. 
- Can I click on the buttons below the round icons and does a popup appear.
- Can I interact with the pop up
- Negative testing on popups

**Careers**
- Can I interact with the four tabs 
- Can I interact with the current open roles and does the link redirect to the correct page.
- Can I interact with global tribe section. Does the view do what it states (Navigate)

### Issues found during automation testing
11/11/2020 : https://www.xeneta.com/demo popup buttons does not work.

***Error Message:*** ``` OpenQA.Selenium.ElementClickInterceptedException : element click intercepted: Element <a class="popup-btn" href="#form-popup-1" rel="modal:open">...</a> is not clickable at point ``` This will also affect the "Get Demo" in the header section.
