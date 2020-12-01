# Project Organization

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Project Organization](#project-organization)
  - [How to choose the best project layout?](#how-to-choose-the-best-project-layout)
  - [How to break down a complex process?](#how-to-break-down-a-complex-process)
      - [Handling Data](#handling-data)
  - [How to reuse parts of a project?](#how-to-reuse-parts-of-a-project)
  - [How to manage versions of the same project?](#how-to-manage-versions-of-the-same-project)
  - [How to prevent and solve exceptions?](#how-to-prevent-and-solve-exceptions)
  - [Best Practices](#best-practices)

<!-- /code_chunk_output -->

## How to choose the best project layout?
| Sequence | Flowchart | State Machine |
| -------- | --------- | ------------- |
| used when there's clear succession of steps, without too many conditions | used when you have a complex flow with several conditions, it is visually much easier to understand and follow | an abstract machine consisting of a finite number of pre-defined states and transitions between these states |
| used when nest workflows and the high-level logic is handled through flowcharts or state machines | used when you need a flow that runs continuously or that terminates only in several conditions | can be used with a finite number of clear and stable states to go through |
| Easy to understand and follow, having a top to bottom approach | easy to understand, as it is similar to logic diagrams in software computing | van be used for continuous workflows that are more complex. Transitions between states can be easily defined and offer flexibility |
| great for simple logic, like searching for an item on the internet | can be used for continuous workflows | Can accommodate processes that are more complex and cannot be captured by simple loops and if statements. Easier to cover all the possible cases/transitions with state machines |
| Nesting too many conditions in the same sequence makes the process hard to read | can be used only as the general workflow (with sequences nested inside) | Longer development time due to their complexity: splitting process into logical "states", figuring out transitions and so on |
| not suitable for continuous flows | Not used for individual parts of projects (nested inside other workflows) | They should only define the skeleton of the project |

## How to break down a complex process?
Breaking down a process in smaller workflows ensures speed of development and reliability, by allowing independent testing of components. There are multiple ways the workflows can be split and at least 3 factors should be considered:
1. The application being automated
2. The purpose of a certain operation (login, processing, reading a document using OCR, filling a template)
3. The length of each workflow

#### Handling Data
Having multiple workflows require Arguments, since variables only exists within a workflow.

Arguments are very similar to variables - they store data dynamically, they have the same data types and they support the same methods. The main difference in the *Direction* property signifying the direction from/to which the data is passed. Possible options are:
- In - if we want to use the value of the argument inside the invoked workflow
- Out - if we want to pass the argument outside the invoked workflow
- In/Out - if we want to pass a variable from the parent workflow to invoked workflow, modify it in invoked workflow and then pass it on back to the parent folder

When 'Extract as Workflow' option is used, Variables are automatically turned into Arguments. Use 'Import Arguments' the first time you invoked the workflow to get all the available arguemnts. Make sure you instantiate the arguments with the corresponding values of the variables using the arguements panel.

When using arguments, it is good practice to use the direction when nameing arguments. Ex: `in_ArgumentName`, `out_ArgumentName`, `io_ArgumentName`

## How to reuse parts of a project?
Extracting workflows and reuing them across an automation project is a good habit for keeping a project organized, readable and sustainable. There are also cases in which workflows can be reused in different projects. Consider the sequence of logging into an app, this can be reused anywhere.

Storing and reuing components in separate projects is done through the use of process libraries. A process library is a package that contains multiple reusable components, which consist of one or more workflows that act as individual activities. Libraries are saved as nupkg files, and then installed in different workflows using the Package Manageer.

Ideally, after the architect or the developer has separated the projects into sections, she or he will decide what section of the project cna be reused. As a general practice, the graphical interaction with an application should be a reusable component because the processing of the data should not depend on how the data was obtained.

## How to manage versions of the same project?
Source control systems are used to manage different versions of a project. Through the Team page in the backstage view, Studio supports the following control systems:
**Git**
- With git you can:
  - Clone remote repo
  - Add a project
  - Commit and Push
  - Copy a project to git
  - Create and manage branches
  - Solve conflicts with File Diff option

**TFS**
- The following versions are supported
  - 2012
  - 2013
  - 2015
  - Express 2012
  - Express 2013
  - Express 2015
- Firstly, you need to setup TFS in Studio
- Then you can open a project or add a new projcet to the TFS

**SVN**
- With SVN you can:
  - Open a project from SVN
  - Add a project to SVN

## How to prevent and solve exceptions?
It is common for automation projects to encounter events that interrupt with the project execution. Some of these are identified in the development and testing phases, and handling mechanisms are implemented.

A good project design will include ways of recognizing and identifying the exception, and also patterns of action that are executed only when exceptions are caught. These can be simply stopping the execution, or explicit actions executed automatically wihtin the workflow.

Predicting and teating exceptions can be done in 2 ways:
1. At activity level using Try/Catch blocks or Retry Scope
2. At global level using the Global Exception Handler

It is important to be able to choose the correct type of exception, as the information will be used at a high level later in the development to make other decisions.
- Application Exception
  - Describes an error rooted in a technical issue
  - Important to have good naming conventions for activites and workflows
    - This will help with tracking the activity that caused to exception
- Business Exception
  - Describes an error rooted int he fact that certain data which the automation project depends on is incomplete, missing, outside of set boundaries, or does not pass other data validation criteria
  - Use for business logic input validation
  - The text in the exception should contain enough information for a human user to understand what happened and waht actions need to be taken

## Best Practices
Main points to follow when aiming for a good project organization
1. Analyzing the process thoroughly, identifying the requirements and planning how the solution should look like before starting the actual development
2. Breaking the process into smaller workflows for a better understanding of the code, independent testing and reusability. This can also impact the effectiveness, as different team members can work on different workflows
3. Grouping the workflows of your project into different folders based on the target application
4. Keeping a consistent naming convention across the project
5. Using the right type of argument (in/out/inout) when invoking a workflow absed on the direction of information. For naming, use CamelCase with the direction as a prefix
6. Handling sensitive data responsibility: no credentials should be stored in the workflow directly, but rather loaded from safter places like local Windows Credential Store or Orchestrator assets and used with the Get Secure Credentials, Get Credentials, and Type Secure Text activities
7. Using Try/Catch blocks to predict and handle exceptions. At the same time, remember that simply using Try/Catch will only identify the error, not solve it. Thus, make sure you develop error handling mechanisms and integrate them
8. Using Global Exception Handler for situations that are global and/or less probable to happen 
9. Using libraries for creating and storing reusable components for your projects
10. Adding annotations to your workflows to clarify the purpose of each workflow
11. Using logs in production to get relevant information regarding critical moments or anytime specific data is needed