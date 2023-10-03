//Two Dimensional Array

Console.WriteLine("Two Dimensional Array:");
Console.WriteLine("\n");

string[,] books = new string[5, 5]
{
    { "1","2","3","4","5" },
     { "5","4","3","2","1" },
      { "1","2","3","4","5" },
       { "5","4","3","2","1" },
        { "1","2","3","4","5" }

};
Console.WriteLine(" " + books[0,0] +" " + books[0,1]+" "+books[0,2]+" " +books[0,3]+" "+books[0,4]);
Console.WriteLine(" " + books[1,0] +" " + books[1,1]+" "+books[1,2]+" " +books[1,3]+" "+books[1,4]);
Console.WriteLine(" " + books[2,0] +" " + books[2,1]+" "+books[2,2]+" " +books[2,3]+" "+books[2,4]);
Console.WriteLine(" " + books[3,0] +" " + books[3,1]+" "+books[3,2]+" " +books[3,3]+" "+books[3,4]);
Console.WriteLine(" " + books[4,0] +" " + books[4,1]+" "+books[4,2]+" " +books[4,3]+" "+books[4,4]);

//Another Two Dimensional Array

Console.WriteLine("\n");
Console.WriteLine("Another Example of Two Dimensional Array:");

int[,] arrayData = new int[3, 4]
{
    { 1,2,3,4},
    { 4,3,2,1},
    { 1,2,3,4}
};

Console.WriteLine("First Row & Column:");
Console.WriteLine(arrayData[0, 0] + " " + arrayData[0, 1] + " " + arrayData[0, 2] + " " + arrayData[0, 3]);

Console.WriteLine("Second Row & Column:");
Console.WriteLine(arrayData[1, 0] + " " + arrayData[1, 1] + " " + arrayData[1, 2] + " " + arrayData[1, 3]);

Console.WriteLine("Third Row & Column:");
Console.WriteLine(arrayData[2, 0] + " " + arrayData[2, 1] + " " + arrayData[2, 2] + " " + arrayData[2, 3]);

