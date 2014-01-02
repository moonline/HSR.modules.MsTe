=====================================
HS13 MsTe Repetitionsfragen Antworten
=====================================

Dieses Dokument wird vorzu erweitert. Ergänzungen und Antworten sind herzlich willkommen.
Repetitionsfragen: https://github.com/moonline/HSR.modules.MsTe/blob/master/RepetitionQuestions.rst


C# Grundlagen
=======================

1 CLR
-----
Das CLR ist die Laufzeitumgebung für von C# und beinhaltet nebst Classloader und JITC grundlegende Funktionsbausteine wie Code Manager, Thread Support, Garbage Collector, Security Engine oder Type Checker. Weitere Elemente sind Marshaller, Exception Manager, Debug Engine und die Base Class Library.


2 Managed Code
--------------
Managed Code wird über das CLR ausgeführt und entsprechend von diesem Verwaltet (GC, Security, ...).
Um Code "legacy Code" auszuführen, muss dieser direkt, ohne Unterstützung ausgeführt werden. Da "managed Code" das CLR voraussetzt, kann er nicht mit "legacy Code" gemischt werden.


3 CTS
-----
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
	
	
4 MS IL
-------
Dient zur plattformunabhängigen Ausführung. Code mehrerer Sprachen (C#, Visual Basic, ...) wird nach MS IL compiliert. Auf der Zielplattform wird der Code "Just In Time" compiliert und ausgeführt. Die Zielplattform braucht keinen compiler für den Programmiersprachspezifischen Code.

**Vorteile:**

* plattformunabhängige Ausführung durch das CLR ohne Codessprachenpezifischen	Compiler.
* Gemeinsame Verwendung von C#, Visual Basic, ... Code
* Entkoppelung von Programmier- und Ausführungssprache
* Laufzeit Type Safety Check möglich

**Nachteile:**

* Overhead
* IL Code kann nicht direkt aufgeführt werden


5 Kompilation und Ausführung Cross-Plattform
--------------------------------------------

* Plattform 1 (Bsp. Windows):
	* C# Code wird nach IL+Metadata kompiliert
* Plattform 2 (Bsp. Linux (Mono)):
	* IL Code wird verifiziert
	* IL Code wird JIT kompiliert zu nativem Code (beim 1. Aufruf) und ausgeführt

6 JITC
------
1. Class Loader findet Klasse nicht
2. JITC verifiziert und kompiliert Klasse (IL -> native Code)
3. Class-Code wird ausgeführt


7 Assembly, Modul
-----------------
Assembly
	Ausführbare Deployment Einheit, dynamisch ladbar, selbstbeschreibend, versionierbar (dll, exe)	
Modul
	Subelement von Assembly, enthält im Unterschied dazu kein Manifest


8 Class localization
--------------------
i) Java: über Filepath
ii) C++: anhand der Referenz im Headerfile
iii) C#: anhand Referenz im Manifest


9 Memory Management
-------------------
* GC funktioniert über Erreichbarkeitsgraphen und Generationen (aufräumen langsam, allozieren schnell).
* Wird einem Objekt null zugewiesen, so wird es abgeräumt, auch wenn noch Referenzen darauf zeigen


10
--



11 Properties & Indexer
-----------------------
Property
	Getter/Setter für Member (werden gross geschrieben)
Indexer
	Definieren Index-Zugriff für Objekte
	
	
12 Paketierung
--------------
Klassen werden im Unterschied zu Java nicht über den Filepath sondern Namespaces gruppiert. 

* (+) Die Paketierung ist somit losgelöst vom Dateisystem.
* (-) Elemente eines Namespaces können über die ganze Applikation verstreut werden


13 Arrays
---------
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
		
		
14 Structs
----------
Structs sind Datenstrukturen (Valuetype), die direkt auf dem Stack abgelegt werden und initialisiert werden. Structs besitzen keine Konstruktoren und werden bei Zuweisung kopiert.str


15 Statische Klassen
--------------------
Enthalten nur statische Methoden.


