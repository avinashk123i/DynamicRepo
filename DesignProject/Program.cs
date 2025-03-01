// See https://aka.ms/new-console-template for more information
using DesignProject;
using DesignProject.Abstract;
using DesignProject.Algo;
using DesignProject.Builder;
using DesignProject.DesignPatterns.Behavior.ChainOfResponsiblity;
using DesignProject.DesignPatterns.Behavior.Iterator;
using DesignProject.DesignPatterns.Behavior.Mediator;
using DesignProject.DesignPatterns.Behavior.Memento;
using DesignProject.DesignPatterns.Behavior.Oberver;
using DesignProject.DesignPatterns.Creational.Prototype;
using DesignProject.DesignPatterns.Structural.Composite;
using DesignProject.SampleDeadlock;
using DesignProject.TaskUnderstanding;
using System.Net.WebSockets;
using File = DesignProject.DesignPatterns.Structural.Composite.File;





Class1 c = new Class1();

c.GetFrequency("Patient has sever headache, every 20 mins & vomiting 3-4 times!");


FiveHundredNoteDispenser dispenser1 = new FiveHundredNoteDispenser();
TwoHundredNoteDispenser dispenser2 = new TwoHundredNoteDispenser();

dispenser1.SetNext(dispenser2);
dispenser2.SetNext(new HundredNoteDispenser());

dispenser1.DispenseCash(5200);

File file1 = new File("System.txt");
File file2 = new File("Advancedata.txt");

Folder folder = new Folder("Root");
Folder subfolder = new Folder("SubFolder");

folder.add(subfolder);
subfolder.add(file1);
subfolder.add(file2);


folder.Display();




TestTask ts = new TestTask();

await ts.Awaitable();





Common common = new Common();
common.GetCommonList(new List<int>() { 1, 2, 2, 3 }, new List<int>() { 2, 3, 4 });











common.GetDistinct(new int[] { 1, 2, 2, 2, 3, 3, 3, 4, 5 });
var dd = common.PrintFibo(4);
common.MergeSort(new int[] { 1, 5, 2, 3, 7 });
common.findDataInGivenArray();
common.DistinctByandExceptBy();


common.GiveListPrime(10);

common.SelectionSort();
Console.WriteLine("Hello, World!");

DapperContext dapperContext = new DapperContext();

dapperContext.GetValues();

ClientCodeNew(new RoadTransport());

Person person = new Person();

person.Id = 2;
person.name = "Test";
person.student = new Student(4);

//Subject subject = new Subject("This is a new memento");

//History hs = new History(subject);
//hs.Backup();

#region Algo

common.DifferentwaysForDuplicates();
common.ReverseWithDiff();
common.RotateArray(3);
common.ReverseNumber(132);
common.GetFibonicciSeries(10);
common.GetNthFibonicciNumber(5);
common.SwapWithoutTemp(1, 2);
common.CountOccurence(3, 1383339);

common.Array2Dimensional();
common.Reverse2DArray(new int[,] { { 1, 2, 3 }, { 2, 3, 1 } });
common.Reverse3DArray();

var arr2 = new int[2][]
{
    new int[]{1,2,3,4},
    new int[]{2,3}
};

common.JaggedArray();
common.FindMax(new int[] { 1, 2, 3, 5, 6, 7 });
common.CountEvenIntegers();
common.ReverseArrayWithDiffTeq();
common.BinarySearch(25);
common.FindCielingOrFloor(6, false);
common.FindCielingOrFloorOfCharacter('d', true);
common.FindInMountainArray(4);
common.FindPeakInCircularArray();
common.FindPeakDuplicateCircularArray();
common.FindIn2DArrayBinarySearch(8);
common.BubbleSort();
common.CreatePatterns();
common.CyclicSort();

int[] arr = new int[] { 2, 3, 4, 5, 6, 7, 8 };
int mid = common.RecursiveBinarySearch(6, 0, arr.Length - 1, arr);
#endregion


Person p2 = person.ShallowClone();

person.Id = 3;
person.name = "test3";
person.student = new Student(4);


Request request = new Request();

request.Message = "text";

// Usage

TestTask task = new TestTask();


await
    task.Awaitable();


task.GetResult();

var prop = new Property(new string[] { "Avi", "kumar" });

var enumerator = prop.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}



DeadLock dl = new DeadLock();

dl.taskall();


Subject subject = new Subject();

subject.text = "Abcddddd";
History history = new History();

history.SaveState(subject.Save());
subject.text = "Bcd";

subject.RestoreState(history.RestoreState());
Console.WriteLine(subject.text);


Observer ob = new Observer();

ob.TestEvent();






Console.WriteLine(person.name);
Console.WriteLine(person.Id);
Console.WriteLine(p2.name);
Console.WriteLine(p2.Id);

var p4 = person;
var p5 = person.ShallowClone();

person.name = "sfdf";


Console.WriteLine(p4.name);

Console.WriteLine(p5.name);




Director director = new Director();
ConcreteBuilder builder = new ConcreteBuilder();
director.builder = builder;

director.BuildFullPerson();

Console.WriteLine(builder.Build().Address);

Console.WriteLine(person.Id + " " + p2.Id + "" + person.name + p2.name);






void ClientCodeNew(Transport creator)
{
    creator.GetLogistics().Deliver();
}