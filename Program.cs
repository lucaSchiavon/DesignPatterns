using System;
using DesignPatterns.Patterns.Creational;
using DesignPatterns.Patterns.Structural;
using DesignPatterns.Patterns.Structural.Composite;
using FM=DesignPatterns.Patterns.Creational.FM;
using CodeWithMosh= DesignPatterns.Patterns.CodeWithMosh;
using ExercizeWithMosh=DesignPatterns.Patterns.CodeWithMosh.Exercize;
using System.Collections.Generic;
using DesignPatterns.Patterns.CodeWithMosh.State.Exercise;
using DesignPatterns.Patterns.CodeWithMosh.State;
using Iterator= DesignPatterns.Patterns.CodeWithMosh.Iterator;
using IteratorExercise = DesignPatterns.Patterns.CodeWithMosh.Iterator.Exercise;
using DesignPatterns.Patterns.CodeWithMosh.Strategy;
using DesignPatterns.Patterns.CodeWithMosh.Strategy.Exercise;
using DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Soluz1StrategyPattern;
using DesignPatterns.Patterns.CodeWithMosh.TemplateMethod.Exercise;
using Memento = DesignPatterns.Patterns.CodeWithMosh.Behavioural.Memento;
using Command=DesignPatterns.Patterns.CodeWithMosh.Command;
using CompositeCommand = DesignPatterns.Patterns.CodeWithMosh.Behavioural.Command.CompositeCommand;
using CommandUndo=DesignPatterns.Patterns.CodeWithMosh.Command.MakingUndo;
using Observer = DesignPatterns.Patterns.CodeWithMosh.Observer;
using ObserverPassingValue=DesignPatterns.Patterns.CodeWithMosh.Observer.Passing_Value;
using Mediator=DesignPatterns.Patterns.CodeWithMosh.Mediator;
using MediatorUsingObserver = DesignPatterns.Patterns.CodeWithMosh.Mediator.UsingObserver;
using Chain=DesignPatterns.Patterns.CodeWithMosh.Chain;
using Visitor=DesignPatterns.Patterns.CodeWithMosh.Visitor;
using Composite = DesignPatterns.Patterns.CodeWithMosh.Structural.Composite;
using CompositeExercise = DesignPatterns.Patterns.CodeWithMosh.Structural.Composite.Exercise;
using Adapter = DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter;
using AdapterExercise = DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Exercise;
using Decorator = DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator;
using DecoratorSolution = DesignPatterns.Patterns.CodeWithMosh.Structural.Decorator.Solution;
using Facade = DesignPatterns.Patterns.CodeWithMosh.Structural.Facade;
using FacadeExercise = DesignPatterns.Patterns.CodeWithMosh.Structural.Facade.Exercise;
using Flyweight = DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight;
using BridgeSolution = DesignPatterns.Patterns.CodeWithMosh.Structural.Bridge.Solution;
using Proxy = DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy;
using ProxyExercise=DesignPatterns.Patterns.CodeWithMosh.Structural.Proxy.Exercise;
    using FlyweightExercise = DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise;
using FlyweightExerciseSolution = DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise.Solution;
using DesignPatterns.Patterns.CodeWithMosh.Behavioural.State.ClockExample;
using DesignPatterns.General;
using DesignPatterns.Libro.Creational.Prototype;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Creational"

            //    //*********************************************************
            //    //singleton
            //     //OBBLIGA AD ISATNZIARE UNA SOLA ISTANZA
            //    //https://www.dofactory.com/net/singleton-design-pattern
            //    // Constructor is protected -- cannot use new

            //    Singleton s1 = Singleton.Instance();
            //    Singleton s2 = Singleton.Instance();

            //    // Test for same instance

            //    if (s1 == s2)
            //    {
            //        Console.WriteLine("Objects are the same instance");
            //    }

            ////*********************************************************
            ////prototype
            ////PERMETTE DI CLONARE SE STESSO MEDIANTE UN METODO CLONE
            ////https://www.dofactory.com/net/prototype-design-pattern
            ////Prototype pattern in which new objects are created by copying pre-existing objects (prototypes) of the same class.

            //ConcretePrototype1 p1 = new ConcretePrototype1("I");
            //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            //Console.WriteLine("Cloned: {0}", c1.Id);
            //bool res = p1.Equals(c1);

            //bool res2 = p1.Equals(p1);

            //ConcretePrototype2 p2 = new ConcretePrototype2("II");
            //ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            //Console.WriteLine("Cloned: {0}", c2.Id);

            //prototype3
            //Developer dev = new Developer();
            //dev.Name = "Rahul";
            //dev.Role = "Team Leader";
            //dev.PreferredLanguage = "C#";

            //Developer devCopy = (Developer)dev.Clone();
            //devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            //Console.WriteLine(dev.GetDetails());
            //Console.WriteLine(devCopy.GetDetails());

            //Typist typist = new Typist();
            //typist.Name = "Monu";
            //typist.Role = "Typist";
            //typist.WordsPerMinute = 120;
            //Typist sub = new Typist();
            //sub.Name = "Meo";
            //sub.Role = "Typist";
            //sub.WordsPerMinute = 130;
            //typist.Substitute = sub;

            ////make a deep copy of typist
            //Typist typistCopy = (Typist)typist.Clone();
            //typistCopy.Substitute = null;
            //typistCopy.Name = "Sahil";
            //typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            //Console.WriteLine(typist.GetDetails());
            //Console.WriteLine(typistCopy.GetDetails());


            ////*********************************************************
            ////Builder
            ////https://www.dofactory.com/net/builder-design-pattern
            //    // Create director and builders
            //    //(è un costruttore di componenti, il director usa il metodo construct per lanciare il builder che costruira i componenti e li associerà al prodotto)

            //    Director director = new Director();

            //    Builder b1 = new ConcreteBuilder1();
            //    Builder b2 = new ConcreteBuilder2();





            //    // Construct two products

            //    director.Construct(b1);
            //    Product pr1 = b1.GetResult();
            //    pr1.Show();

            //    director.Construct(b2);
            //    Product pr2 = b2.GetResult();
            //    pr2.Show();

            //animal builder
            //Animal anm = AnimalBuilder.NewBuilder("1")
            //    .Name("elefante")
            //    .PedigreeName("abc")
            //     .Owner("Carlo").Build();

            // Wait for user

            //    //*********************************************************
            //    //Abstract factory
            //    //https://www.dofactory.com/net/abstract-factory-design-pattern
            //    // Abstract factory #1
            //    //PERMETTE DI CREARE FAMIGLIE DI OGGETTTI MEDIANTE LA CLASSE ASTRATTA E QUINDI SEBBENE GLI OGGETTI SIANO DIVERSI
            //    //LE INTERAZIONI (DEFINITE NELLA CLASSE ASTRATTA DELL'OGGETTO) RIMANGONO LE STESSE:
            //    //abstract class Carnivore

            //    //{
            //    //    public abstract void Eat(Herbivore h);
            //    //}
            //    //OSSIA:
            //        //abstract class AbstractProductB

            //        //{
            //        //    public abstract void Interact(AbstractProductA a);
            //        //}
            //AbstractFactory factory1 = new ConcreteFactory1();
            //    Client client1 = new Client(factory1);
            //    client1.Run();

            //    // Abstract factory #2

            //    AbstractFactory factory2 = new ConcreteFactory2();
            //    Client client2 = new Client(factory2);
            //    client2.Run();

            //    //*********************************************************
            //    //FactoryMethod
            //    //https://www.dofactory.com/net/factory-method-design-pattern
            //    // An array of creators

            //    FM.Creator[] creators = new FM.Creator[2];

            //    creators[0] = new FM.ConcreteCreatorA();
            //    creators[1] = new FM.ConcreteCreatorB();

            //    // Iterate over creators and create products

            //    foreach (FM.Creator creator in creators)
            //    {
            //        FM.Product product = creator.FactoryMethod();
            //        Console.WriteLine("Created {0}",
            //          product.GetType().Name);
            //    }
            #endregion

            #region "structural"
            //////*************************************************************************
            //////Facade
            ///////PROVVEDE A FORNIRE UNA UNICA INTERFACCIA UNIFORME PER GESTIRE UN SOTTOINSIEME GRANDE DI CLASSI
            ////// Provide a unified interface to a set of interfaces in a subsystem
            ////Facade facade = new Facade();

            ////facade.MethodA();
            ////facade.MethodB();

            ////*************************************************************************
            ////Decorator
            //// Create ConcreteComponent and two Decorators

            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //// Link decorators

            //d1.SetComponent(c);
            //d1.Operation();
            //d2.SetComponent(d1);

            //d2.Operation();
            //////*************************************************************************
            //////Proxy
            /////PERMETTE DI WRAPPARE LA CHIAMATA DI UN OGGETTO DENTRO UN ALTRO OGGETTO SIMILE
            //// Create proxy and request a service
            ////*************************************************************************
            //Proxy proxy = new Proxy();
            //proxy.Request();

            //////*************************************************************************
            //////Adapter
            ///////mappa l'interfaccia di una classe dentro un'altra in modo che possano lavorare insieme o che
            ///////una sostituisca l'altra
            //// Create adapter and place a request
            ////*************************************************************************



            //Target target = new Adapter();
            //target.Request();



            //////*************************************************************************
            ////Compose
            ////crea un albero ricrsivo di oggetti ed un oggetto foglia che stoppa la possibilità
            /////di ulteriori alberature
            ///*************************************************************************
            // Create a tree structure

            //Composite root = new Composite("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));

            //Composite comp = new Composite("Composite X");
            //comp.Add(new Leaf("Leaf XA"));
            //comp.Add(new Leaf("Leaf XB"));

            //root.Add(comp);
            //root.Add(new Leaf("Leaf C"));

            //// Add and remove a leaf

            //Leaf leaf = new Leaf("Leaf D");
            //root.Add(leaf);
            //root.Remove(leaf);

            //// Recursively display tree

            //root.Display(1);

            //////*************************************************************************
            ////Bridge
            ///*************************************************************************

            //Abstraction ab = new RefinedAbstraction();

            //// Set implementation and call

            //ab.Implementor = new ConcreteImplementorA();
            //ab.Operation();

            //// Change implemention and call

            //ab.Implementor = new ConcreteImplementorB();
            //ab.Operation();

            #endregion

            #region "Mosh code"
            //*********************************************
            //BEHAVIOURAL PATTERNS

            //memento pattern
            //var Editor = new Memento.Editor();
            //var History = new Memento.History();
            //Memento.Button btn = new Memento.Button() { Content = "a", Title = "tita" };
            //Editor.Button = btn;
            //History.Push(Editor.CreateState());
            //Memento.Button btn2 = new Memento.Button() { Content = "b", Title = "titb" };
            //Editor.Button = btn2;
            //History.Push(Editor.CreateState());
            //Memento.Button btn3 = new Memento.Button() { Content = "c", Title = "titc" };
            //Editor.Button = btn3;
            //Editor.Restore(History.Pop());
            //Editor.Restore(History.Pop());

            //Console.WriteLine(Editor.Button.Content);


            //var Document = new ExercizeWithMosh.Document();
            //var History2 = new ExercizeWithMosh.History();
            //Document.SetRecord(new List<string>() { "content1", "fontname1", "fontsize1" });
            //History2.Push(Document.CreateState());
            //Document.SetRecord(new List<string>() { "content2", "fontname2", "fontsize2" });
            //History2.Push(Document.CreateState());
            //History2.Pop();
            //ExercizeWithMosh.DocumentState DcoumentState = History2.Pop();
            //Document.Restore(DcoumentState);

            //Console.WriteLine(Document.GetRecord()[0]);


            ////state pattern
            //Canvas canvas = new Canvas(new BrushTool());
            //canvas.mouseDown();
            //Canvas canvas2 = new Canvas(new SelectionTool());
            //canvas2.mouseDown();
            ////esercizio
            //DirectionService DirectionService = new DirectionService(new BiciclingTravel());
            //DirectionService DirectionService2 = new DirectionService(new TransitTravel());
            //object dirTransit = DirectionService.getDirection();
            //object etaTransit = DirectionService.getEta();

            //object dirTransit2 = DirectionService2.getDirection();
            //object etaTransit2 = DirectionService2.getEta();

            //clockstate
            //l'orologio cliccando sul bottone mode permette ora di accendere la luce
            //ora di settare i minuti
            //ora le ore
            //Clock clock = new Clock();
            //clock.ChangeButton();
            //clock.ModeButton();
            //clock.ChangeButton();
            //clock.ModeButton();
            //clock.ChangeButton();
            //clock.SetState(new NormalDisplayState(clock));

            //iterator pattern
            //var BrowseHistory = new Iterator.BrowseHistory();
            //BrowseHistory.Push("a");
            //BrowseHistory.Push("b");
            //BrowseHistory.Push("c");

            //Iterator.IIterator<string> Iterator = BrowseHistory.CreateIterator();
            //while (Iterator.HasNext())
            //{
            //    Console.WriteLine(Iterator.Current());
            //    Iterator.Next();
            //}


            //IteratorExercise.ProductCollection ProductCollection = new IteratorExercise.ProductCollection();
            //ProductCollection.Add(new IteratorExercise.Product(1, "a"));
            //ProductCollection.Add(new IteratorExercise.Product(2, "b"));
            //Iterator.IIterator<IteratorExercise.Product> Iterator2 = ProductCollection.CreateIterator();
            //while (Iterator2.HasNext())
            //{
            //    IteratorExercise.Product Product = Iterator2.Current();
            //    Iterator2.Next();
            //}


            ////Strategy pattern
            //var ImageStorage = new ImageStorage(new JpgCompressor(),new ContrastFilter());
            //ImageStorage.Store("a");


            //var ChatClient = new ChatClient(new AesEncriptor());

            //ChatClient.send("a");



            ////Template method pattern
            //TaskExecutor TaskExecutor = new TaskExecutor(new TransferMoney(), new AuditTrailOnDB());

            //TaskExecutor.Execute();




            //CodeWithMosh.TemplateMethod.Soluz2StrategyPattern.TransferMoney TransferMoney =
            //new CodeWithMosh.TemplateMethod.Soluz2StrategyPattern.TransferMoney(new AuditTrailOnDB());
            //TransferMoney.Execute();


            //DashboardWindow dw = new DashboardWindow();
            //dw.Close();


            //Command pattern
            //Command.CustomerService CustomerService = new Command.CustomerService();
            //Command.AddCustomerCommand addCustomerCommand = new Command.AddCustomerCommand(CustomerService);
            //Command.Button Button = new Command.Button(addCustomerCommand);
            //Button.click();


            //Composite command
            //CompositeCommand.CompositeComand compComm = new CompositeCommand.CompositeComand();
            //CompositeCommand.BlackAndWhiteComand bwc = new CompositeCommand.BlackAndWhiteComand();
            //CompositeCommand.ResizeComand rc = new CompositeCommand.ResizeComand();
            //compComm.Add(bwc);
            //compComm.Add(rc);
            //compComm.Execute();

            //////command undo pattern
            //CommandUndo.History Hystory = new CommandUndo.History();
            //CommandUndo.HtmlDocument document = new CommandUndo.HtmlDocument();
            //CommandUndo.BoldComand boldComand = new CommandUndo.BoldComand(document, Hystory);
            //document.content = "test";
            //boldComand.Execute();
            //Console.WriteLine(document.content);
            ////non chiamiamo direttamente questo perchè abbiamo un undocomand apposito
            ////boldComand.Unexecute();
            //CommandUndo.UndoCommand undoCommand = new CommandUndo.UndoCommand(Hystory);
            //undoCommand.Execute();
            //Console.WriteLine(document.content);


            //Observer.DataSource dataSourceOb = new Observer.DataSource();


            //dataSourceOb.AddObserver(new Observer.SpreadSheet(dataSourceOb));
            //dataSourceOb.AddObserver(new Observer.Chart(dataSourceOb));

            //dataSourceOb.Value = 5;

            ////observer passing value worst
            //ObserverPassingValue.DataSource dataSource = new ObserverPassingValue.DataSource();
            //dataSource.AddObserver(new ObserverPassingValue.SpreadSheet());
            //dataSource.AddObserver(new ObserverPassingValue.Chart());
            //dataSource.Value = 8;
            //mediator pattern


            //Mediator.ArticlesDialogBox articlesDialogBox = new Mediator.ArticlesDialogBox();

            //articlesDialogBox.SimulateSelection();


            //MediatorUsingObserver.ArticlesDialogBox articlesDialogBox = new MediatorUsingObserver.ArticlesDialogBox();
            //articlesDialogBox.
            //articlesDialogBox.SimulateSelection();


            ////Chain pattern
            //Chain.Compressor Compressor = new Chain.Compressor(next: null);
            //Chain.Autenticator Autenticator = new Chain.Autenticator(next: Compressor);
            //Chain.WebServer WebServer = new Chain.WebServer(Autenticator);
            //WebServer.Handle(new Chain.HttpRequest("1234", "admin"));


            //Visitor
            //var document = new Visitor.HtmlDocument();
            //document.add(new Visitor.HeadingNode());
            //document.add(new Visitor.AnchorNode());
            //Visitor.HighlightOperation highlightOperation = new Visitor.HighlightOperation();
            //Visitor.ExtractTextOperation ExtractTextOperation = new Visitor.ExtractTextOperation();
            //document.Execute(highlightOperation);
            //document.Execute(ExtractTextOperation);



            //*********************************************
            //STRUCTURAL PATTERNS

            //COMPOSITE PATTERN

            //Composite.Group group1 = new Composite.Group();
            //group1.Add(new Composite.Shape());
            //group1.Add(new Composite.Shape());

            //Composite.Group group2 = new Composite.Group();
            //group2.Add(new Composite.Shape());
            //group2.Add(new Composite.Shape());

            //Composite.Group group = new Composite.Group();
            //group.Add(group1);
            //group.Add(group2);

            //group.Render();


            //solution
            Composite.Solution.Group groupSol1 = new Composite.Solution.Group();
            groupSol1.Add(new Composite.Solution.Shape());
            groupSol1.Add(new Composite.Solution.Shape());

            Composite.Solution.Group groupSol2 = new Composite.Solution.Group();
            groupSol2.Add(new Composite.Solution.Shape());
            groupSol2.Add(new Composite.Solution.Shape());

            Composite.Solution.Group groupSol = new Composite.Solution.Group();
            groupSol.Add(groupSol1);
            groupSol.Add(groupSol2);

            groupSol.Render();
            groupSol.Move();

            ////exercise


            //CompositeExercise.Camion camion = new CompositeExercise.Camion("Camion1");
            //camion.Add(new CompositeExercise.Pompiere());
            //camion.Add(new CompositeExercise.Pompiere());
            //CompositeExercise.Team subTeam = new CompositeExercise.Team("SubTeam1");
            //subTeam.Add(camion);
            //CompositeExercise.Team team = new CompositeExercise.Team("Team1");

            //CompositeExercise.Camion camion2 = new CompositeExercise.Camion("Camion2");
            //camion2.Add(new CompositeExercise.Pompiere());
            //camion2.Add(new CompositeExercise.Pompiere());
            //CompositeExercise.Team subTeam2 = new CompositeExercise.Team("SubTeam2");
            //subTeam2.Add(camion2);


            //team.Add(subTeam);
            //team.Add(subTeam2);
            //team.Schiera();
            ////Adapter pattern
            //Adapter.ImageView imageView = new Adapter.ImageView(new Adapter.Image());
            //imageView.Apply(new Adapter.VividFilter());
            ////imageView.Apply(new Adapter.avaFilter.Caramel());
            //imageView.Apply(new Adapter.Solution.CaramelFilter(new Adapter.avaFilter.Caramel()));


            //exercise
            //AdapterExercise.EmailManager emailManager = new AdapterExercise.EmailManager(new AdapterExercise.Server());
            //emailManager.Connect(new AdapterExercise.EmailClient());
            ////emailManager.Connect(new AdapterExercise.GMailClient());
            //emailManager.Connect(new AdapterExercise.GMailClientAdapter(new AdapterExercise.GMailClient()));
            ////Decorator pattern
            //Decorator.CloudStream cloudStream = new Decorator.CloudStream();
            //cloudStream.Write("alcuni dati");
            //Decorator.EncriptedStream EncriptedStream = new Decorator.EncriptedStream();
            //EncriptedStream.Write("alcuni dati");
            //cloudStream.Write("test");
            //encriptedStreamSol.Write("test");
            //CompressStreamSol.Write("test");

            // Solution:
            //DecoratorSolution.CloudStream cloudStream = new DecoratorSolution.CloudStream();
            //cloudStream.Write("aaa");
            //DecoratorSolution.EncriptedStream encriptedStreamSol = new DecoratorSolution.EncriptedStream(cloudStream);
            //encriptedStreamSol.Write("aaa");
            //DecoratorSolution.CompressStream CompressStreamSol = new DecoratorSolution.CompressStream(cloudStream);
            //CompressStreamSol.Write("aaa");

            //StoreCreditCard(new DecoratorSolution.EncriptedStream (new DecoratorSolution.CompressStream(new DecoratorSolution.CloudStream())));

            ////facade pattern
            //Facade.NotificationServer notificationServer = new Facade.NotificationServer();
            //var connection = notificationServer.Connect("10.0.1.3");
            //var token = notificationServer.Authenticate("appid", "2837");
            //notificationServer.Send(token, new Facade.Message("messaggio"),"Target");
            //connection.Disconnect();


            ////solution

            //Facade.Solution.NotificationService notificationService = new Facade.Solution.NotificationService();
            //notificationService.send("il messaggio", "Il target");


            //exercise
            //FacadeExercise.TweetService tweetService = new FacadeExercise.TweetService();
            //List<FacadeExercise.Tweet> tweets=tweetService.GetTweet();
            //tweetService.NewTweet(new FacadeExercise.Tweet() {  Message="Nuovo tweet" });
            //tweetService.LikeTweet(tweets[0]);

            ////Fightweight pattern
            //Flyweight.PointService pointService = new Flyweight.PointService();
            //List<Flyweight.Point> points= pointService.GetPoints();
            //points.ForEach(x => x.Draw());

            ////Soluzione
            //Flyweight.Solution.PointService pointService2 = new Flyweight.Solution.PointService(new Flyweight.Solution.PointIconFacotry());
            //List<Flyweight.Solution.Point> points2 = pointService2.GetPoints();
            //points2.ForEach(x => x.Draw());

            //Exercise
            //FlyweightExercise.Demo.show();

            //FlyweightExerciseSolution.Demo.show();

            //Exercise solution


            //Bridge pattern
            //solution:

            //BridgeSolution.AdvanceRemoteControl advanceRemoteControl = new BridgeSolution.AdvanceRemoteControl(new BridgeSolution.SonyTv());
            //advanceRemoteControl.SetChannel(5);
            //BridgeSolution.RemoteControl RemoteControl = new BridgeSolution.RemoteControl(new BridgeSolution.SonyTv());
            //RemoteControl.TurnOn();


            //Proxy pattern
            //Proxy.Library library = new Proxy.Library();
            //string[] fileNames = { "a", "b", "c" };
            //foreach (string filename in fileNames)
            //    //carica l'ebook e lo aggiunge alla library
            //    library.add(new Proxy.Ebook(filename));

            //library.OpenEbook("a");


            ////solution
            //Proxy.Solution.Library library2 = new Proxy.Solution.Library();
            //string[] fileNames2 = { "a", "b", "c" };
            //foreach (string filename in fileNames2)
            //    //carica l'ebook e lo aggiunge alla library
            //    library2.add(new Proxy.Solution.EbookProxy(filename));

            //library2.OpenEbook("a");

            //exercise
            //ProxyExercise.Demo.show();
            #endregion


            #region "General"

            //// Create an instance of Person and assign values to its fields.
            //Person p1 = new Person();
            //p1.Age = 42;
            //p1.Name = "Sam";
            //p1.IdInfo = new IdInfo(6565);

            //// Perform a shallow copy of p1 and assign it to p2.
            //Person p2 = p1.ShallowCopy();

            //// Display values of p1, p2
            //Console.WriteLine("Original values of p1 and p2:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //DisplayValues(p2);

            //// Change the value of p1 properties and display the values of p1 and p2.
            //p1.Age = 32;
            //p1.Name = "Frank";
            //p1.IdInfo.IdNumber = 7878;
            //Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //DisplayValues(p2);

            //// Make a deep copy of p1 and assign it to p3.
            //Person p3 = p1.DeepCopy();
            //// Change the members of the p1 class to new values to show the deep copy.
            //p1.Name = "George";
            //p1.Age = 39;
            //p1.IdInfo.IdNumber = 8641;
            //Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p3 instance values:");
            //DisplayValues(p3);

            SandwichMenu sandwichMenu = new SandwichMenu();

            // Initialize with default sandwiches
            sandwichMenu["BLT"]
                = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"]
                = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"]
                = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            // Deli manager adds custom sandwiches
            sandwichMenu["LoadedBLT"]
                = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives");
            sandwichMenu["ThreeMeatCombo"]
                = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
            sandwichMenu["Vegetarian"]
                = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

            // Now we can clone these sandwiches
            Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2
                = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
            Sandwich sandwich3
                = sandwichMenu["Vegetarian"].Clone() as Sandwich;


            #endregion

            Console.ReadKey();
        }
        private static void StoreCreditCard(DecoratorSolution.IStream stream)
        {
            stream.Write(data: "test");
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
