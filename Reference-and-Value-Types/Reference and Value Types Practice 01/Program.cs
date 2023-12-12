//------Programa Principial------

// Define two numbers
int number01 = 5;
int number02 = 3;

//Print the values before swapping
Console.WriteLine("Values before swapping: {0} {1}", number01, number02);

// Save the content (copy) of number01 on temp
int temp = number01;
// now we can safely change the value of number01 since we have a copy of it in temp
number01 = number02;
