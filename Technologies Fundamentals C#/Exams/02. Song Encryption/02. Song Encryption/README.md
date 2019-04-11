> # 	⦁	Problem 02. Song Encryption
><em>Now that you've helped Mandy to accept the group applications it's time to assist her with a security problem. You are tasked to encrypt all songs from the set list so that if someone steals it they won't be able to leak it online.

>Your task is to write a program that encrypts information about artists and their songs.

>Until you receive the command "end" you should read lines in following format :"[artist]:[song]", and check if it's valid, considering the following rules:

><ul><b>Artist – starts with capital letter, followed by lowercase letters.</b>
><li>It can also contains apostrophe ( ' ), and whitespace " "; 
><li>Valid group name: Red hot chili peppers, Eminem, Guns n' roses
><li>Invalid group name: ReD Hot CiLly PePers, sLipKnot, guns n'roses

><ul><b>Song – contains only capital letters, and whitespaces.</b>
><li>Valid songs: BACK IN BLACK, BLEED IT OUT, KILLSHOT
><li>Invalid songs: #BaCk IN black, BLEED $IT$ OUTt, &KILLSHoT

>After you validate the lines of an input, you should encrypt the information. In order to do that, you have to follow the rules below:
><ul><b>First you need to find a key for encryption.</b>
><li>Your key is the length of the artist (e.g. "Eminem" –  key: 6)


><ul><b>You have to increment the ASCII value of each symbol of the input, with the key length</b>
>(e.g. "char" 'a' -> 'g')
><li>Be careful if your key length is bigger than the ASCII value of a letter 'z' or 'Z'. In this case you should start from a letter 'a'. (e.g. key:6 letter – 'x', encrypted letter – 'd')

><ul>You should NOT ENCRYPT the following characters: whitespaces, and apostrophes

><ul>You also should replace ':' with the sign '@'

><b>Input / Constraints
>
><li>Until you receive "end" command you should read from the console. 
><li>Line of input – Artist name and song, separated by ":", containing only ASCII symbols.
><li>Allowed working time for your program: 0.1 seconds.
><li>Allowed memory: 16 MB.

><b>Output
><ul>After every line of input, you should print:
><li>If line is valid – encrypted information in following format:</li>
>"Successful encryption: [encryptedArtist]@[encryptedSong]".
><li>If line is not valid – print the following message: "Invalid input!"