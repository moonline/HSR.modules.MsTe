=====================================
HS13 MsTe Repetitionsfragen Antworten
=====================================

Dieses Dokument wird vorzu erweitert. Ergänzungen und Antworten sind herzlich willkommen.
Repetitionsfragen: https://github.com/moonline/HSR.modules.MsTe/blob/master/RepetitionQuestions.rst


C# Grundlagen
=============

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

