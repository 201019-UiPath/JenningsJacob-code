# Control Flow

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Control Flow](#control-flow)
  - [Sequences](#sequences)
  - [Control FLow and its Types](#control-flow-and-its-types)
      - [Control Flow](#control-flow-1)
      - [Types of Control FLow](#types-of-control-flow)
  - [Decision Control](#decision-control)
      - [If Statement](#if-statement)
      - [Switch Activity](#switch-activity)
  - [Loops](#loops)

<!-- /code_chunk_output -->

## Sequences
Sequence is a container in which activities are placed one after amother and excuted linearly
- Enables the user to create linear processes
- Can serve as a stand-alone automation project or can be included as part of a flowchart
- can be reused

Example: A sequence that asks the user for his name, age, and country then displays them

## Control FLow and its Types
#### Control Flow
The order in which activities or actions are executed in a workflow
- Used to define the decisions to be made during the execution of a workflow
- Enable users to define rules and automate conditional statements within a project
- found in Activities panel under Workflow -> Control

#### Types of Control FLow
- **Decision Based**: Choose between two (or more) parts of a program when  a specific condiiton is met
- **Iteration Based**: Keep executing a particular part of htt program until a specific condition is met

## Decision Control
Helps the user decide the execution flow of th program bsed on certain conditions

#### If Statement
Contains a statement with a condition and two sets of instructions (Then & Else) as outcomes. In flowcharts, it will be represented as a Flow Decision
![IfStatement](../images/UiPath/If.png)

#### Switch Activity
Executes a set of statemnests out of multiple, based on the value of a specific expression. Used instead of if statement when we need at least 3 potential courses of action.
![Switch](../images/UiPath/switch.png)

## Loops
Repititions of a set of operations based on aa given condition. Most important loops are:

**Do While**:
- execcutes a specific sequence while a condition is met. The conditition is evaluated after each execution of the statements
- in sequences, they have their own container
- in flowcharts, you can just connect a certain point the the workflow to another execution point

**While**:
- execcutes a specific sequence while a condition is met. The conditition is evaluated before each execution of the statements

**For Each**:
- Performs an activity or a series of activities on each element of a collection
- in sequences, add for each activity, then give an iterator and collection of objects you wish to iterate through