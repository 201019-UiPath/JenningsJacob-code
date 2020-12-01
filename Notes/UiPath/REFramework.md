# Robotic Enterprise Framework Overview

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Robotic Enterprise Framework Overview](#robotic-enterprise-framework-overview)
  - [Transaction Processing](#transaction-processing)
      - [What is a transaction?](#what-is-a-transaction)
      - [Business Process Categories](#business-process-categories)
  - [The REFramework](#the-reframework)
      - [Main states of REFramework](#main-states-of-reframework)
      - [REFramwork Features](#reframwork-features)
  - [Dispatcher/Performer](#dispatcherperformer)
      - [Dispatcher](#dispatcher)
      - [Performer](#performer)
      - [Advantages](#advantages)

<!-- /code_chunk_output -->

## Transaction Processing
#### What is a transaction?
A transaction represents the minimum (atomic) amount of data and the necessary steps required to process the data, as to fulfill a section of a business process

#### Business Process Categories
**Linear**
- steps of the process are performed only once
- if there is a need to process different data, the automation can be executed again
- are usually simple and easy to implement
- ex: a new email arrives, the automation has to be executed again in order to process it

**Iterative**
- steps of a process are performed multiple times, but each time different data items are used
- can be implemented with a simple loop
- Disadvantage: when processing one item, the whole process is interrupted and the other items remain unprocessed
- ex: reading a single email, the automation can retrieve multiple emails and iterate through doing the same steps

**Transactional**
- Similarly to iteratice process, processes repeat multiple times over different data items
- automation is designed so that each repeatable part is processed independently
- repeatable parts are then called transactinos
  - they are independent because they do not share any data or have any order to be processed

## The REFramework
REFramework is implemented as a state machine
- states that define actions to be taken according to the specified input
- transitions that move the execution between states depending on the outcomes of the states themselves

#### Main states of REFramework
1. **Initial State**
   - where the process starts
   - process initializes the settings and performs application checks to make sure all the prerequisites for the starting the process are in place
2. **Get Transaction Data State**
   - Gets the next transaction item
   - can be a queue item or any item of a collection
   - by default, tranasction items are queue items, but can be changed
   - this is the state which the developer should set up a condition to exit this state when there are no items to process
3. **Process Transaction State**
   - Performs action/applies logic in various applications for the transaction item
   - once transaction item is processed, the process continues with the next available transaction item
4. **End Process State**
   - The process ends
   - close applications

#### REFramwork Features
**Settings**
- it is common to have certain settings and configuration values that are read during the initialization phase
- could include URLs, Orchestrator queue names, default logging messages
- REFramwork keeps track of them in the Config.xlsx file and storing them in a Dictionary object (Config) that is shared among different states
- offers easy way to maintain projects by changing values in the config file, instead of workflow directly

**Logging**
- REFramework has built-in logging mechanism
- most of the workflows include Log Message activiteis
- Can be used to find problems and help with debugging
- can also create visualizations and reports about the execution of the process

**Business Exceptions & Application Exception**
- there can be situations that are not part of the normal execution flow and they need to be address to achieve a more robust automation
- Ex: a process that uses web applications, but the web browser freezes
  - if an activity tries to interact, it will probably fail and return an exception
  - REFramework is design to enable recovery by attempting the transaction again, or skipping transaction
  - if cause of problem can be fixed by restarting applications, then the framework automatically does that (Application Exceptions)
  - If problem is related to the data itsel or underlying business requirement, then that transaction is skipped and the framework proceeds to the next transaction (Business Rule Exceptions)

## Dispatcher/Performer
REFramework provides a particularly integration with Orchestrator queues. Whene queues are used, it is possible to define priorities and deadlines for transaction items and to track retrying attempts of failed transactions.
- This enables pattern called Dispatcher & Performer, which divides the process with 2 main phases:
  - dispatching items to be processed and adding them to queue
  - retreiving item form a queue and performing the process using that item

#### Dispatcher
- process used to push transaction items to an Orchestrator queue
- extracts data from one or multiple sources and uses it to create Queue items to be processed by performer robots
- information is pushed to one or more queues allowing the dispatcher to use a common format for all data stored in queue items
- main advantage is you can split the processing of the items between multiple robots

#### Performer
- prcoess used to pull transaction items from an orchestrator queue and process them as needed
- queue items processed one at a time
- uses error handling and retry mechanisms for each processed item
- major advantage is its scalability
  - multiple performers can be used with a single queue

#### Advantages
1. Better separation of processes (between dispatcher and performer)
2. Better separation and distinction between architecture and process layers
3. Better error handling and retry mechanisms
4. Possibility to run processes across several machines (availability)
5. Better re-usability within your project's created componenets
6. Improved built-in configuration and Orchestrator integration
7. Previous workflows created without REFramework can easily be adapted and deployed in order to use REFrameowrk and the dispatcher/performer model
