# TechSupportSystem
 - GUI Design and Business Logic Classes 
- Developed a “TechSupport”, a system which can be used by a software company. The main purpose is to track technical support service calls, referred to as incidents.

##### Developed a GUI and Entity classes needed to perform the operations listed below.

- When the user tries to save it should display the message with all the information saying, “Saved to the database” etc.

-	Maintain (add new, delete, modify and save) Customers, where each customer has the following information:
o	Id, numeric, unique
o	Name
o	Street name and number, City, Province, Postal Code
o	Phone
o	Email

-	Maintain (add new, delete, modify and save) Products, where each product has the following information:
o	Product code, unique, up to 10 char
o	Name
o	Version, numeric with one decimal
o	Release date


-	Maintain (add new, delete, modify and save) Technicians, where each technician has the following information:
o	Id, numeric, unique
o	Name, Email, Phone


-	Maintain Incidents i.e
o	Add customer incidents, it should let the user retrieve the customer information using the customer id and list all the products for which a customer is registered and accept the date opened (non-editable, system date), title and description of the incident.
o	List of incidents closed by a technician
o	List of incidents which are open
 For each incident has the following information:
o	Id, numeric, unique
o	Customer id, Product Id, Technician Id
o	Date opened and closed
o	Title, Description


GUI Design – Suitable GUI with suitable controls, menus, navigation for all the operations and data is designed.
Class Design  – All the classes with the properties, and methods using Inheritance/Composition where needed.
Functionality  - The GUI is functional i.e. providing an appropriate feedback to the user.



#### GUI Programming and Arrays Classes

- Completed/Implemented the functionality of the GUI designed for the Technicians and Product using the arrays.

-	Maintain (add new, delete, modify and save) Products, where each product has the following information:
o	Product code, unique, required, up to 10 char
o	Name, required
o	Version, numeric with one decimal, required
o	Release date, required

-	Maintain (add new, delete, modify and save) Technicians, where each technician has the following information:
o	Id, numeric, unique and required
o	Name, Email, Phone (all are required)


####  Class Design – All the entity and DB classes with proper properties, methods using Inheritance/Composition where needed.
#### Data Validation – Data validation is provided for the proper format and required fields.
#### Functionality – Application is working as per the requirement.


#### File I/O

- Completed/Implemented the functionality of the GUI designed for the Technicians and Product using the File I/O.

-	When the products form is closed, it should save the products information from the array to the products file using the Text I/O.
-	When the products form is opened or activated it should read the products information from the products file to the array using the Text I/O.
-	When the technicians form is closed, it should save the technicians information from the array to the technicians file using binary I/O.
-	When the technicians form is opened or activated it should read the technicians information from the file to the array using binary I/O.

#### Text File I/O  – performed the text file read/write of the requested information to the file.
#### Binary File I/O  – performed the binary file read/write of the requested information to file.
#### Exception Handling – Handled all the exceptions and providing proper feedback to the user.



#### Database Management

- Completeed/Implemented the functionality of the GUI designed for the Customer and Incident Report using the Database Management. The structure of database tables needed is provided.

•	Maintain (add new, delete, modify and save) Customers, where each customer has the following information:
-	Id, numeric, unique
-	Name
-	Street name and number, City, Province, Postal Code
-	Phone
-	Email

•	Maintain Incidents i.e
-	Product Registration, customer should be able to register for one or more purchased products. 
-	Add customer incidents, it should let the user retrieve the customer information using the customer id and list all the products for which a customer is registered and accept the date opened (non-editable, system date), title and description of the incident. 
-	List of incidents closed by a technician
-	List of incidents which are open
 	For each incident has the following information:
-	Id, numeric, unique
-	Customer id, Product Id, Technician Id
-	Date opened and closed
-	Title, Description


#### Customer Management – Add , Delete  and Modify 
#### Incident Management 
#### Exception Handling  – Handling all the exceptions, data validation and providing proper feedback to the user.



