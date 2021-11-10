using System;
using System.Collections.Generic;

HashSet<int> nummer = new HashSet<int>();

nummer.Add(4);
nummer.Add(4);

nummer.Add(3);

Console.WriteLine(string.Join(",", nummer));

Console.ReadLine();


static void Hello()
{
  Console.WriteLine("HELLO");
}
static void GoodBye()
{
  Console.WriteLine("GOODBYE");
}

Dictionary<string, Action> actions = new Dictionary<string, Action>();

actions.Add("hi", Hello);
actions.Add("gbye", GoodBye);

actions["hi"]();

Queue<Action> alsoActions = new Queue<Action>();

alsoActions.Enqueue(Hello);




IceCream vanilla = new IceCream() {name = "Vanilla"};
IceCream chocolate = new IceCream() {name = "Chocolate"};

Dictionary<IceCream, IceCream> neighbors = new Dictionary<IceCream, IceCream>();

neighbors.Add(vanilla, chocolate);
neighbors.Add(chocolate, vanilla);

Console.WriteLine(neighbors[vanilla].name);

Console.ReadKey();



Dictionary<string, int> stats = new Dictionary<string, int>();

stats.Add("strength", 120);

Console.WriteLine(stats["strength"]);




List<string> names = new List<string>();

List<IceCream> iScream = new List<IceCream>();

iScream.Add(new IceCream());

iScream.RemoveAt(0);

Queue<string> orders = new Queue<string>();

orders.Enqueue("eat");
orders.Enqueue("sleep");
orders.Enqueue("game");
// orders.Enqueue("shout");


while (orders.Count > 0)
{
  string o = orders.Dequeue();
  Console.WriteLine(o);

  orders.Enqueue(o);
}


Console.ReadLine();
