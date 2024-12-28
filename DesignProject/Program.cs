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

TestTask ts = new TestTask();

await ts.Awaitable();

Common common = new Common();

common.GiveListPrime(10);
common.DistinctByandExceptBy();


Console.WriteLine("Hello, World!");

DapperContext dapperContext = new DapperContext();

dapperContext.GetValues();

ClientCodeNew(new ConcreteCreatorA());

Person person = new Person();

person.Id = 2;
person.name = "Test";
person.student = new Student(4);

//Subject subject = new Subject("This is a new memento");

//History hs = new History(subject);
//hs.Backup();

common.GetFibonicciSeries(10);
common.GetNthFibonicciNumber(5);
common.SwapWithoutTemp(1, 2);
common.CountOccurence(3, 1383339);
common.ReverseNumber(13839);
common.Array2Dimensional();
common.Reverse2DArray(new int[,] { { 1, 2, 3 }, { 2, 3, 1 } });
common.Reverse3DArray(new int[,,] { { {1,2 }, {3,4 } }, { {2,5 }, {6,7 } } });
common.JaggedArray();
common.FindMax(new int[] { 1, 2, 3, 5, 6, 7 });
common.CountEvenIntegers();
common.ReverseArrayWithDiffTeq();
common.BinarySearch(25);
common.FindCielingOrFloor(6,false);
common.FindCielingOrFloorOfCharacter('d', true);
common.FindInMountainArray(4);
common.FindPeakInCircularArray();
common.FindPeakDuplicateCircularArray();
common.FindIn2DArrayBinarySearch(8);
common.BubbleSort();
common.CreatePatterns();
common.CyclicSort();
var dd = common.PrintFibo(4);

int[] arr = new int[] { 2, 3, 4, 5, 6, 7, 8 };
int mid =  common.RecursiveBinarySearch(6,0,arr.Length -1 , arr);



Person p2 = person.ShallowClone();

person.Id = 3;
person.name = "test3";
person.student = new Student(4);

AuthenticationHandler au = new AuthenticationHandler();
AuthorizationHandler at = new AuthorizationHandler();
au.SetNext(at);

var requests = "au";
au.Handle(requests);

Request request = new Request();

request.Message = "text";

// Usage

TestTask task = new TestTask();

await task.TestTasks();

await
    task.Awaitable();


task.GetResult();

var prop = new Property(new string[] {"Avi", "kumar"});

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

Client client = new Client();

Composite tree = new Composite();


Observer ob = new Observer();

ob.TestEvent();


Leaf leaf = new Leaf();
client.DoOperation1(leaf);
Composite branch = new Composite();
Composite branch2 = new Composite();
branch2.Add(new Leaf());
branch.Add(new Leaf());
branch.Add(new Leaf());

tree.Add(branch);
tree.Add(branch2);
client.DoOperation1(tree);






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






void ClientCodeNew(CreatorNew creator)
{
    creator.getProduct().Operation();
}