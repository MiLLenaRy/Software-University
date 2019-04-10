> # 	Problem 2. Deciphering
><em>Now that Gencho has filled his dictionary, he starts deciphering the old books to find in which one the relics and their locations are documented. 
>
><p>You will receive two lines. The first one will have an encrypted string, which you will have to decode. On the second line you will receive two letters or substrings, separated by a single space.
><p>First you will have to decode the first line by reducing the ASCII value of each character in it by 3. Then you should get the two substrings of the second line. You must find every occurrence of the first substring in the now decrypted text and replace it with the second substring.
><p>Also, you don't know which book you have taken, so you must check if it is valid. A valid text contains only lowercase letters, from 'd' onwards, and the symbols '{', '}', '|', '#'. If the text is invalid, you should not try to decipher it and you should print "This is not the book you are looking for.".

***
><h2>Input</h2><p>
><li>Two lines, one with text to decipher and one with two substrings to replace in the text.


><h2>Output</h2><p>
><li>One line with the deciphered text.
