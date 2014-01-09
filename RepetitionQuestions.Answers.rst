=====================================
HS13 MsTe Repetitionsfragen Antworten
=====================================

Dieses Dokument wird vorzu erweitert. Ergänzungen und Antworten sind herzlich willkommen.
Repetitionsfragen: https://github.com/moonline/HSR.modules.MsTe/blob/master/RepetitionQuestions.rst


1 C# Grundlagen
===============

**1.0.1 CLR**

Das CLR ist die Laufzeitumgebung für von C# und beinhaltet nebst Classloader und JITC grundlegende Funktionsbausteine wie Code Manager, Thread Support, Garbage Collector, Security Engine oder Type Checker. Weitere Elemente sind Marshaller, Exception Manager, Debug Engine und die Base Class Library.


**1.0.2 Managed Code**

Managed Code wird über das CLR ausgeführt und entsprechend von diesem Verwaltet (GC, Security, ...).
Um Code "legacy Code" auszuführen, muss dieser direkt, ohne Unterstützung ausgeführt werden. Da "managed Code" das CLR voraussetzt, kann er nicht mit "legacy Code" gemischt werden.


**1.0.3 CTS**

Das Common Type System definiert die Basistypen von C#. Es gibt "value types", "reference types" und "user defined types" (u).

* value types
	* int, double, bool, char
	* [u] struct, enum
* reference types
	* object, string
	* [u] class, interface, array, delegate
	
	
**Eigenschaften:**

* "Value types" werden direkt im Speicher ((Stack) oder als member eines Heap Objektes) abgelegt, können nicht "null" sein und werden bei Zuweisung immer kopiert. Sie besitzen keinen Konstruktor sondern nur einen Initialisator.
* Referenztypen verweisen immer auf die Speicherstelle (Heap), an der das eigentliche Objekt liegt. Mehrfache Referenzierung durch mehrfache Zuweisung an unterschiedliche Variablen ist möglich.
	
	
**1.0.4 MS IL**

Dient zur plattformunabhängigen Ausführung. Code mehrerer Sprachen (C#, Visual Basic, ...) wird nach MS IL compiliert. Auf der Zielplattform wird der Code "Just In Time" compiliert und ausgeführt. Die Zielplattform braucht keinen compiler für den Programmiersprachspezifischen Code.

**Vorteile:**

* plattformunabhängige Ausführung durch das CLR ohne Codessprachenpezifischen	Compiler.
* Gemeinsame Verwendung von C#, Visual Basic, ... Code
* Entkoppelung von Programmier- und Ausführungssprache
* Laufzeit Type Safety Check möglich

**Nachteile:**

* Overhead
* IL Code kann nicht direkt aufgeführt werden


**1.0.5 Kompilation und Ausführung Cross-Plattform**

* Plattform 1 (Bsp. Windows):
	* C# Code wird nach IL+Metadata kompiliert
* Plattform 2 (Bsp. Linux (Mono)):
	* IL Code wird verifiziert
	* IL Code wird JIT kompiliert zu nativem Code (beim 1. Aufruf) und ausgeführt

**1.0.6 JITC**

1) Class Loader findet Klasse nicht
2) JITC verifiziert und kompiliert Klasse (IL -> native Code)
3) Class-Code wird ausgeführt


**1.0.7 Assembly, Modul**

Assembly
	Ausführbare Deployment Einheit, dynamisch ladbar, selbstbeschreibend, versionierbar (dll, exe)	
Modul
	Subelement von Assembly, enthält im Unterschied dazu kein Manifest


**1.0.8 Class localization**

i) Java: über Filepath
ii) C++: anhand der Referenz im Headerfile
iii) C#: anhand Referenz im Manifest


**1.0.9 Memory Management**

* GC funktioniert über Erreichbarkeitsgraphen und Generationen (aufräumen langsam, allozieren schnell).
* Wird einem Objekt null zugewiesen, so wird es abgeräumt, auch wenn noch Referenzen darauf zeigen


**1.0.10**



**1.0.11 Properties & Indexer**

Property
	Getter/Setter für Member (werden gross geschrieben)
Indexer
	Definieren Index-Zugriff für Objekte
	
	
**1.0.12 Paketierung**

Klassen werden im Unterschied zu Java nicht über den Filepath sondern Namespaces gruppiert. 

* (+) Die Paketierung ist somit losgelöst vom Dateisystem.
* (-) Elemente eines Namespaces können über die ganze Applikation verstreut werden


**1.0.13 Arrays**

Blockarray
	Mehrdimensionales Array mit gleichen Arraylängen in jeder Dimension, sehr effizient
	
	.. code-block:: c#
	
		bool l[,] = new bool[2,3];
		
		// l -> [ ][ ][ ]
		//      [ ][x][ ]
		     
		// Zugriff auf x
		bool g = l[1,1];
		
Jagged-Array
	Flatterarray wie in Java 
	
	.. code-block:: c#
		
		bool l[][] = new bool[2][];
		l[0] = new bool[2];
		l[1] = new bool[3];
		
		// l -> [ ][ ]
		//      [ ][x][ ]
		
		// Zugriff auf x
		bool g = l[1][1]
		
		
**1.0.14 Structs**

Structs sind Datenstrukturen (Valuetype), die direkt auf dem Stack abgelegt werden und initialisiert werden. Structs besitzen keine Konstruktoren und werden bei Zuweisung kopiert.str


**1.0.15 Statische Klassen**

Enthalten nur statische Methoden.


**1.0.16 Out Parameter**

Durch die Angabe von "ref" oder "out" eines Parameters kann dieser als Referenz übergeben werden. Unabhängig seines wirklichen Typs. "out" Parameter müssen vor dem verlassen der Methode zugewiesen worden sein.


**1.0.17 Statische Konstruktoren**

Statische Konstruktoren müssen parameterlos sein und werden aufgerufen, bevor der Typ zum ersten Mal verwendet wird. 


**1.0.18 Virtual**

Damit Methoden, Properties, Events oder Indexer von Subklassen mit override überschrieben werden können, müssen sie mit "virtual" gekennzeichnet sein.

.. code-block:: c#

	class Window {
		public virtual void paint() {
			Console.WriteLine("Window painted");
		}
	}
	
	class Button : Window {
		public override void paint() {
			Console.WriteLine("Button painted");
		}
	}
	
	
**1.0.19 Missing Virtual**

Virtual weist die Laufzeitumgebung an, die Methodenauflösung nicht statisch über den Typ sondern dynamisch über das Objekt und dessen Typ zu machen. Nicht virtual überschriebene Methoden werden nach einem Typecast (z.B. übergabe eines Buttons als Window) nicht korrekt aufgelöst. In diesem Beispiel würde die paint Methode des Windows und nicht des Buttons aufgerufen, da der statische Typ Window ist.


**1.0.20 Internal**

Sichtbarkeit nur innerhalb der Assembly.


**1.0.21 Instanziierung**

Statische Elemente vor dynamischen, Statische Felder vor Instanzfelder, Elternklassen vor Kindern.


**1.0.22 Virtual bei statischen Klassen**

Statische Klassen besitzen nur statische Methoden und sind somit nicht dynamisch-polymorph fähig (es gibt keine Instanzen davon). Entsprechend macht virtual auch keinen Sinn.


**1.0.23 Sealed**

Verhindert Ableitung einer Klasse.


**1.0.24 Named Clashes**

.. code-block:: c#

	class Audi : Vehicle, Car {
		void Vehicle.drive() {
			// ...
		}
		void Car.drive() {
			// ...
		}
	}

	
**1.0.25 Parameter**

Optionale Parameter
	besitzen einen Vorgabewert.
	
	.. code-block:: c#
	
		public void Something(int f, int a = 5) {
			// ...
		}
		
		
Named Parameter
	Parameter können in beliebiger Reihenfolge inkl. Auslassen von optionalen Parametern aufgerufen werden
	
	.. code-block:: c#
	
		Something(a:2, f:7);
		

**1.0.26 Partial Classes**

Ermöglichen das Umsetzen von Hooks und sollten nur für Code Generatoren genutzt werden. Klassen können damit auf mehrere Files aufgeteilt werden. Der Entwickler kann eine Methode definieren und verwenden. Ein Benutzer der Klasse kann die Methode innerhalb einer partial Class implementieren. Sobald eine Implementation vorhanden ist, ruft der Compiler die verwendete Methode auch wirklich auf. Ansonsten nicht.


**1.0.27 Delegates**

Delegates sind Methoden, die als Parameter übergeben werden. Delegates müssen zuerst definiert werden, bevor sie verwendet werden können:

.. code-block:: c#

	delegate bool check ( Payment p ) ;
	
	public function Ammount ( int ammount, check c) {
		// ...
	}
	
	Ammount(1500 , function ( Paymentp ){
		return p.Ammount > 0 ;
	});
	
	
Multicast Delegate
	Delegates können auf mehrere Methoden verweisen. Weitere Methoden werden einem Delegate mit += zugewiesen. Beim Aufruf des Delegates werden alle Methoden aufgerufen.


**1.0.28 Delegates als Callback**

.. code-block:: c#

	class Messagebox {
		bool state = false;
		
		public Messagebox() {
			Networkconnection n = new Networkconnection();
			n.connect(setOnline);
		}
		
		private void setOnline() {
			this.state = true;
		}
	}
	
	class Networkconnection {
		delegate void onconnect();
		
		public void connect(onconnect f) {
			// connect  ...
			f();
		}
	}
	
	
**1.0.29 Events**

Events vereinfachen das Prinzip des Observers und basieren auf Delegates.

.. code-block:: c#

	public delegate void TimeChanged(int time);
	
	class Timeserver {
		private int time = 0;	
		public event TimeChanged onTimeChange;
		
		private void riseTime() {
			time++;
			if(onTimeChange != null) {
				onTimeChange(this.time)
			};
		}
	}
	
	class Clock {
		Timeserver ts;
		int time = 0;
		
		private void paint() {
			// ...
		}
	
		public Clock() {
			this.ts = new Timeserver();
			ts.onTimeChange += function(int time) { 
				this.time = time;
				this.paint();
			}
		}
	}
	
	
**1.0.30 Events statt Interfaces**

Die Struktur bleibt flexibel. Events und Delegates können ohne Probleme später eingebaut werden. Interfacekonstrukte hingegen erzwingen eine Anpassung der Klassen.


**1.0.31 Events simplified**

.. code-block:: c#

	delegate bool Check<T>(T value);
	
	public void Finish(List l,Check<List> c) {
		if(c(l)) {
			// do something
		} else {
			// do something other
		}
	}
	
	public bool CheckList(List l) {
		return l.Length > 0;
	}
	
	// method call
	Finish(["a","b"], new Check<List>(CheckList));
	
	
new Check<List>(CheckList) ist eine Kurzschreibweise für 

.. code-block:: c#

	Check<List> c = new Check<List>();
	c = CheckList;
	Finish(["a","b"], c);
	
	
Alternative Schreibweise wäre wie in einem vorherigen Beispiel die Schreibweise mit delegate.

.. code-block:: c#

	delegate bool Check<T>(T value);
	
	public void Finish(List l,Check<List> c) {
		if(c(l)) {
			// do something
		} else {
			// do something other
		}
	}
	
	// method call
	Finish(["a","b"], delegate(List l) {
		return l.Length > 0;
	});


**1.0.32 Anonyme Methoden**

Methoden ohne Namen, die einmahlig benutzt werden und darum dort definiert werden, wo sie auch aufgerufen werden.

.. code-block:: c#

	ts.onTimeChange += function(int time) { 
		this.time = time;
		this.paint();
	}
	
	
**1.0.33 Delegates & Exceptions**

When you invoke a delegate, it will call each of the methods in its invocation list, one at a time.  If an exception is thrown from within one of those methods, the delegate will stop invoking methods in its invocation list and throw an exception up to the caller that initiated the invocation.  Methods on the invocation list that haven’t already been called will not get called.

http://csharp.2000things.com/2011/07/27/376-what-happens-when-an-exception-occurs-during-delegate-invocation/



2 Generics
==========

2.1 Generische Klassen
----------------------

**2.1.1 Syntax**

Platzhalter für generische Klassen werden in Spitzige Klammern geschrieben.

.. code-block:: c#

	class BagElement<K,V> {
		public V FindByKey(K key) {
			// return ...
		}
		public List<K> GetKeys() {
			// return ....
		}
	}
	
	
**2.1.2 Generics Compiling**

Der Compiler generiert für jeden Werttyp eine konkrete Klasse und für Referenztypen eine konkrete Object-Klasse.
In Java werden Generics über Casts gelöst zur Runtime. Deshalb können in Java nur Elemente die von Object erben für Generics verwendet werden.


**2.1.3 Constraints**
	
Constraints grenzen Generische Typen ein. Für Constraints können auch Platzhaltereigenschaften genutzt werden.

.. code-block:: c#

	class SortedBag<T> where T: IComparable {
	
	}
	
	// T and U must have the same type
	class Pair<T,U> where U: T {
	
	}
	
	
**2.1.4 Generics & Inheritance**

* normalen Klassen, A<T>: B
* konkreter generischer Klasse, A<T>:B<int>
* generischer Klasse gleichen Types, A<T>: B<T>


**2.1.5 Generics & Zuweisungen**

Nur erlaubt, wenn Platzhalter korrespondieren.

.. code-block:: c#

	A a = new B<int>();
	A a = new B<int, float>();
	C<int> a = new B<int>();
	C<int> a = new B<int, float>();
	
	
**2.1.6 Generics, Override, Inheritance**

Um von einer Platzhalterklasse zu erben, muss die Klasse selbst auch einen Platzhalter besitzen.

.. code-block:: c#

	class B<T> { 
		public virtual T DoSomething() {} 
	}
	
	class A:B<int> {
		public override int DoSomething() {}
	}
	class A<T>:b<T> {
		public override T DoSomething() {}
	}
	
	// nicht erlaubt, da T innerhalb der Klasse unbekannt:
	// class A:B<T> {
	// 	public override T DoSomething() {}
	// }
	
	
**2.1.7 default(T)**
	
Defaut(T) gibt den Default Wert von T zurück (null für Referenztypen, 0 für Werttypen);


**2.1.8 Nullable**

Nullable ist ein Wrapper, um Valuetypes null werden lassen können. Die Kurzschreibweise lautet mit einem Fragezeichen.

.. code-block:: c#

	Nullable<int> i = 123;
	int? i = 123;
	
	
2.2 Generische Methoden, Delegates, Lambdas
-------------------------------------------

**2.2.1 Generische Methoden**

.. code-block:: c#

	public T GetElement(List<T> l,int key) {
		// ...
	}
	
	GetElement<double>([2.4, 3,6], 1);
	

**2.2.3 generische Delegates**

.. code-block:: c#

	delegate bool Check<T>(T value);
	
	
	Finish([2,3], delegate(int val) { // ... });
	
	
**2.2.4 Lambdas**

Verkürzen Anonyme Methoden.

.. code-block:: c#

	Finish([2,3], val => val > 0);
	Finish([2,3], (int val) => val > 0);
	Finish([2,3], (int val) => { val > 0 });
	
	
**2.2.5 Func, Action**

Func und Action sind schon vordefinierte generische Delegates. Funcs geben einen Rückgabewert, Actions nicht.

.. code-block:: c#

	Func<int,int, int> CalcSum = (a, b) => return a*b;
	
	Action<string> print = s => Console.WriteLine(s);
	
	

3 Linq
======

**3.0.1 Linq**

Eine "Language Integrated Query" ist eine Abfrage über ein Datenset innerhalb der Sprache. Z.B. eine Such- und Filterabfrage über Elemente einer Liste.

Linq to Objects
	Linq Abfragen über IEnumerate Objekte
Linq to XML
	Linq Anfragen über XML
Ling to SQL
	Linq Abfragen über SQL Datenbanken
	
Als Benutzer macht es keinen Unterschied, um was für eine Quelle es sich handelt. Der Linq Treiber setzt dies im Hintergrund um.


3.1 Extension Methods
---------------------

**3.1.1 Extension Methods**

Erweitern von existierenden Klassen (reines Compilerfeature). Die erweiterugsmethode muss in einer statischen Klasse als statisceh methode mit this myClass definiert werden.

.. code-block:: c#

	static class Extensions {
		public static int Count (this MyList, bool c) {
			// count elements, if c is true, don't count null elements
			return count;
		}
	}

	static void Main() {
		MyList p = new MyList();
		// add elements
		Console.WriteLine(p.Count(true));
	}
	
	
**3.1.2 EM Vertiefung**

Der Compiler setzt Extensionmethods zur Compilezeit um. p.Count(true); wird zu Extensions.Count(p, true);


**3.1.3 EM Bedingungen**

* Die Klasse muss statisch sein.
* Methode muss statisch sein.
* Erster Methodenparameter muss "This MyClass" sein.

Beispiel siehe 3.1.1


**3.1.4 Vordefinierte Extension Methods**

Sie sind generisch für Interfaces definiert und auf jeder Klasse, die das interface implementiert kann die methode aufgerufen werden.


3.2 Anonyme Typen
-----------------

**3.2.1 Compile Time Inference**

Auflösen von Typen zur Compilezeit.

.. code-block:: c#

	// aus
	var person = { Name = "Anton", Age = 27 };
	
	// macht der Compiler
	class ? {
		public string Name { get };
		public int Age { get };
	}
	? person = new ? ("Anton", 27);
	
	
Anonyme Typen sind Typesafe, Der Compiler löst den Typ anhand des übergebenene Parameters auf.


**3.2.2 Anonyme Typen**

Anonyme Typen müssen mit var definiert werden, da der Compile den Typ selbst auflöst. Anonyme Objekte können wiederum Elemente von Anonymen Typen enthalten.

.. code-block:: c#

	var human = { callname = person.Name, Category = "modernHuman" };
	
	
Anonyme Typen enthalten Nur Getter.


**3.2.3 Typensicherheit bei Anonymen Typen**

Die Typen werden aus den übergebenen Parametern hergeleitet.


**2.3.4 Scope von Anonymen Typen**

Anonyme Objekte können den Scope der aktuellen Methode nicht verlassen, da sie an lokale Variablen gebunden sind.


**3.2.5 Operationen auf Anonymen Typen**

Anonyme Typen sind readonly.


3.3 Query Expressions
---------------------

**3.3.1 Query Expressions**

Query expressions sind eine SQL ähnliche Syntax für Linq Queries. Die Queries könnten auch mit verketteten Methoden geschrieben werden. Der Compiler baut Query Expressions ebenfalls um zu verketteten Methodenaufrufen.


**3.3.2 Query Expression -> Method calls**

.. code-block:: c#

	var result = customers.
		Where(c => c.City == "Vienna").
		OrderBy(c => c.Name).
		Select(c => new { c.Name, c.Phone });


**3.3.3 Method Calls -> QE**

.. code-block:: c#

	var result = from c in cars
		where c.Type.startsWith("L")
		orderby c.Name
		select c.Type.ToUpper();
		
		
**3.3.4 Range Variables**

Range Variables sind die temporären Variablen, die einen einzelnen Datensatz repräsentieren.

.. code-block:: c#

	//                   .-- Range variable
	//                   v
	var customers = from c in customers select c.Name;


**3.3.5 Grouping**

Erlaubt das Gruppieren von Datensätzen.

.. code-block:: c#

	// Zählen der Städte nach Grösse in Millionen
	var cities = from c in cities 
		groupby c.PopulationInMillions() into s
		select new { population = s.Key, cities = s.Count }; 
		
		
**3.3.6 Select Many**

Erlaubt das Zerlegen von Datensätzen.

.. code-block:: c#

	string[] nums = { "2,3,6", "5,8,0", "87,6,2" };
	var numbers = from n in nums.selectmany(t => t.split(','))
		select Convert.ToInt32(n)
		
		
**3.3.7 let**

Einführen zusätzlicher variablen, die auch in Operationen verwendet werden kann.

.. code-block:: c#

	var result = from c in cars
		let len = c.Name.Length
		where c.Type.startsWith("L") && len > 2
		orderby c.Name
		select c.Type.ToUpper();
		
		

4 Entity Framework
==================

**4.0.1 EF**

Das EF ist ein generisches Framework, das Zugriff auf Entities, z.B. Datenbanken ermöglicht. Die Datenbanken sind über typenspezifiche Data Providers angebunden.


**4.0.2 EF Begriffe**

Entity data Model
	Bezeichnet die ganze Einheit aus logischem Model, Mapping und Konzeptuellem
	::
	
		.------------------------ Entity Data Model ------------------.
		| .--------------.       .             .     .--------------. |
		| |              |     .´'-------------'`.   |              | |
		| | conceptual m.|    {      Mapping      }  | storage mod. | |
		| |              |     `.,-------------,.´   |              | |
		| '--------------'       '             '     '--------------' |
		'-------------------------------------------------------------'
		
		
Logical Model
	Definiert die Relationalen Daten mit ihren Beziehungen
Conceptual Model
	.Net Klassen, die ein Datenmodel bilden
Mapping Layer
	Verbindet die .Net Klassen des konzeptionellen Models mit den Datenbanktabellen


**4.0.3 Mapping Layer**

Definiert, welche Properties des konzeptuellen Modells wie auf welche Entities gemappt werden.


**4.0.4 Strategien**

DB First
	Visual Studio generiert aus einer bestehenden Datenbank das Konzeptuelle Modell und das Mapping, erst anschliessend wird der Applikationscode geschrieben
	::
	
		DB -> EDM -> Code
Model First
	Als erstes wird das Konzeptuelle Modell erstellt, aus dem die .Net Klassen, das Mapping und die DB generiert werden.
	::
		
		DB <- EDM -> Code 
Code First
	Als erstes wird der Applikationscode geschrieben. Daraus werden die benötigten Konzeptuellen Klassen extrahiert, Das konzeptuelle Model, das Mapping und die DB generiert
	::
		
		Code -> EDm -> DB
		
		
**4.0.5 Inheritance Strategies**

Table per Hierarchy
	Abgeleitete Klassen werden in die gleiche Tabelle gespeichert, diese wird um zusätzliche Felder erweitert -> viele leere Felder  in DB
Table per Type
	Für jede abgeleitete Klasse eine eigene Tabelle mit den zusätzlichen Feldern -> Abgeleitete Objekte werden über mehrere Tabellen verstreut, für simple Abfragen schon Join nötig
Table per concrete Type
	Gleich wie TpT, jede Tabelle enthält jedoch alle Information einer Klasse. Objekte werden nicht über mehrere Tabellen verstreut -> schwieriger zu warten
	
	
**4.0.6 Entity Splitting**

Entities sind über mehrere Tabellen verstreut


**4.0.7 DB Context**

Repräsentiert die aktuell geöffnete DB. Wird normalerweise mit using angelegt, sodass er automatisczh geschlossen wird.

DBContext bietet Zugriff auf DBsets und settings.


**4.0.8 Ling & EF**

Mit Linq können Abfragen über die vom Context gelieferten DBsets gemacht werden. Linq arbeitet im Hintergrund automatisch mit LinqToEntities.


**4.0.9 navigation Properties**

Sind Beziehungen im concept. Model (Eigenschaften, die benutzt werden um sich durch die Objektstruktur zu hangeln). Das EF macht im Hintergrund jeweils where

.. code-block:: c#

	from o in Order
	// Orderdetails.unitPrice > 20 ist eine Navigationproperty
	where o.OrderDetails.unitPrice > 20
	select o;

		
Das EF macht im Hintergrund Joins, um die verknüpften Daten einbeziehen zu können.


**4.0.10 Lazy/Eager loading**

.. code-block:: c#

	context.configuration.LazyLoadingEnabled = true;
	
	
Eagerloading Tiefe: in Linq mit Include() eingebundene Datensätze oder "context.Entry(cust).Collection(c => c.Orders).Load();" geladene Datensätze.


**4.0.11 implizites Nachladen**

Das EF setzt jedes Mal eine Query ab um die entsprechenden Daten zu laden sobald diese gebraucht werden.


4.1 CUD Operations
------------------

**4.1.1 CUD Beispiele**

.. code-block:: c#

	// create
	context.customers.Add(c);
	context.SaveChanges();
	
	// update
	var customer1 = (from c in customers where c.name = "Hanna" select c).FirstOrDefault();
	if(customer1 != null) {
		customer1.name = "Hannah";
		context.SaveChanges();
	}
	// Wird beim Updaten mit dem originalen und neuen Wert gearbeitet, so muss das Original mit 
	// context.customers.attach(original) attached werden, mit 
	// context.Entry(original) Currentvalues.SetValues(modified); und 
	// context.SaveChanges(); aktualisiert werden.
		
	// delete
	context.customers.DeleteObject(customer1);
	context.SaveChanges();


**4.1.2 Kollisionsüberwachung**

Weil laden und Speichern in zwei unterschiedlichen Transaktionen stattfinden und sich das Objekt in der zwischenzeit geändert haben kann.



5 WCF
=====

**5.0.1 WCF**

Windows Communication Foundation. Ersetzt ASMX, COM+, MSMQ, .Net Remoting


**5.0.2 Vorteile WCF**

* Gute Integration
* Sehr Generisch, funktioniert mit vielen Technologien
* Service Orientiert


**5.0.3 Interoperabilität**

Grundsätzlich ist über SOAP Kommunikation mit beliebigen Endpunkten möglich. Die Zusammenarbeit mit gleicher Technologie ist jedoch wesentlich einfacher.


5.1 Konzepte, Architektur
-------------------------

**5.1.1 Standartprotokoll**

SOAP


**5.1.2 Cross-Domain Call**

::

	Machine A ---------.
	| Process 1 ------. |
	| | Service--.    | |
	| | |        +-O  | | Domain X
	| | '--------' ^  | |
	| '------------|--' |
	'--------------|----'
	               |
	            Internet
	               |
	              /	
	Machine B ---/---------------.
	| Process 2 /--------------. |
	| | Proxy--:    .-Client-. | |
	| | |      +-O<-|        | | | Domain Y
	| | '------'    '--------' | |
	| '------------------------' |
	'----------------------------'

	
**5.1.3 Endpoints**

Knoten, zwischen denen die Kommunikation läuft. Ein Service kann auch mehrere Endpoints besitzen.


**5.1.4 Endpoint Properties**

Endpunkte besitzen jeweils:

* A: Adresse (URL, URI)
* B: Bindung (Kanal)
* C: Contract (Interface Def., DTO)


**5.1.5 WSDL**

Web Service Description Language

* Definiert einen Webservice
* Serviceclients können anhand der Schnittstelle generiert werden.

**5.1.6 WSDL Document**

Metadata Exchange MEX bietet genügend Metadaten zur automatischen Generierung eines Clients.


**5.1.7 Contracts**

Service Contract
	* Definiert den Service und deren Operations, Verhalten und Interaktionsmodel
	* Definiert mit [ServiceContract(Namespace = "url")], [OperationContract] Annotation
Data Contract
	* Definiert Datenstrukturen und Versionierung
	* [DataContract], [DataMember]
Message Contract
	* Struktur der Message (Header / Body)


**5.1.8 Annotations**

Siehe 5.1.7


**5.1.9 DTO's**

Data Transfer Objects. Objekte ohne Methoden, die nur benutzt werden um die Daten über den Service zu übertragen.


5.2 Hosting
-----------

**5.2.1 Hosting**

* Visual Studio Autohost
* Manuell via ServiceHost Klasse
* MS Information Server (Beste Möglichkeit für Live Betrieb)


**5.2.2 App.Config**

* Konfiguriert die App
* Config könnte auch Programmatisch im Code gemacht werden
* Wird die App als Bundle ausgeliefert, so ist die App.Config ausserhalb -> Administrator kann App konfigurieren ohne neukompilation


5.3 Client
----------

**5.3.1 Client Generierung**

* Generierung anhand des WSDL Schemas
* Verlust von Typeninformationen


**5.3.2 Shared Assembly**

Der Client wird nicht über die WSDL Schnittstelle generiert und aktualisiert sondern über ein Shared Assembly.

* Vorteile: Kein Verlust von Typeninfo, schnell zum Entwickeln
* Nachteil: Assembly muss für Client wie Service verfügbar sein -> Deployment auf Server & Client


**5.3.3 Shared Assembly Content**

* Service Contracts / Interfaces
* Data Contracts
* Other Shared Info


5.4 Communcation Patterns
-------------------------

**5.4.1 Patterns**

One Way
	Fire and forget Prinzip. Es werden nur Requests abgesetzt aber keine empfangen. (asynchron)
Request Reply
	Ein Requst wird abgesetzt, anschliessend erfolg eine Antwort. (synchron)
Dupley
	In beide Richtungen wird parallel kommuniziert. (asynchron)
	
	
**5.4.2 Pattern Annotations**

OneWay
	.. code-block:: c#
	
		[ServciceContract]
		public Interface IS {
		
			[OperationContract(IsOneWay=true)]
			void StoreProblem(ComplexProblem p);
			
		}
		
		
Callback
	.. code-block:: c#
	
		[OperationContract(CallbackContract=typeof(ICalcResults)]
		public interface IS {
			
		}
		
		public interface ICalcResults {
			[OperationContract(IsOneWay=true)]
			void Results(CompleyProblem p, double result);
		}
		
	Service:
	.. code-block:: c#
	
		public class CalcService : ICalculator {
			public void SolveProblem(ComplexProblem p) {
				// ...
				// call client back
				Callback.Results(p, res);
			}
			
			ICalculatorDupleyCallback Callback {
				get {
					return OperationContext.Current.GetCallbackChannel<ICalcResulsts>();
				}
			}
		}
		
		
**5.4.3 FaultContract**

Dient zum Remote Exceptions werfen.

.. code-block:: c#

	// MathFault class is used to send additional information
	[FaultContract(typeof(MathFault))]
	int Divide(int n1, int n2);
	
.. code-block:: c#

	// additional information in mathFault
	throw new FaultException<MathFault>(
		new MathFault() { Operation = "division", ProblemType = "divide by cero" };
	);
	
	
**5.4.4 FaultContract vs Exception**

Die Exception muss im Contract definiert sein, damit der Client damit überhaupt etwas anfangen kann. -> daher FaultContract


**5.4.5 Exceptionfluss**

Server
	1) Klasse im Model wirft Exception
	2) Service fängt Exception ab
	3) Service wirf FaultException, die an den Client übertragen wird

Client
	4) Client fängt FaultException
	5) Client behandelt FaultException
	
	
5.5 Tech. Details
-----------------

**5.5.1 Adresse**

Besteht aus:
* Protocol
* Host
* Port / Pipe / Queue
* Rel. Pfad

[transport]://[domain][:port][path]


**5.5.2 Binding**

Client und Server müssen immer das gleiche Binding besitzen. Sonst kommt die Kommunikation nicht an.


**5.5.3 DataContract & Inheritance**

* Service erkennt abgeleitete Klassen nicht
* Annotation 
	.. code-block:: c#
	
		[DataContract]
		[KnownType(typeof(AbgeleiteteKlasse1)]
		public class Klasse {}

		[DataContract]
		public class AbgeleiteteKlasse1 : Klasse {}
		
		
**5.5.4 Redundanz beim Übertragen**

.. code-block:: c#

	public class a {		
		public Klass b = new Klass();

		[DataMamber(IsReference=true)]
		public Klass c = b;
	}
	
	
IsReference=true verhindert das Kopieren und somit übermitteln redundanter Objekte.


**5.5.5 Fehlertoleranz**

* Version Toleranz: Neue Members werden automatisch Unterstützt (ignoriert)
* Entfernte Memebers ebenfalls: Default Werte sind default(T)



