# Introduction to UiPath

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Introduction to UiPath](#introduction-to-uipath)
  - [About UiPath](#about-uipath)
    - [UiPath Methodology and Products](#uipath-methodology-and-products)
    - [UiPath Suite Architecture](#uipath-suite-architecture)
  - [Robots and Their Types](#robots-and-their-types)
    - [Introduction to Robots](#introduction-to-robots)
    - [Types of Robots](#types-of-robots)
    - [Attended Robots](#attended-robots)
    - [Unattended Robots](#unattended-robots)
  - [Studio Overview](#studio-overview)
    - [StudioX](#studiox)
    - [Features of Studio](#features-of-studio)
  - [Orchestrator](#orchestrator)
    - [Primary Functions of Orchestrator](#primary-functions-of-orchestrator)
  - [UiPath Studio UI](#uipath-studio-ui)
    - [Keyboard Shortcuts](#keyboard-shortcuts)
    - [UiPath Activites](#uipath-activites)
    - [Activites Packages](#activites-packages)
    - [Adding reusable components to automatio projects](#adding-reusable-components-to-automatio-projects)
    - [Automation Debugging](#automation-debugging)
  - [UiPath Activities Guide](#uipath-activities-guide)

<!-- /code_chunk_output -->

## About UiPath
### UiPath Methodology and Products
**Discover**: discover automation opportunities powered by AI
  - Automation Hub
  - Process Mining
  - Task Capture
  - Task Mining

**Build**: build automations quickly
- StudioX
- Studio
- Studio Pro

**Manage**: Manage automation at enterprise scale
- Automation Cloud
- Orchestrator
- AI Fabric
- Test Suite

**Run**: run automations through robots
- Attended robotes
- Unattended robots
- AI robots
- Test robots

**Engage**: engage people and robots
- Action Center
- Assistant
- Chatbots

**Measure**: measure performance
- Insights

### UiPath Suite Architecture
![UiPath](./images/UiPath/UiPathSuiteArchitecture.PNG)

## Robots and Their Types
### Introduction to Robots
Robots are UiPath's execution agents that enable the user to run processes developed in Studio
- Mimic human actions
- Perform actions on applications, files, and data
- Perofrm complex calculations
- Work on predeined rules for decision making
- Are non-invasive and can work 24/7
- Improve process efficiency & saves time

### Types of Robots
In UiPath, there are 2 types:
![Robots](./images/UiPath/Robots.png)

### Attended Robots
- What do they do?
  - Collaborate with human worker for small and repetitive tasks
- Where do they run?
  - On the same machine with the user performs the day-to-day tasks
- How do they work?
  - Triggered by users or specific user events

### Unattended Robots
 - What do they do?
  - Run long processes or automations without human interaction
- Where do they run?
  - Any machine connected to Orchestrator
- How do they work?
  - Controlled through orchestrator

## Studio Overview
Studio is used to develop Robots
![UiPathStudio](./images/UiPath/UiPathStudio.png)

### StudioX
Offers:
1. Complete solution for businesses to automate applications
2. Seamless integration with Microsoft Office applications (such as MS Excel)
3. Real-time graphic representation of automation project in Designed panel

### Features of Studio
**Productivity**: 
- drag and drop activities
- manage dependencies

**Code Quality**
- Workflow analyzer
- create custom rules
- validate

**Extensibility**
- Project template
- browser extensions

**Version Control**
- Gut, TFS, SVN integration
- File Diff and Compare Changes

**Debugging**
- Breakpoints
- Call Stack, immediate, Locals, Watch
- Test activity and create test bench

**Reusability**
- Libraries
- Custom Templates
  
## Orchestrator
Orchestrator is the heart of automation management and is used to publish and execute the automation workflows developed in Studio
![Orchestrator](../images/UiPath/orchestrator.png)

### Primary Functions of Orchestrator
- Serving as the control room
- Monitoring the robots remotely
- Ensuring correct delivery of package to the robots
- Managing the queue
- Scheduling of robots
- Triggering the robots

## UiPath Studio UI
### Keyboard Shortcuts
![sc1](../images/UiPath/sc1.png)
![sc2](../images/UiPath/sc2.png)
![sc3](../images/UiPath/sc3.png)
![sc4](../images/UiPath/sc4.png)
![sc5](../images/UiPath/sc5.png)

### UiPath Activites
- Part of the UiPath studio application
- Help create a clear and cmooth automatio process
- Multiple activietes needed to create a workflow
- Vary in their complexities
- Integrated into packages
- Mangaed with the help of feeds

### Activites Packages
A bundle of activites that can help automate a certain application, a category of apps, or use certain technologies in automations. UiPath Studio includes several activity packs by default along with these default process dependencies:
**System Actvites**
- manipulates data tables by adding or extracting information
**Mail Activites**
- automates any mail related tasks and covers various protocols: IMAP, POP3, SMTP
**Excel Acvtivites**
- automates all aspects of Excel
**Ui Automation Activites**
- contains basic activities for creating automation projects

### Adding reusable components to automatio projects
1. open existing/create new project
2. All Packages -> pick library feed -> install package
3. Add package to project bny selecting OK
4. Activity in Activites panel

### Automation Debugging
Process of identifying and removing the errors which prevent the project from functioning correctly. In Studio, debugging is:
- useful for verifying the data that each activity gets during execution
- done at activity, file, and project level
- done using options available in debug ribbon
- used for finding and locating problems easily in complex workflows

## UiPath Activities Guide
**System**
- Contains all the basic activities used for creating automation project and enables the robots to:
  - manipulate data
  - directly interact with directories and files

**Ui Automation**
- Contains all the basic activities used for creating automation project and enables the robots to:
  - simulate human interaction
  - perform image and text automation
  - create UI behavio-based triggers
  - perform browser interaction

**Citrix**
- Enables users to easily automate processes for on-demand management and maintenance of Citrix virtual machines through following:
  - A new server from a template
  - options to take screenshots of virtual machines
  - reboot, power on/off

**Cognitive**
- Contains activites that help users to user Google's, IBM's, Stanford's and Microsoft's APIs and enables the robots to:
  - Translate text from one language to another
  - Extract relevant information from a given piece of text

**Credentials**
- Contains activites that work with Windows Credential Manager and enables users to:
  - Add and delete credntials for specific Microsoft authentication packages
  - Retrieve credentials

**Excel**
- Contains activites that help users to automate all aspects of Microsoft Excel and enables the user to:
  - Read information from a cell, columns, rows
  - write to other spreadsheets
  - Execute macros
  - Sort data and append additional information

**Form**
- Contains activities that enable the user to
  - Create custome input forms (to collect data from human users)
  - Display custom callout messages

**Mail**
- Contains activites that facilitate the automatio of any mail-related tasks and enables the user to
  - Send, receive, delete emails
  - send attachments

**PDF**
- Contains activites designed to extract data from PDF files and store it into string variables and enables the user to
  - Extract data from entire document or range of pages
  - Use OCR-based activities to extract data from scanned documents

**Terminal**
- Contains activites designed to connect to a terminal and efficiently work wihtin it & enables the user to:
  - Retrieve text, fields
  - Screen positions, send keys, text
  - Wait for certain text or fields to appear as triggers
  - Connect to a specific environment using terminal session activity

**Web**
- Contains activities that enable the user to
  - Perform requests using specific protocols to any web APIs that support them
  - manipulate XML and JSON files
  - automate various software components with less effort
  - 
**Additional Services:**
![act1](../images/UiPath/act1.png)
![act2](../images/UiPath/act2.png)
![act3](../images/UiPath/act3.png)
![act4](../images/UiPath/act4.png)
