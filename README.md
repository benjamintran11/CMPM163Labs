# CMPM163Labs
 
 Note: Video link can be found at bottom.
 
 Testing for alt. way of uploading pics:
<img src = "lab2/Screenshots/part1Cubes.png" width = "500">

Screenshots:
![](lab2/Screenshots/part1Cubes.png)

![](lab2/Screenshots/part2Props.png)

Link to video:
https://drive.google.com/file/d/1jjSBs7wMQEc73ecK3Vb8ikRhOYAnilbD/view?usp=sharing



Lab 3

Link to video: https://drive.google.com/file/d/12J9EPF8xuRI9jvutwWYIb-OVwM2H2WnF/view?usp=sharing

Screenshots:
![](lab3/Cubes4.png)

For lab 3, my first cube (cube) to the left is the default project one. It is just a cube that is using the three.js material.

The second cube (cube1) to the left, is the other tutorial example and is a a blue/purple shader cube. It colors change depending on it's location in the window, which changes because of the rotation, leading to it having a constant color change (stemming from the uniform lines we put in the lab3.html and the fragmentShader.frag files. 

The third cube (cube4), is the orange/purple cube which uses a custom shader I made, also using the points in the world (and due to rotation) changes colors. 

Finally, we have the last cube to the very right (cube2), which has a variety of effects, using: shininess, texture function (which I referenced off of the three.js site and have credited in my file) and is a red gradient consisting of many smaller squares, transparency, and color.  

Lab 4

Step 24 questions: 

a) What is a formula to get the x coordinate of the texture given a u value of the uv coordinate (a value between 0 and 1)?
x = floor (7u)

b) What is a formula to get the y coordinate of the texture given a v value of the uv coordinate (a value between 0 and 1)?
y = floor(7*(1-v))

c) What color is sampled from texture at the uv coordinate (0.375, 0.25)? (sample from the image based on the number your formula gives you i.e. (1, 0) (x, y) is blue)
(0.375, 0.25) = (2, 5)

so, x = 2 and y = 5.

