Exercises: Sets and Dictionaries Advanced

Problems for exercises and homework for the "C# Advanced" course @ SoftUni.

><h1> Problem 1.	Unique Usernames

Write a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. On the first line you will be given an integer N. On the next N lines you will receive one username per line. Print the collection on the console in order of insertion:


><h1> Problem 2.	Sets of Elements

Write a program that prints a set of elements. On the first line you will receive two numbers - n and m, which represent the lengths of two separate sets. On the next n + m lines you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set. Find all the unique elements that appear in both of them and print them in the order in which they appear in the first set - n.





><h1>Problem 3.	Periodic Table

Write a program that keeps all the unique chemical elements. On the first line you will be given a number n - the count of input lines that you are going to receive. On the next n lines you will be receiving chemical compounds, separated by a single space. Your task is to print all the unique ones in ascending order:


><h1>Problem 4.	Even Times

Write a program that prints a number from a collection, which appears an even number of times in it. On the first line, you will be given n – the count of integers you will receive. On the next n lines you will be receiving the numbers. It is guaranteed that only one of them appears an even number of times. Your task is to find that number and print it in the end. 


><h1>Problem 5.	Count Symbols

Write a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order. 


><h1>Problem 6.	Wardrobe

Write a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following <b>format:

"{color} -> {item1},{item2},{item3}…"

If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. You can also receive repeating items for a certain color and you have to keep their count.

In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format:

"{color} {clothing}"

Your task is to print all the items and their count for each color in the following format: 

"{color} clothes:
* {item1} - {count}
* {item2} - {count}
* {item3} - {count}
…

* {itemN} - {count}"

If you find the item you are looking for, you need to print "(found!)" next to it:

"* {itemN} - {count} (found!)"

<b>Input

•	On the first line, you will receive n –  the number of lines of clothes, which you will receive.
•	On the next n lines, you will receive the clothes in the format described above.

<b>Output

•	Print the clothes from your wardrobe in the format described above.

><h1>Problem 7.	*The V-Logger

Create a program that keeps information about vloggers and their followers. The input will come as e sequence of strings, where each string will represent a valid command. The commands will be presented in the following format:

•	"{vloggername}" joined The V-Logger – keep the vlogger in your records.
o	Vloggernames consist of only one word.
o	If the given vloggername already exists, ignore that command.

•	"{vloggername} followed {vloggername}" – The first vlogger followed the second vlogger.
o	If any of the given vlogernames does not exist in you collection, ignore that command.

•	"Statistics" - Upon receiving this command, you have to print a statistic about the vloggers.

Each vlogger has an unique vloggername. Vloggers can follow other vloggers and a vlogger can follow as many other vloggers as he wants, but he cannot follow himself or follow someone he is already a follower of. You need to print the total count of vloggers in your collection. Then you have to print the most famous vlogger – the one with the most followers, with his followers. If more than one vloggers have the same number of followers, print the one following less people and his followers should be printed in lexicographical order (in case the vlogger has no followers, print just the first line, which is described below). Lastly, print the rest vloggers, ordered by the count of followers in descending order, then by the number of vloggers he follows in ascending order. The whole output must be in the following format:

"The V-Logger has a total of {registered vloggers} vloggers in its logs.
1. {mostFamousVlogger} : {followers} followers, {followings} following
*  {follower1}
*  {follower2} … 

{No}. {vlogger} : {followers} followers, {followings} following

{No}. {vlogger} : {followers} followers, {followings} following…"

<b>Input

•	The input will come in the format described above.

Output

•	On the first line, print the total count of vloggers in the format described above.

•	On the second line, print the most famous vlogger in the format described 
above.

•	On the next lines, print all of the rest vloggers in the format described above.

Constraints

•	There will be no invalid input.

•	There will be no situation where two vloggers have equal count of followers and equal count of followings

•	Allowed time/memory: 100ms/16MB.


><h1>Problem 8.	*Ranking

Write a program that ranks candidate-interns, depending on the points from the interview tasks and their exam results in SoftUni. You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests". Save that data because you will need it later. After that you will receive other type of inputs in format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". Here is what you need to do:

•	Check if the contest is valid (if you received it in the first type of input)

•	Check if the password is correct for the given contest

•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest. If you receive the same contest and the same user, update the points only if the new ones are more than the older ones.

At the end you have to print the info for the user with the most points in the format:

"Best candidate is {user} with total {total points} points.". After that print all students ordered by their names. For each user, print each contest with the points in descending order in the following format:

"{user1 name}

  {contest1} -> {points}

  {contest2} -> {points}
  
{user2 name}
…"

Input

•	You will be receiving strings in formats described above, until the appropriate commands, also described above, are given.	

Output

•	On the first line print the best user in the format described above. 

•	On the next lines print all students ordered as mentioned above in format.

Constraints

•	There will be no case with two equal contests.

•	The strings may contain any ASCII character except from (:, =, >).

•	The numbers will be in range [0 - 10000].

•	The second input is always valid.

•	There will be no case with 2 or more users with same total points.




