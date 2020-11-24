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
