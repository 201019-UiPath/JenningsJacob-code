# Error and Exception Handling

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Error and Exception Handling](#error-and-exception-handling)
  - [Common Exceptions](#common-exceptions)
      - [Errors vs Exceptions](#errors-vs-exceptions)
      - [Common Exceptions](#common-exceptions-1)
      - [Business Rule Exceptions](#business-rule-exceptions)
  - [Try Catch](#try-catch)
  - [Retry Scope](#retry-scope)
      - [Additional Properties](#additional-properties)
  - [ContinueOnError Property](#continueonerror-property)
  - [Global Exception Handler](#global-exception-handler)
      - [How does it work?](#how-does-it-work)

<!-- /code_chunk_output -->
## Common Exceptions
#### Errors vs Exceptions
Errors
- events that a particular program can't normally deal with
  - Ex:
    - Syntax Errors, where the compiler/interpreter cannot parse the written code into meaningful computer instructions
    - User Errors, wheret the software determines that the user's input is not acceptable for some reason
    - Programming Errors (bugs), wheret he program contains no syntax errors, but does not produce the expected results

Exceptions
- Events that are caught by the program, categorized and handled. There is a routine configured by the developer that is activated when an exception is caught. 

#### Common Exceptions
All exceptions are types derived from `System.Exception`, so using this generic type in a Try Catch will catch all types of errors
- `NullReferenceException`: occurs when using a variable with no set value (not initialized)
- `IndexOutOfRangeException`: occurs when the index of an object is out of the limits of the collection
- `ArgumentException`: thrown when a method is invoked and at least one of the passed arguments does not meet the parameter specification of the called method
- `SelectorNotFoundException`: thrown when the robot is unable to find the designated slector for an activity in the target app within the TimeOut period
- `ImageOperationException`: occurs when an image is not found within the TimeOut period
- `TextNotFoundException`: occurs when the indicated text is not found within the TimeOut period
- `ApplicationException`: describes an error rooted in a technical issue, such as an application that is not responding

#### Business Rule Exceptions
They are separate from System Exceptions listed above. Theses describe errors rooted in the fact that certain data which the automation project depends on is incomplete, missing, outside of set boundaries or does not pass other data validation criteria. 

Business Rule Exceptions will not be thrown by using the generic System.Exception in a Try Catch activity. The mechanism of handling this exception has to be separately defined by the developer, or it can be reduced to stoppping the execution of the process, by using  a simple **Throw** activity

## Try Catch
This activity catches a specified exception type in a sequence or activity, and either displays an error notification or dismisses it and continues the execution. In the catch block, the most specific exception caught will be executed.

## Retry Scope
The Retry Scope Activity retries the contained activities as long as the condition is not met or an error is thrown. 

This activity is used for catching and handling an error, which is why it's similar to Try Catch. The difference is that this activity simply retries the execution instead of providing a more complex handling situation.

It can be used without a termination condition, in which case it will retry the activities until no exception occurs (or the provided number of attempts is exceeded).

#### Additional Properties
- **NumberofRetries**: the number of times that a sequence is to be retried
- **RetryInterval**: specifies the amount of time (in seconds) between each retry

## ContinueOnError Property
Continue or Error is a property that specifies if the execution should continue even when the activity throws an error. If set to true on an activity that has a scope (such as attach window or attach browser), then all the error that occur in other activities inside that scope are also ignored. Having this set to true ios not always recommended, but there are some where it makes sense:
- while using data scraping - so the activity doesn't throw an error on the last page (when the selector of the 'Next' button is no longer found)
- when we are not intereseted in capturing the error, but simply in the execution of the activity

This field supports Boolean values, and it defaulted to False.

## Global Exception Handler
The Global Exception Handler is a type of Workflow designed to determine the behavior when envountering an execution error at the project level. ONly one can be set per automation project.

Only uncaught exceptions will reach the Exception Handler. If an exception occurs inside a Try Catch activity and it is successfully caught and treated inside the Catch block (and not re-thrown), it will not reach the Global Exception Handler.

A Global Exception Handler can be created either by starting a new project with this type, or by setting an existing project as Global Exception Handler from the Project panel

#### How does it work?
It has 2 predefined arguments, that shouldn't be removed:
- `errorInfo`, with the in direction - contains the error that was thrown and the workflow that failed
- `result` with the Out direction - will store the next behavior of the process when it encounters the error

The Global Exception Handler contains the predefined 2 actions below (that can be removed). Other actions can be added
- **Log Error**: This part simply logs the error. The developer gets to choose the logging level: Fatal, Error, Warning, Info
- **Choose Next Behavior**: choose the action when an error is encounted during execution
  - Continue: the exception is rethrown
  - Ignore: the exception is ignored, and the execution continues from the next activity
  - Retry: the activity which threw the exception is retried
  - Abort: the execution stops after running the current handler