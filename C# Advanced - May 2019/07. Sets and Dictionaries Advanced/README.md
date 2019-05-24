>Lab: Sets and Dictionaries Advanced

>Problems for exercises and homework for the "C# Advanced" course @ SoftUni.

>I .	Dictionaries

># 1.	Count Same Values in Array

>Write a program that counts in a given array of double values the number of occurrences of each value. 

> #  2.	Average Student Grades

>Write a program, which reads a name of a student and his/her grades and adds them to the student record, then prints the student's names with their grades and their average grade.

><b>Hints

 >•	Use a dictionary (string  List<double>) 

>•	Check if the name exists before adding the grade. If it doesn’t, add it to the dictionary.

>•	Pass through all key-value pairs in the dictionary and print the results. You can use the .Average() method to quickly calculate the average value from a list. 
># 3.	Product Shop
>Write a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "[shop], [product], [price]".  Keep in mind that if you receive a shop you already have received, you must collect its product information.

>Your output must be ordered by shop name and must be in the format:

>[shop]->

>Product: [product], Price: [price]


># 4.	Cities by Continent and Country

>Write a program that reads continents, countries and their cities, puts them in a nested dictionary and prints them.


>Hints

>•	Use a nested dictionary (string  (Dictionary  List<string>)) 

>•	Check if the continent exists before adding the country. If it doesn’t, add it to the dictionary.

>•	Check if the country exists, before adding the city. If it doesn’t, add it to the dictionary.

>•	Pass through all key-value pairs in the dictionary and the values’ key-value pairs and print the results.

>II .	Sets

># 5.	Record Unique Names

>Write a program, which will take a list of names and print only the unique names in the list.

><b>Hints

>You can store the names in a HashSet<<string.>> to extract only the unique ones.

># 6.	Parking Lot

>Write a program that:

>•	Records a car number for every car that enters the parking lot

>•	Removes a car number when the car leaves the parking lot

>The input will be a string in the format: [direction, carNumber]. You will be receiving commands, until the "END" command is given.

>Print the car numbers of the cars, which are still in the parking lot:


><b>Hints

>•	Car numbers are unique

>•	Before printing, first check if the set has any elements

># 7.	SoftUni Party

>There is a party in SoftUni. Many guests are invited and there are two types of them:  VIP and regular. When a guest comes, check if he/she exists in any of the two reservation lists.

>All reservation numbers will be with the length of 8 chars.

>All VIP numbers start with a digit.

>First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:

>•	"PARTY" – after this command you will begin receiving the reservation numbers of the people, who actually came to the party. 

>•	"END" –the party is over and you have to stop the program and print the appropriate output.

>In the end, print the count of the quests who didn't come to the party and afterwards, print their reservation numbers. The VIP guests must be first.


