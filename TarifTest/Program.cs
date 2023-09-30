// See https://aka.ms/new-console-template for more information
using TestLib;
using TestLib2;

Test1 test1 = new Test1();
test1.GetItemsFromJson("C:\\Users\\DEXP\\source\\repos\\TarifTest\\TarifTest\\test.json");
Console.WriteLine(test1.Process());
Test2 test2 = new Test2();
test2.DoSomething();