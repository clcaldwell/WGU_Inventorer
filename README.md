# WGU Inventorer

This project is a mockup of a desktop business inventory management application. This project is written in C#, targeting WinForms. This was course work for my degree program at Western Governors University (WGU). 

To run and compile this, you will need Visual Studio. I have tested against Visual Studio 2019 and Visual Studio 2022, I do not know if this will compile against older versions.

## Functionality

### User Interface
- A main form, showing the following controls:
  - buttons for “Add,” “Modify,” “Delete,” “Search” for parts and products, and “Exit”
  - lists for parts and products
  - text boxes for searching for parts and products
  - title labels for parts, products, and the application title

- An add part form, showing the following controls:
  - radio buttons for “In-House” and “Outsourced” parts
  - buttons for “Save” and “Cancel”
  - text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
  - labels for ID, name, inventory level, price/cost, max and min values, the application title, and company name or machine ID

- A modify part form, with fields that populate with data from an existing Part, showing the following controls:
  - radio buttons for “In-House” and “Outsourced” parts
  - buttons for “Save” and “Cancel”
  - text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
  - labels for ID, name, inventory level, price, max and min values, the application title, and company name or machine ID

- An add product form, showing the following controls:
  - buttons for “Save,” “Cancel,” “Add” part, and “Delete” part
  - text boxes for ID, name, inventory level, price, and max and min values
  - labels for ID, name, inventory level, price, max and min values, and the application
  - a grid view for all parts
  - a grid view for parts associated with the product
  - a “Search” button and a text field with an associated list for displaying the results of the search

- A modify product form, with fields that populate with data from an existing product, showing the following controls:
  - buttons for “Save,” “Cancel,” “Add” part, and “Delete” part
  - text boxes for ID, name, inventory level, price, and max and min values
  - labels for ID, name, inventory level, price, max and min values, and the application “all candidate parts”
  - a grid view for parts associated with the product
  - a “Search” button and a text box with associated list for displaying the results of the search


### Logic
- Classes and instance variables:
  - five classes with the all associated properties
  - variables are accessible/modifiable through properties

- Main form:
  - redirect the user to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms
  - delete a selected part or product from the grid view
  - search for a part or product and display matching results
  - exit the main form

- Part forms:
  - “Add Part” form
    - select “In-House” or “Outsourced”
    - enter name, inventory level, price, max and min values, and company name or machine ID
    - save the data and then redirect to the main form
    - cancel or exit out of this form and go back to the main form
  - “Modify Part” form
    - select “In-House” or “Outsourced”
    - modify or change data values
    - save modifications to the data and then redirect to the main form
    - cancel or exit out of this form and go back to the main form

- Product forms:
  - “Add Product” form
    - enter name, inventory level, price, and max and min values
    - save the data and then redirect to the main form
    - associate one or more parts with a product
    - remove or disassociate a part from a product
    - cancel or exit out of this form and go back to the main form
  - “Modify Product” form
    - modify or change data values
    - save modifications to the data and then redirect to the main form
    - associate one or more parts with a product
    - remove or disassociate a part from a product
    - cancel or exit out of this form and go back to the main form 

- Write code to address the following conditions with exception handling code:
  - Detect non-numeric values in textboxes that expect numeric values
  - Min should be less than Max; and Inv should be between those two values
  - Prevent the user from deleting a product that has a Part associated with it
  - Confirm “Delete” actions