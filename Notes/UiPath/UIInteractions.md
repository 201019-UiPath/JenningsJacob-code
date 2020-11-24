# UI Interactions

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [UI Interactions](#ui-interactions)
  - [Input Actions and Methods](#input-actions-and-methods)
      - [Input Methods](#input-methods)
      - [Input Actions](#input-actions)
  - [Output Actions and Methods](#output-actions-and-methods)
      - [Output Methods](#output-methods)
      - [Output Actions](#output-actions)
  - [Working with UI Elements](#working-with-ui-elements)
      - [UI Element Locator Actions](#ui-element-locator-actions)

<!-- /code_chunk_output -->

## Input Actions and Methods
The main input actions in UiPath are Click, Type into, Send Hotkey and Hover. These are also the main actions a human user would perform to input data in an application.
#### Input Methods
Input Methods provide the input actions wiht the means to input data. Each input action lets the user switch between the 3 methods: 

| Simulate Type/Click/Hover | SendWindowMessages | Default |
| ------------------------- | ------------------ | ------- |
| Uses the technology of the target application (API level) to send instructions | Replays the window messages that the target application receivves when the mouse/keyboard is used | Selected if none of the two boxes are checked |
| Clicking and Typing occur instantly | Clicking and typing occur instantly | Clicks: the mouse cursor moves across the screen Typing: the keyboard driver is used to type individual characters |
| Works in the background | Works in the background | Attended user can't touch mouse or keyboard during the automation |
| Actions are a lot faster, but there are some compatibility limitations | Comparable to the Default method in terms of speed | Lower speed and load times can impact accuracy |
| Can automatically erase perviuosly written text | Does not automatically erase perviusly written text | Does not automatically erase previously written text |
| Users can work on  other activities during the execution of the automated processses | Users can work on other activities during the execution of the automated processes | Does not work in the background |
| Does not support special keys | Supports special keys | Supports special keys |
| Has lower compatability than the other 2 methods | Works only with applications that respond to Window Messages | 100% compatability |

#### Input Actions
**Click**, **Type Into**, and **Send hotkey** are simple in terms of what they primarily do. All the input actions share several properties:
- `Delay`: can be used to set a delay before or after the click
- `WaitForReady`: can be configured to wait for the target to become ready by verifying ceratin applicationn tags

**Click**
- `ClickType`: can be single or double (changing the default to double makes it very simple to Double Click)
- `MouseButton`: can be configured to left, middle or right button
- `Timeout`: specifies the duration in which the activity is retried until an error is thrown
- `KeyModifiers`: can press the Alt, Ctrl, Shift and/or Win key while performing the action

**Type Into**
- `Activate`: the field in which the text is typed is brought to the foregournd and activated, before the typing
- `ClickBeforeTyping`: the UI element in which the text will be typed into we be clicked on before typing
- `DelayBetweenKeys`: the delay between each key is typed
- `EmptyField`: the UI element will be emptied before typing
- For secure fields, user `Type Secure Text` activity

**Send hotkey**
- `Activate`: the field in which the text is typed is brought to the foregournd and activated, before the typing
- `ClickBeforeTyping`: the UI element in which the text will be typed into we be clicked on before typing
- `DelayBetweenKeys`: the delay between each key is typed
- `EmptyField`: the UI element will be emptied before typing
## Output Actions and Methods
Output actions are used in UiPath to extract data (in general, as text) from a UI element.
Output methods are what enables output actions to extract data from UI elements.

#### Output Methods
| FullText | Native | OCR (Optical Character Recognition) |
| -------- | ------ | ----------------------------------- |
| deafult method, usally good enough in most cases | compatible with applications that use Graphics Design Interface (GDI), the Microsoft API used for reprsenting graphical objects | works with "reading" text from images |
| fastest | somewhat slower than FullText | slowest |
| 100% accuracy | 100% accuracy on applications that support GDI | accuracy varies from one text to another and changing settings can improve the results |
| can work in background | cannot work in background | cannot work in background |
| can extract hidden text (ex: options in a drop-down list) | does not extract hidden text | does not extract hidden text |
| does not support virtual environments | does not support virtual environments | works with virtual environments |
| does not capture text position and formatting | can extract text position and formatting (including text color) | relies on recognizing each character and its position |
| offers option to ignore hidden message and capture only visible text | can process all known characters as separators, but when only certain separators are sepcified, it can ignore all the others | has two default engines that can be used alternatively- Google Tesseract and Microsoft MODI. Additionaly OCR engines can be installed for free |

#### Output Actions
Unlike input actions where all input methods are avaiable for each input action, output actions are somewhat matched with the output methods

`Get Text Activity`
- Extracts a text value from a specified UI element

`Get Full Text Activity`
- Extracts a string and its information from an indicated UI element using the FullText screen scraping method
- Hidden text is also captured by default
- Automatically generated when performing screen scraping with the FullText method, along with a container

`Get Visible Text Activity`
- Extracts a string and its information from an indicated UI element using the Native screen scraping method
- Automatically Generated when performing screen scraping with the Native method, along with a container

`Get OCR Text Activity`
- Extracts a string and its information from an indicated UI element using the OCR screen scraping method
- Automatically Generated when performing screen scrraping, along with a container
- Tessertact OCR is default engine used

`Data Scraping Wizard`
- Allows the extraction of structured information from an application, browser or document to a `DataTable` variable
- Can be accessed directly from the Design ribbon, 'Data Scraping' button
- First element chose is used to populate the first column
  - option to extract teh URL is also presented
- User can change the order of the columns and specify the max numbner of entries to be extracted (default = 0)

`Extract Attributes Activities`
- Category of activities that can be used when you don't want to extract the text out of the UI element, but maybe the color, position, or ancestor
  - `Get Ancecstor`
    - retrieves the ancestor of a UI element
  - `Get Attribute`
    - allows the user to indicate an attribute and then retrieves the value of that attribute
  - `Get Position`
    - retrieves the actual position on the screen of a specific element

## Working with UI Elements
Input and Output Actions can be viewed as a succession of 2 micro-steps: first, recognizing UI elements and then inputting (or extracting) data. The first step is easily sorted out either y including it  in the activity, or by using the delay option. That's why its not all necessary to have aa separate activity for locating a UI element before an actual click or type activity

#### UI Element Locator Actions
`Find Element`
- Waits for the specified UI element to appear on the screen (in the foreground)
- returns it as a UiElement variable
- Useful when a certain actions needs to be performed on the Ui element found\

`Element Exists`
- Enables you to verify if a UI element exists (even if not visible)
- Returns boolean variable
- Useful in if statement activities

`Wait Element Vanish`
- Wait for the specified UI element to disappear from the screen
- Alternative to `Find Element`
- usefule when the disappearance of an element (a loading sign) is more reliable than the appearance of another element

`On Element Appear`
- Container that waits for a UI element to appear
- Enables you to perform multiple actions within it

`On Element Vanish`
- Container that waits for a UI element to vanishes
- Enables you to perform multiple actions within it

`Text Exists`
- Checks if a text is found in a given UI element
- There is an alternative that uses OCR technology to check for a given UI element
- Useful when UI elements are not accessible otherwise than as images