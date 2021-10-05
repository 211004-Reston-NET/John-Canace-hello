\# This is a comment to add more information to your code

echo Hello
echo World

msg="Hello World"

echo $msg

echo What is your name?
read userInput
echo "Hello $userInput, Welcome to Programming!"

# Control Flow
#Types of loops
#For loop - They will repeat something a set number of times
for var in 1 2 3 4 5 
do
	echo $var
	echo This variable currently holds: $var
done

#While loops - they will repeat something until the condition isn't satisfied anymore
condition="true"

while [ "$condition" != "false" ]
do
	echo "Do you want to repeat? (true or false)"
	read condition
	echo "You typed: $condition"

done

if [ "1" -gt "100" ]
then
	echo Hey that\'s a large number.

fi
