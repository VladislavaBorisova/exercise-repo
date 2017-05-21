# exercise-repo
Exercises: Data Types and Variables
Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.

17** Cypher Roulette
You will be given an integer N. On the next N lines, you will receive some strings.
The strings will be either:
•	sequences of random characters
•	or the command - "spin"

If they are normal random characters, you should append them to one another in the cypher string.
If the command "spin" is entered, every string entered after it should be appended at the start
of the cypher string, if the command "spin" is entered again after that, you should again begin to append
them at the end of the cypher string. And so, the append direction changes each time you enter the command "spin".
If two equal strings are entered two consecutive times, the cypher resets - emptying the cypher string. This rule also applies to the "spin" command.
Note: the "spin" commands do not count towards the N count.
