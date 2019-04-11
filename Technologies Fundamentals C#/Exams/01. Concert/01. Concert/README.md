> # 	⦁	Problem 1 – Concert 
><em>Mandy was hired to accept the group applications for the upcoming concert. She thought that it would be easy but now she is in trouble. She needs a programmer to make an application that will help her to safe the concert. She needs you.

>You will read commands until you receive "start of concert" command.

>There are two types of commands:

><ul>There are two types of commands:
><li>"Add; [bandName]; [member 1], [member 2], [member 3]" - applies a band and a list of members to the concert. All members must be unique so don't add duplicates. If you receive the same band twice add only those members that aren't present in the list
><li>"Play; [bandName]; [time]" – the band with the given name plays an amount of time on the stage.  If you receive a band that has already applied in the concert, just increase the band time.

>If in both commands the band does not exist, add it.

>At the end you have to print the total time and the bands ordered by the time on stage in descending order, then by band name in ascending order. 

>Also the final input line will be "[bandName]" and you have to print all members for this band in insertion order.

><b>Input / Constraints
><li>The time of the bands – integer in range [0 – 231 - 1] 
><li>There will always be at least one member in the group
><li>The bands will always have time on stage
><li>The final input line will always contain an existing band name
><li>Input will always be valid and in the range specified. You don’t need to check it

><b>Output
><li>Total time: [totalTime]
><li>[firstBandName] -> [firstBandTime]
><li>[secondBandName] -> [secondBandTime]
><li>[thirdBandName] -> [thirdBandTime]

><li>[bandName]
><li>=> [firstMemberName]
><li>=> [secondMemberName]
><li>=> [thirdMemberName]
***
