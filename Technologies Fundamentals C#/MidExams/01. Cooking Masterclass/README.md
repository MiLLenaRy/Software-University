> # 	Problem 1. Cooking Masterclass
>George is starting his own course, a Cooking Masterclass. So, he asked you to buy the needed items. The number of items depends on how many students will sign up for the course. The educational set for one student consists of 1 package of flour, 10 eggs and an apron. 
><p>You will be given George`s budget, the number of students signed and the prices of each item. You have to help George calculate if the budget is enough to buy all of the items, or how much more money he needs. 
 ><p>Because the aprons get dirty often, George should buy 20% more, rounded up to the next integer. Also, every fifth package of flour is free. 
 ><p>
 ><p>
 ><p>
***
><h2>Input / Constraints</h2><p>
><ul>The input data will consist of exactly 5 lines:
><li>budget – floating-point number in range [0.00…1,000.00]
><li>students – integer in range [0…100]
><li>price of flour for a package – floating-point number in range [0.00…100.00]
><li>price of egg for a single egg – floating-point number in range [0.00…100.00]
><li>price of apron for a single apron – floating-point number in range [0.00…100.00]

><ul>The input data will always be valid. There is no need to check it explicitly. 

><ul>* If you are using JavaScript, you receive the input as an array with 5 elements: [budget, students, flour, egg, apron]

><h2>Output</h2><p>
><ul>The output should be printed on the console.
><li>If the calculated price of the items is less or equal to the budget:
><li>"Items purchased for {the cost of the items}$."
><li>If the calculated price is more than the budget:
><li> "{neededMoney}$ more needed."
><li>All prices must be rounded to two digits after the decimal point.
