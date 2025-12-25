// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.CursorVisible = false;
var strSpaces = new String(' ', 80);
var strLine = "Hello World!!! Running String!!! Press Any Key To Exit!!!";
strLine = strSpaces + strLine + strSpaces;
var nCounter = 0;
var nStrLen = strLine.Length - 80;
do
{
    strSpaces = strLine.Substring(nCounter, 80);
    Console.SetCursorPosition(10, 10);
    Console.Write(strSpaces);
    Thread.Sleep(140);
    nCounter++;
    if(nCounter >= nStrLen) nCounter = 0;
} while (!Console.KeyAvailable);
