# Variables and Arguments

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Variables and Arguments](#variables-and-arguments)
  - [Variables and Their Types](#variables-and-their-types)
      - [Introduction to Variables](#introduction-to-variables)
      - [Properties of Variables](#properties-of-variables)
      - [Best Practices for Naming Variables](#best-practices-for-naming-variables)
      - [Types of Variables](#types-of-variables)
      - [Array vs. String](#array-vs-string)
  - [Variables Panel](#variables-panel)
      - [Managing Variables](#managing-variables)
  - [Scope of Variables](#scope-of-variables)
  - [Arguments](#arguments)
      - [Properties of Arguments](#properties-of-arguments)
  - [Arguments Panel](#arguments-panel)
      - [Managing Arguments](#managing-arguments)
  - [Argument Directions](#argument-directions)
  - [Arguments vs. Variables](#arguments-vs-variables)
  - [Assets](#assets)
      - [What are Assets?](#what-are-assets)
      - [Business Scenarios for Assest](#business-scenarios-for-assest)
      - [How are assets created and used](#how-are-assets-created-and-used)
  - [Queues](#queues)
      - [What are queues?](#what-are-queues)
      - [Business Scenarios for Queues](#business-scenarios-for-queues)
      - [Working with queues](#working-with-queues)
      - [Activities](#activities)

<!-- /code_chunk_output -->

## Variables and Their Types
#### Introduction to Variables
Variables are containers that are used to store multiple types of data.
A Variable:
- makes it easier to label and store data which can later be used throughout the automation process
- has an initial value which may change during the program through external input, data manipulation or passing from one activity to another
- is like a box that stores data

#### Properties of Variables
Users can configure variables through their properties:
- **Name**: name of variable
- **Type**: kind of data that the variable is intended to store. Declared when cariable is created
- **Value**: data that a variable holds (changes throughout the proccess)
- **Scope**: Designates parts of program that cna use a variable (local, global)

#### Best Practices for Naming Variables
A variable's name should be meaninful & hint towards the information it stores. While naming any variable, the user should:
- Use clear and meaningful names
- Use Camel case
- Assign names in a consistent manner
- keep variables names descriptive yet short

#### Types of Variables
- `String`
  - Store sequence of text
- `Boolean`
  - store true and false
  - used for control statements
- `Number`
  - stores numeric values
- `Data and Time`
  - stores information about any data and time
- `DataTable`
  - stores tabular data in rows and columns and may hold large pieces of dat and act as a database
- `GenericValue`
  - can store any type of data
  - specific to UiPath
  - used to perform all the operations that can be performed through other data types
- `QueueItem`
  - stores an item extracted from a queue (container of items)
  - used to input extracted items in other processes
- `Array`
  - collection which stores multiple elements of the same data type

#### Array vs. String
|Array | String |
| ---  | ------ |
|A sequential colleciton of elements of similar data types | sequence of single characters represented as a single data type |
| elements are stored contigously in increasing memory locations | stored in any manner in memory locations |
| **special variable that can hold more than one value at a time** | **can only hold character data** |
| it is mutable | immutable |
| length is predefined | size not predefined |

## Variables Panel
#### Managing Variables
In Studio, a user cna create varibales from the Variables Panel by clicking 'Create Variable'. Steps:
1. Define a name
2. Choose tpye from drop-down list
3. Choose scope
4. Sepcify a default value

## Scope of Variables
The scope detemines the containers in which the variable is available.

A variable declared in any specific activity is avaible only for the scope of that activity

The scope is chose from a list of sequences in **Scope** drop-down field while creating a variable. The variable is available in the selected container.

A variable declared for a parent activity is available in the entire workflow.

A varibale declared for a specific activity is available only in that activity
## Arguments
Arguments are used to pass data from one workflow to another
- Store data dynamically
- Enable users to reuse projects
- Userful in automation projects with multiple workflows

#### Properties of Arguments
Users can configure arguments through their properties:
- **Name**: name of argument
- **Type**: kind of data that the argument is intended to store
- **Value**: data that a argument holds
- **Direction**: Direction from/to whichh the data is passed

## Arguments Panel
#### Managing Arguments
In Studio, a user cna create arguments from the Arguments Panel by clicking 'Create Argument'. Steps:
1. Define a name
2. Set the direction
3. Specify data type
4. Sepcify a default value

## Argument Directions
Specify the direction from/to which the data is passed

**In**
- argument can only be used within the given workflow

**Out**
- Argument cna be used to pass data outside the given workflow

**In/Out**
- Argument can be used both within and outside the given workflow
  
## Arguments vs. Variables
| Arguments | Variables |
| --------- | --------- |
|stores data and passes it between workflows | stores data and passes it between activities |
| canb be used across multiple workflows (direction to be defined) | limited to the workflow in which it was defined |
| created and modified through Arguments Panel | created and modified through Variables Panel |
| defined by properties: `Name`, `Direction`, `Type`, `Default Value` | defined by properties: `Name`, `Scope`, `Type`, `Default Value` |
| if user does not assign a value to an argument, it does not have any default value | automatically assigned a default value |

## Assets
#### What are Assets?
They are shared variables or credentials that are stored in the Orchestrator and used by the robots in different automation projects. They can be considered a data repository that the robts can access when running processses, based on clear instructions.

There are 4 types of assets:
1. Text: equivalent of string
2. Bool: true or false
3. Integer: whole numbers
4. Credential: contains usernames and passwords that the robot required to executre particular processes, such as login details

#### Business Scenarios for Assest
- When data doesn't change from one execution of a process to another
  - it doesn't make sense to assign it every time from the parameters tab
  - data that may change shouldn't be stored in the workflow
- Whenever robots need credentials to access applications in an automation scenario
  - credentials are encrypted with AES 256 algorithm

#### How are assets created and used
In **Orchestrator**
- Assets can be created from the dedicated area
- name and data type have to be provioded, can be configured as:
  - Single Value - can be accessed and used by all robots
  - Value Per Robot - each value provided can be accessed only by the indicated robot
- Assets can be modified or deleted from the same menu

In **Studio**
- For creadentias, the 'Get Credential' activity has to be used
- For all other types of assets, the 'Get Asset' activity has to be used

## Queues
#### What are queues?
- Containers that can hold an unlimited number of items
- In Orchestrator, it will store items and allow their distiribution individually to robots for processing and monitoring the status of the items based on the process outcomes
- advantages:
  - crentralized depository of work items
  - reporting capabilities at individual item level, as well as queue level
  - effectiveness of item distribution process - anytime a robot becomes available, the queu item in line is dispatched
  - unitary logic of item distribution - FIFO

#### Business Scenarios for Queues
- Item in queue known as transaction
  - they are indivisible units of work
- useful for large automations, where number of items is high and the distribution process may become problematic
- Ex:
  - New customer enrollment forms for a retail company
  - Complaint process of a worldwide retailer

#### Working with queues
- Queues can be created with Orchestrator
  - will initially be empty, but there are activities in UiPath Studio to make the robots populate queues
- You can set the **max number of retries** (number of times you want a queue item to be retried) and **Unique Reference** field (yes -> transaction references to be unique)
  - these settings cannot be modified once set
- Very important for Dispatcher and Performer Model, in which 2 main stages of a process invovling queues are separated:
  - the stage in which data is taken and fed into a queue in orchestrator, from where it can be taken and processed by hte robots. Called the *Dispatcher*
  - the stage in which the data is processed, called *Perfomer*

#### Activities
`Add Queue Item`
- the robot will send an item to the designated Queue and will configure the time frame and the other parameters

`Add Transaction Item`
- Robot adds an item to the queue and starts the transaction with the status 'in progress'
- the queue item cannot be sent for processing until the robot finalizes this activity and updates the status

`Get Transaction Item`
- Gets an item from the queue to process it, setting the status to 'in progress'

`Postpone Transaction Item`
- Adds time parameters between which a transaction must be processed

`Set Transaction Progress`
- Enables the create of custom progress statusses for in progress transactions
- useful for transactions that have a longer processing duration, and breaking down the workload will give valuable informaiton

`Set Transaction Status`
- Changes the status of the transaction item to Failed (with an Application or Business Exception) or Successful
- a transaction failed due to Application Exceptions will be retried
- a transaction failed due to Business Exceptions will not be retried
- a Queue item can have one of the following statuses:
  - New - just added to the queue with Add Queue Item (or the item was postponed or a deadline was added to it)
  - In Progress - the item was processed with the Get Transaction Item or the Add Transaction Item activity
  - Failed - the item did not meet a business or application requirement within the project
  - Successful - teh item was processed
  - Abandoned - the item remained in teh In Progress status for a long period of time (approx. 24 hrs) without being processed
  - Retried - the item failed with an application exception and was retried
  - Deleted - the item has been manually deleted from the Transactions page