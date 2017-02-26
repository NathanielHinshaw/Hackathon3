# Hackathon3

# Usage
when you run the exe file, you will note two controls on the right side.  one is a combo box with conditionals and constants,
one is used for outputs.  if you click on any of those images, a copy of that will spawn, you can drag that copy around.  if you drag it to the line on the left side of the screen,
it will hook on that line, and gain an attribute box below.

Scaling of window may be messed up,  it scaled perfectly to the laptop we were working from, but on my desktop it does not scale correctly.  this does not affect functionality of the python generation.

Attribute examples for types are as follows

Int

attribute box text = (a = 2)

Float

attribute box text = (a = 2.0)

String

attribute box text = (a = "test")

End

No attribute box, used for ending a conditional.

Conditionals

If/then  

attribute box text = (a == 5)

Else

No attribute box, follows an end from an if/then, expects end after else statement


While

attribute box text = (a == 5)


Outputs

Random

attribute box text = a in which a was defined as an integer

a will be set to a random value between 0 and 100

print

attribute box text = variable to be printed

edit

attribute box text = (a = 5)

edit is used for setting variables to other values where the variable was already defined

once the files are defined, clicking Generate python code will generate Output.py in C://BlockGen