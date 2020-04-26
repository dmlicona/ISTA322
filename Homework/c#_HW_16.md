##### __ISTA322__ 
##### _C#_HW16__

## *Denis Licona*
###### *2 Mar 2020* 

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
- NOT (~), left shift (<<), right shift (>>), or (|), and (&), XOR(^).

2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie C# code.
- Yes, there is. unit int x = 0b_1001; int y = x >> 2; before (1001) after (0010).

3. Explain in detail this code: bits & (1 << index);.
- Shifts 1 index numbers to the left and evaluates the return value where 1's match both. 

4. Explain in detail this code: bits |= (1 << index);.
- Shifts 1 index numbers to the left and evaluates the return value where 1's are turned on on either the result or bits, resulting in TRUE if any 1 evaluates. 

5. Explain in detail this code: bits &= (1 << index);.
- Shifts 1 index numbers to the left and evaluates the return value where 1's are turned on on both the result or bits, resulting in TRUE if any 1 evaluates, otherwise is false. 

6. How does C# interpret this? bool peek = bits[n];
- Assigns true or false to peek of binary value index n.

7. How does C# interpret this? bits[n] = true;
- Assigns the binary value 1 (true) to index n.

8. How does C# interpret this? bits[n] ^= true;
- XOR operator (^) inverts the value of the bit index n.

9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
* (a) permission = 0 - 0000 No permissions
* (b) permission = 1 - 0001 Read
* (c) permission = 2 - 0010 Write
* (d) permission = 3 - 0011 Read & Write
* (e) permission = 4 - 0100 Execute
* (f) permission = 5 - 0101 Read & Execute
* (g) permission = 6 - 0110 Write & Execute
* (h) permission = 7 - 0111 Read, Write & Exeute

10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?
- It tells me that ever "1" value gives an specific permission. 