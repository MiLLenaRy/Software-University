> # 	⦁	*Padawan Equipment
>Yoda is starting his newly created Jedi academy. 
So, he asked master Ivan Cho to buy the needed 
equipment. The number of items depends on how many
 students will sign up. The equipment for the 
 Padawan contains lightsabers, belts and robes.
 
>You will be given the amount of money Ivan Cho has, the number of students and the prices of each item. You have to help Ivan Cho calculate if the money he has is enough to buy all of the equipment, or how much more money he needs. 
Because the lightsabres sometimes brake, Ivan Cho should buy 10% more, rounded up to the next integer. Also, every sixth belt is free. 

***
><h2>Input / Constraints</h2>
>The input data should be read from the console. It will consist of exactly 5 lines:<p>
><li>The amount of money Ivan Cho has – floating-point number in range [0.00…1,000.00]
><li>The count of students – integer in range [0…100]
><li>The price of lightsabers for a single sabre – floating-point number in range [0.00…100.00]
><li>The price of robes for a single robe – floating-point number in range [0.00…100.00]
><li>The price of belts for a single belt – floating-point number in range [0.00…100.00]
><li>The input data will always be valid. There is no need to check it explicitly.

><h2>Output</h2>
>The output should be printed on the console.<p>
><li>If the calculated price of the equipment is less or equal to the money Ivan Cho has:
><li>"The money is enough - it would cost [the cost of the equipment]lv."
><li>If the calculated price of the equipment is more than the money Ivan Cho has:
><li> "Ivan Cho will need [neededMoney]lv more."
><li>All prices must be rounded to two digits after the decimal point.
