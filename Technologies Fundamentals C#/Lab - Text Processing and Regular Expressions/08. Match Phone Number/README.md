> # ⦁	Match a Phone Number

>Write a regular expression to match a valid phone number from Sofia. After you find all of the valid phones, print them on the console, separated by a comma and a space “, ”.

> <h2> Compose the Regular Expression</h2>
>A valid number has the following characteristics:
*	It starts with "+359"
*	Then, it is followed by the area code (always 2)
*	After that, it’s followed by the number itself:
*	The number consists of 7 digits (separated in two groups of 3 and 4 digits respectively). 
*	The different parts are separated by either a space or a hyphen ('-').
>You can use the following RegEx properties to help with the matching: 
*	Use quantifiers to match a specific number of digits
*	Use a capturing group to make sure the delimiter is only one of the allowed characters (space or hyphen) and not a combination of both (e.g. +359 2-111 111 has mixed delimiters, it is invalid). Use a group backreference to achieve this.
*	Add a word boundary at the end of the match to avoid partial matches (the last example on the right-hand side).
*	Ensure that before the '+' sign there is either a space or the beginning of the string.


***
