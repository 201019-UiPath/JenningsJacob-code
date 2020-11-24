# Data Manipulation
In this file, we will cover some of the most representative operations and examples of data manipulation.

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Data Manipulation](#data-manipulation)
      - [What is data Manipulation](#what-is-data-manipulation)
  - [Strings](#strings)
      - [String Methods](#string-methods)
  - [Lists](#lists)
      - [UiPath List Methods](#uipath-list-methods)
  - [Dictionaries](#dictionaries)
      - [UiPath Dictionary Methods](#uipath-dictionary-methods)
  - [RegEx Builder](#regex-builder)
      - [Methods in UiPath that use RegEx builder:](#methods-in-uipath-that-use-regex-builder)

<!-- /code_chunk_output -->
#### What is data Manipulation
The process of modifying, structuring, formatting, or sorting through data in order to facilitate its usage and increase its management capabilities.

## Strings
Strings are a *data type* corresponding to text
#### String Methods
`Concat`
- Concatenates the string representations of two sepcified objects 
- Ex: `String.Concat(var1, var2)`

`Contains`
- Checks whether a specified substring occurs within a string. Returns true or false
- Ex: `VarName.Contains("text")`

`Format`
- Converts the value of objects to string (and insterts them into another text)
- Ex: `String.Format("{0} is {1}", var1, var2)`

`Indexof`
- Returns the zero-based index of the first occurrence of a character in a string
- Ex: `VarName.IndexOf("a")`

`Join`
- Concatenates the elements in a collection and displays them as string
- Ex: `Sting.Join("|", CollVarName1)`

`Replace`
- Replaces all the occurrences of a substring in a string
- Ex: `VarName.Replace("original", "replaced")`

`Split`
- Splits a string into substrings using a given separator
- Ex: `VarName.Split(".")`

`Substring`
- Extracts a substring from a string using the starting index and the length
- Ex: `VarName.Substring(startIndex, length)`
  
## Lists
Lists are data structures consisting of objects of the same data type. Each object has a fixed position in the list; thus it can be accessed by index. Does not have a fixed size.

#### UiPath List Methods
`Add to Collection`
- adds an item to the specified collection
- similar to `List.Add()`

`Remove from Collection`
- removes an item from a specified collection and can output a boolean variables that confirms the success of the removal operation

`Exists in Collection`
- Indicates whether a given item is present in a given collection by outputting a boolean as the result

`Clear Collection`
- Clears a specified collection of all items

## Dictionaries
Dictionaries are collections of key, value parirs in which the keys are unique.
#### UiPath Dictionary Methods
`Initialization`
- Can be done in an 'Assign' activity

`Adding`
- Adds an item to an existing Dictionary
- does not return a value, use the Invoke Code activity
- `VarName.Add(Key, Value)`

`Removing`
- Removes an item from teh Dictionary
- Can be used in an 'Assign' activity
- `VarName.Remove(Key)` 

`Retrieving`
- `VarName.Item(Key)`  - returns the dictionary item by its key
- `VarName.Count` - returns an Int32 valyue of the number of dictionary items
- `VarName.ContainsKey(key)` - checks if the item with the given key exists in the dictionary and returns a boolean result
- `VarName.TryGetValue(Key, Value)` - checks if an item with a given key exists in teh dictionary and returns a boolean result and the value if found

## RegEx Builder
Specific search pattern that can be used to easily match, locate, and manage text

#### Methods in UiPath that use RegEx builder:
`Matches`
- Searches an input string for all occurrences and returns all the successful matches

`IsMatch`
- Indicates whether the specified regex finds a match in hte specified input string

`Replace`
- Replaces strings that match a regular expression pattern with a specified replacement string