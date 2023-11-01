# Codility-ChocolatesByNumbers
Two positive integers N and M are given.</br>
Integer N represents the number of chocolates arranged in a circle, numbered from 0 to N − 1.</br>
You start to eat the chocolates.</br> 
After eating a chocolate you leave only a wrapper.</br>
You begin with eating chocolate number 0.</br> 
Then you omit the next M − 1 chocolates or wrappers on the circle, and eat the following one.</br>
More precisely, if you ate chocolate number X, then you will next eat the chocolate with number (X + M) modulo N (remainder of division).</br>
You stop eating when you encounter an empty wrapper.

For example, given integers N = 10 and M = 4.</br> 
You will eat the following chocolates: 0, 4, 8, 2, 6.</br>
The goal is to count the number of chocolates that you will eat, following the above rules.

Write a function:</br>
class Solution { public int solution(int N, int M); }</br>
that, given two positive integers N and M, returns the number of chocolates that you will eat.</br>
For example, given integers N = 10 and M = 4. the function should return 5, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N and M are integers within the range [1..1,000,000,000].
