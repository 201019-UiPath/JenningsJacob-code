# PDF Automation

<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->

- [PDF Automation](#pdf-automation)
  - [Extracting data from a PDF](#extracting-data-from-a-pdf)
      - [Activities:](#activities)

<!-- /code_chunk_output -->

## Extracting data from a PDF
Depenencies required:
- UiPath.PDF.Activities

PDF files can contain text, images, and text that is actually an image. A basic method of identifyig which is whcih is by simply selecting the elements you are interested in. UiPath has different categories for dealing with PDF files depending on their intended use:
1. larger chucks of text or whole documents
2. extracting specific items from a PDF file

#### Activities:
`Reat PDF Text`: used to read whole PDF documents or pages
- Choose a file to read
- output a text variable with the contents of the file
- Range parameter can be set to specific pages, a range of panges, or "All" if you want to read the whole thing
- self-contained, can run in background

`Read PDF with OCR`: uses OCR to scan the images inside the PDF document and output all the text as a variable
- requires OCR engine
- has the usual OCR parameters: allowed characters, denied characters, language, scale, and so on
- usually not smart enough to recognize columns within the document (except Abby which perserves layout structure)
- quality quickly degrades with the quality of the source-image
- self-contained, can run in background

`Screen scraping tool`
- You can use the screen scraping tool that generates the required actions for you
- Just indicate the text elements that you need to be scraped, and UiPath will hsow this preview window with a few options.

## Extracting a single piece of data
The second category of dealing with PDF files, is extracting specific items 

#### Activities
`Get Text`: works the same as get text anywhere else
- use the repair feature to select another similar, element that should fix the selector for you
  
## Anchor Base Activity
The achor base activity allows us to extract fluctuaing values from a series of PDF files.
- made up of 2 actions
- performs an action in relation to another fixed element, or anchor
  - typical anchor is the Find Element action
- has AnchorPosition property that allows to you define where the anchor is located in relation to the target element