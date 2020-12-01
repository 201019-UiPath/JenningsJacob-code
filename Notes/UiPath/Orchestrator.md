# Orchestrator

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Orchestrator](#orchestrator)
  - [Introduction to Orchestrator](#introduction-to-orchestrator)
      - [Capabilities](#capabilities)
      - [Benefits of Orchestrator](#benefits-of-orchestrator)
  - [Orchestrator Key Concepts](#orchestrator-key-concepts)
  - [Robots and Environments in Orchestrator](#robots-and-environments-in-orchestrator)
      - [What is a robot](#what-is-a-robot)
      - [Types of Robots](#types-of-robots)
      - [Provisioning robots in Orchestrator](#provisioning-robots-in-orchestrator)
      - [Environments](#environments)
  - [Process Execution in Orchestrator](#process-execution-in-orchestrator)
      - [Packages](#packages)
      - [Processes](#processes)
      - [Jobs and Schedules](#jobs-and-schedules)
  - [Assets](#assets)
      - [What are assets?](#what-are-assets)
      - [How are Assets created](#how-are-assets-created)
  - [Queues](#queues)
      - [What are Queues](#what-are-queues)

<!-- /code_chunk_output -->
## Introduction to Orchestrator
Orchestrator is the component of UiPath Suite through which the automation workflows are published, assigned to robots and executed. It comes in the form of a web application that enables the managements of robots, activity packages, data to be processed, execution schedules, as well as other assets. It is ideal for large deployments of robots covering complex processes

#### Capabilities
- **Provisioning**: creates and maintains the connection with the robots
- **Deployment**: ensures teh delivery of th eworkflows for execution, either immediately or using schedules
- **Configuration**: enables the creation, configuration and maintenance of groups of robots and the execution of tasks
- **Queues**: the data that needs to be processed is broken down into indivisible operations called transactions
- **Monitoring**: keeps track of robot identification data and maintains user permissions
- **Logging**: stores and indexes the logs to an SQL database and/or ElasticSearch
- **Inter-conectivity**: acts as the centralized point of communication for 3rd party solutions or applications, and can be used for storing activity packages, libraries and other assets

#### Benefits of Orchestrator
- **Accessibility and version control**: workflows cna be published as packages and stored in Orchestrator, at version level and with developer's release notes
  - different versions can be distributed to robots for execution
  - libraries can also be published and stored in orchestrator
- **Transactional Processing**: Queues allow efficient allocation of the workload between robots, continuous execution and monitoring at transaction level
  - if certain transaction in the queue cannot be executed, it won't stop or delay the overall execution
- **Efficient Planning and Execution**: allows execution of tasks according to schedules that can accomodate various scenarios, to choose execution targets from the available robots and even create continuous execution loops even outside business hours
- **Securely storing assets**: configuration assets, credentials and data that change frequently must not be stored in the workflows
  - orchestrator provides a secure way of storing assets and distributing them to robots according to different scenarios
- **Monitoring**: Robots, processes and task execution can be monitored via Orchestrator
  - can enable quick reaction in case of nay error, and also provides the means for accurate reporting and auditing of the robot work

## Orchestrator Key Concepts
**Robot**
- execution agent that enables you to run workflows 
- can be of serveral types

**Environment**
- group of robots configured in Orchestrator
- processes can be allocated to individual robots, bu it's more effective to allocate them to environmnets\
- a robot can be part of more than one environment, provided they are in the same service

**Organization Unit**
- Entity in Orchestrator that corresponds to a business unit
- same orchestrator instance can have multiple organization units configured, each of them having separate robots, enviroments, queues, assets and so on

**Package**:
- project developed in UiPath Studio that is published to Orchestrator
- multiple versions of the same project can be stored and used

**Process**:
- a package that has been allocated to a certain environment

**Job**:
- a process that has been sent for execution to some or all of the robots in the environment

**Schedule**:
- a process that is configured for an execution that is not immediate, but according to a schedule
- mulitple configurations available

**Asset**:
- piece of data stored in Orchestrator for the use of robots
- 4 types:
  - Text: only stores strings
  - Bool: supports true or false values
  - Integer: stores only whole numbers
  - Credential: contains usernames and passwords that the robot required to execute partivular processes

**Queue**: 
- a sequence of transactions that is built in Orchestrator and then used to dispatch to robots for processing

## Robots and Environments in Orchestrator
#### What is a robot
UiPath's execution agent that enables you to run workflows built in studio. Studio comes with a robot that is triggered when the 'Run' button is clicked when a project is open. 

Provisioning robots in Orchestrator allows better package distribution capabilities, better scheduling, and enables the use of assets and queues. All these will take an implementaiton much closer to a business context.

#### Types of Robots
**Attended Robot**
- triggered by user events
- operates alongside a human
- run on same workstation
- used in Orchestrator for a centralized process deployment and logging medium

**Unattended Robot**
- run attended in virtual environments and execute any number of processes
- adds additional capabilities to attended robot such as:
  - execution, monitoring, scheduling adn providing support for queues

**Development Robot**
- has the features of an Unattended robot, but is should be used only to connect Studio to Orchestrator for development purposes

**Non-production Robot**
- Similar to unattended robots, but they should be used for development and testing purposes

According to Robot/Machine interaction, there are 2 kinds of robots:

**Standard Robot**
- works on a single machine only
- good choice when the machine on which the robot runs is known and will never change

**Floating Robot**
- Works on any machine defined in Orchestrator
- Good choice when human users wokr in shifts on the same machine or on different machines
- Good when virtial machines are being regenerated often

#### Provisioning robots in Orchestrator
- Robots must be provisioned in Orchestrator to perform jobs, together with the machines that they will be using
- machine name is mandatory for standard robots
- login credentials needed for unattended robots

Robots can be connected:
- directly from the Orchestrator Settings window
- from the command line
- or automatically enrolled

It is recommended to first try and connect the robot form the Orchestrator window. If there are issues with that, then try the Command Line.

#### Environments
- Environments: grouping of robots, that is used to deploy processes
- Dedicated tab in the Robots menu can be used to create, modify and delete environments
- Robot can be added in more than one environment, provided that they are under the same service

## Process Execution in Orchestrator
#### Packages
- Consist of one or more automation workflows published on the local machine or directly to Orchestrator
- Versions of the same package are stored automatically
- Version and release notes can be accessed anytime by selecting Processes from the menu on the left in Orchestrator, and navigating to the packages tab
- can be updated by following the same steps as for publishing, will be automatically detected

Package Versions can be active or inactive
- Active: deployed to at least an environment
- Inactive: not deployed (can be deleted)

#### Processes
- Represent the association between a package and an environment
- If the Main.xaml of the process has In, Out, or In/Out arguments, they are displayed on the parameters tab of the view processes window

#### Jobs and Schedules
Once a process is created, its execution can be triggered. There are 3 ways to do it:
1. Using Jobs (immediately)
   - A job allocated directly to certain robots will have priority over jobs allocated dynamically
   - Jobs allocated dynamically are excuted immediately when any robot in the environment becomes available
   - You have the option to set input parameters or display the output parameters if they exist as arguments in the Main.xaml file of the package
   - There are 2 options to stop a job:
     - using ***Stop Job***, that will stop it when a Should Stop Activity in the workflow is encountered
     - using ***Kill Job***, that will stop it immediately
   - Steps:
     1. navigate to Jobs from the menu on the left
     2. choose a process
     3. select the robots or you want to execute the job from the environment or allocate the job dynamically
2. Using Schedules (planned)
   - Scheduling offers multiple configuration options:
     - choosing regular interval to execute a process
     - setting up parameters (arguments in Main.xaml)
     - selecting the robots to execute (similar to Jobs)
     - setting up non-working days and other parameters
   - Steps:
     1. navigate to the schedules page
     2. create a new Schedule
     3. configure parameters
     4. click 'Create' 
3. From the Robot Tray
   - Can be useful for testing purposes or simple automations
   - Steps:
     1. make sure package is assigned to the environemtn in which your attended robot is part of
     2. open the robot
     3. if the package has update available, you will see an up arrow from whcih you can update it in your robot
     4. once done, you can run the process byu clicking the 'Play icon' 

## Assets
#### What are assets?
They are shared variables or credentiuals that are stored in the Orchestrator and used by the robots in different automation projects. THey can be considered a data repository that the robots can access when running processes, based on clear instructions

Types of assets:
- Text: string
- Bool: true/false
- Integer: Whole number
- Credential: usernames and passwords

#### How are Assets created
In Orchestrator:
- can be created from the dedicated area 
- name and data type have to be provided
  - single value: can be accessed and used by all robots
  - value per robot: each value provided can be accessed only by the indicated robot
- they can be modified or deleted from the same menu

In Studio:
- For Credentials, the 'Get Credential' activity has to be used
- For all other types of assets, the 'Get Asset' activity is used

## Queues
#### What are Queues
Queues are containers that can hold an unlimited number of items. Queues in Orchestrator will store items and allow their distribution individually to robots for processing, and monitoring the status of the items based on the process outcomes

Advantages:
- centralized depository of work items
- reporting capabilities at individual item level, as well as queue level
- effectiveness of item distribution process - anytime a robot becomes available, the queue item in line is dispatched
- unitary logic of item distribution FIFO