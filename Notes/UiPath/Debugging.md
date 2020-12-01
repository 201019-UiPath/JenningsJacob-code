# Debugging

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Debugging](#debugging)
      - [Some tips about debugging:](#some-tips-about-debugging)

<!-- /code_chunk_output -->

#### Some tips about debugging:
- When you click an activity or container in the call stack panel, you focus on it
- The output of Log Messages and Write Line activities are displayed in the output panel
- When executing your workflow in Debug mode and an exception has been thrown:
  - Retry: Starts the debugging process from the first activity
  - Ignore: Continues the execution from the next activity
  - Restart: Re-executes the previous activity and throws teh exception if it is encountered again
- The defatul action of the play button in the Ribbon is Debug Current File
- You can find the **Run From This** and **Test Activity** in the activity contextual menu in the Designer panel
- When you close a Test Bench tab without saving the workflow, you will lose your Test Bench
- You can create a Test Bench by right-clicking the activity in the Activities panel
- Changes to a variable in hte Immediate Panel will be reflected in the:
  - further execution of the workflow in debug mode
  - the watch panel
  - the locals panel
- You can directly add variables to the watch panel from the:
  - locals panel
  - variables panel
  - watch panel
- In the watch panel, you can follow the values of variables or arguments, and the values of user-defined expressions that are in scope
- The information in the Call Stack displays the next activity to be executed and its parent containers
- You can check the current value of a complex expression in the immediate panel
- In the locals panel, you can find:
  - properties of the current activity
  - properties of the previously executed activity
  - Argument values
  - Variable values
  - exceptions