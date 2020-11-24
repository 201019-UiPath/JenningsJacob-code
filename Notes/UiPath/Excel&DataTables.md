# Excel and Data Tables

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [Excel and Data Tables](#excel-and-data-tables)
  - [Data Tables](#data-tables)
      - [What are DataTables](#what-are-datatables)
      - [How DataTables are created](#how-datatables-are-created)
      - [DataTable Activities](#datatable-activities)
      - [Join Data Tables](#join-data-tables)
  - [Workbooks](#workbooks)
      - [Common Activities](#common-activities)
      - [Excel Application Scope](#excel-application-scope)
      - [Excel App Integration Specific Activities](#excel-app-integration-specific-activities)

<!-- /code_chunk_output -->

## Data Tables
#### What are DataTables
DataTables is the type of variable that can store data as a simple spreadsheet with rows and and columns, so that each piece of data can be identified based on their unique column and row coordinates. 
- Columns are identified by capital letters
- Rows are identified by numbers

#### How DataTables are created
1. `Build Data Table`
   - By using this activity, you get to choose the number of columns and the data type of each of them
   - Configure each column with specific options (null values, unique values, increment, default values, string length)
2. `Read Range`
   - Gets the content of a worksheet (or a selection)
   - Stores data in a `DataTable` variable 
3. `Read CSV`
   - Captures the content of a CSV file
   - Stores data in a `DataTable` variable
4. `Data Scraping`
   - Functionality of UiPath Studio that enables you to extract structured data from the browser, application, or document
   - Stores data in a `DataTable` variable

#### DataTable Activities
`Add Data Column`
- Adds a column to an existing `DataTable` variable
- Input can be of `DataColumn` type or empty, by specifying the data type and configuring the options

`Add Data Row`
- Adds a row to an existing `DataTable` variable
- Input can be of `DataRow` type or `Array Row``, by matching each object witht hte dat type of each column

`Build Data Table`
- Creates a `DataTable` using a dedicated window
- Allows the customization of number of columns and type of data for each column

`Clear Data Table`
- Clears all data in an existing `DataTable` variable

`Filter Data Table`
- Allows filtering a `DataTable` through a Filter Wizard, using various conditions
- Can be configured to create a new `DataTable` for the output of the activity, or to keep the existing one and filter out the entires that do not match the filtering conditions

`For Each Row`
- Used to perform a certain activity for each row of a `DataTable`

`Generate Data Table`
- Used to create a `DataTable` from unstructured data, by letting user indicate the row and column serparators

`Join Data Tables`
- Combines rows from tow tables by using values common to each other, according to join rule

`Lookup Data Table`
- similar to vLookup in excel
- allows seaching for a provided value in a specified `DataTable` and returns the `RowIndex` at which it was found
- can be configured to return the value from a cell with given coordinates

`Merge Data Table`
- Used to append a specified `DataTable` to the current `DataTable`
- more simple than `Join Data Type` activity

`Output Data Table`
- Writes a `DataTable` to a string using the csv format

`Remove Data Column`
- Removes a certain column from a specified `DataTable`
- Input may consist of the column index, column name or a `Data Column` variable

`Remove Data Row`
- Removes a certain row from a specified `DataTable`
- Input may consist of the row index or a `Data row` variable

`Remove Duplicate Rows`
- Removes the duplicate rows from a specified `DataTable`
- Keeps only first occurrence

`Sort Data Table`
- Can sort a `DataTable` ascending or descending based on the values in a specific column

#### Join Data Tables
How does it work?
1. **3 Data Table variables** have to be specified
   - 2 input DataTables
   - 1 output DataTable
   - order of inputs matter
2. The **Join Type** has to be chosen, options:
   - Inner: Keep all rows from both tables than meet join rule
   - Left: Keep all rows from first table and the values from the second table that meet join rule
   - Full: Keep all rows from both tables, regardless of join rule
3. The **Join Rules** have to be configured (there can be more than one)
   -  One column from each `DataTable` has to be specified by their names (string), by their index (Int32) or by `ExcelCOlumn` variables

## Workbooks
UiPath offers 2 separate ways of accessing and manipulating workbooks, each of them with advantages and limitations:

**File Access Level**
- All workbook activities will be executed in the background
- (+) Doesn't require Excel to be installed, can be faster and more reliable for some operations just by not opening the file
- (!) works only for .xlsx files

**Excel App Integration**
- UiPath opens Excel like a human would
- (+) works with .xls and .xlsm, and has some sepcific activites for working with .csv. All activities can be set to either be visible to the user or run in the background
- (!) Excel must be installed, even when 'Visible' box is unchecked

#### Common Activities
`Append Range`
- Adds the information from a `DataTable` to the end of a sepcified Excel spreadsheet
- Creates one if sheet does not exist

`Get Table Range`
- Locates and extracts the range of an Excel table from a specified spreadsheet using the table name as input

`Read Cell`
- Reads the content of a given cell
- Stores value as String

`Read Cell Formula`
- Reads the formula from a given cell
- Stores it as String

`Read Column`
- Reads a column starting with a cell inputted by the user 
- Stores it as an `IEnumerable<object>` variable

`Read Range`
- Reads a specified range and stores it in a `DataTable`
- If 'Use filter' is checked,, it will read only the filtered data

`Read Row`
- Reads a row starting with a cell inputted by the user 
- Stores it as an `IEnumerable<object>` variable.

`Write Cell`
- Writes a value into a specified cell
- If cell contains data, the activity will overwrite it
- Creates sheet if specified one doesn't exist

`Write Range`
- Writes the data from a `DataTable` variable in a spreadsheet starting with the cell indicated in the `StartingCell` field

#### Excel Application Scope
Integration with Excel enabled by using an Excel Application Scope activity. It is a container and all the other activites used to work with the specified Excel file have to be placed inside the container. Basically, opens Excel sheet and provides a scope for Excel activities

#### Excel App Integration Specific Activities
**CSV**
- Append to CSV
- Read CSV
- Write CSV

**Range**
- Delete Column
- Insert Column
- Insert/Delete Columns
- Insert/Delete Rows
- Select Range
- Get Selected Range
- Delete Range
- Auto Fill Range
- Copy Paste Range
- Lookup Range
- Remove Duplicate Range

**Table**
- Filter Table
- Sort Table
- Create Table

**File**
- Close Workbook
- Save Workbook

**Cell Color**
- Get Cell Color
- Set Range Color

**Sheet**
- Get Workbook Sheet
- Get Workbook Sheets
- Copy Sheet

**Pivot Table**
- Refresh Pivot Table
- Create Pivot Table

**Macro**
- Execute Macro
- Invoke VBA (macro from another file)