===========================
HS13 MsTe Repetitionsfragen
===========================

Antworten zu den Repetitionsfragen
==================================
Falls vorhanden befinden sich diese im GitHub Repository. Ergänzungen oder ganze Antwortensets sind jederzeit herzlich willkommen.
https://github.com/moonline/HSR.modules.MsTe


C# Grundlagen
=============

**1.0.1.**
Was ist das CLR? Was beinhaltet es alles?

**1.0.2.**
Wie wird managed Code ausgeführt? Warum kann managed Code nicht mit Legacy Code gemischt werden?

**1.0.3.**
Was ist das CTS? Wie ist es aufgebaut? Skizzieren Sie die Hirarchie.

**1.0.4.**
Was ist die MS Intermediate Language? Wozu dient sie? Nennen Sie Vor- und Nachteile.

**1.0.5.**
Skizzieren Sie auf, wann und wo Kompilation und Ausführung geschehen, wenn Code auf einer andern Plattform ausgeführt wird, als er erzeugt wurde.

**1.0.6.**
Erklären Sie, wie die "Just in Time Compilation" bei C# funktioniert.

**1.0.7.**
Was sind Assemblies? Was sind Module?

**1.0.8.**
Wie findet der Class Loader die Implementation eines referenzierten Files bei den folgenden Sprachen?

a. Java
b. C++
c. C#

**1.0.9.**
Erklären Sie grob das C# Memory Management.

**1.0.10.**
Was bietet .NET?

**1.0.11.**
Was ist eine Property einer Klasse? Was sind Indexer?

**1.0.12.**
Wie funktioniert die Paketierung (Gruppierung von Klassen) unter C#? Wie unterscheidet es sich deutlich von Java? Welche Vor- und Nachteile ergeben sich daraus?

**1.0.13.**
Was ist der Unterschied zwischen Blockarrays und jagged Arrays? Wie erzeugen sie sie jeweils?

**1.0.14.**
Was sind Structs? Wie unterscheiden sie sich von Klassen?

**1.0.15.**
Was sind statische Klassen?

**1.0.16.**
Was sind out Parameter?

**1.0.17.**
Was sind statische Konstruktoren?

**1.0.18.**
In welchem Fall benötigen sie "virtual" bei Methoden? Machen Sie in konkretes Beispiel mit der paint() Methode eines GUI's.

**1.0.19.**
Was passiert, wenn sie eine Methode mit override überschreiben, ohne das diese in der Basisklase "virtual" ist?

**1.0.20.**
Was ist die Sichtbarkeit "ìnternal"?

**1.0.21.**
In welcher Reihenfolge werden Objekte initialisiert, wenn sie Baisklassen mit Kindklassen sowie statische Felder in der Klasse haben?

**1.0.22.**
Warum benötigen abstrakte Methoden kein "virtual"?

**1.0.23**
Was sind "sealed" Klassen?

**1.0.24.**
Sie implementieren mehrere Interfaces. In den Interfaces gibt es gleich benannte Methoden. Wie spezifizieren Sie, welche Methode sie konkret implementieren?

**1.0.25.**
Wie geben sie optionale Parameter an? Was sind "named parameters"?

**1.0.26.**
Was sind "partial classes" / methods? Wozu werden sie gebraucht? Sollten Sie sie einsetzen?

**1.0.27.**
Was sind "delegates"? Machen Sie ein Beispeil mit einem "delegate". Was sind "multicast delegates"?

**1.0.28.**
Wie nutzen Sie delegates als Callback? Machen Sie ein Beispiel.

**1.0.29.**
Was sind Events? Machen Sie ein Beispiel, wie mit Events die Anzeige einer Uhr einfach aktualisiert werden kann.

**1.0.30.**
Welche Vorteile bietet das Arbeiten mit Delegates und Events anstelle Interfaces?

**1.0.31.**
Wie kann die Erzeugung eines Delegate vereinfacht geschrieben werden? Was sind generische Delegates?

**1.0.32.**
Was sind anonyme Methoden? Wozu können sie verwendet werden?

**1.0.33.**
Wie werden Exceptions in der Rufkette weitergegeben, wenn sich ein Delegate Call in der Kette befindet? Machen Sie eine Skizze.


Generics
========

Generische Klassen
------------------
**2.1.1.**
Wie lautet die Syntax für eine generische Klasse? Wie sieht es aus mit mehreren Platzhaltern? Machen Sie je auch ein Beispiel zur Verwendung.

**2.1.2.**
Welche Operationen finden zur Compilezeit und welche zur Laufzeit statt bei C\# Generics? Wie funktioniert dies bei Java? Erklären Sie anhand dieser Gegebenheit auch, warum bei Java keine Basistypen für Generics verwendet werden können?

**2.1.3.**
Was sind Constructor Constraints? Wie werden sie definiert? Können sie auch Platzhalter verwenden?

**2.1.4.**
Von welchen Klassen darf eine generische Klasse erben?

**2.1.5.**
Welche Zuweisungen bei generischen Klassen sind kompatibel, und welche nicht?

**2.1.6.**
Können generische Methoden überschrieben werden? In welchem Fall können Platzhalter verwendet werden?

**2.1.7.**
Wozu dient default(t)?

**2.1.8.**
Erklären Sie Nullable.


Generische Methoden
-------------------
**2.2.1.**
Wie generalisieren Sie Methoden? Machen Sie auch ein Beispiel zur Benutzung.


Generische Delegates und Lambda Expressions
-------------------------------------------
**2.2.3.**
Wie generalisieren Sie delegates?

**2.2.4.**
Was sind Lambda Expressions? Wie wenden Sie sie an? Machen Sie ein Beispiel wie sie mit Lambda Expressions Delegates umsetzen. Schreiben Sie die Lambda Expression in allen Darstellungsmöglichkeiten.

**2.2.5.**
Wozu dient der vrdefinierte Delegate Func?


Generische Collections
----------------------
**2.3.1.**
Nennen Sie einige generische Collections und Interfaces.

**2.3.2.**
Machen Sie ein Beispiel, wie Sie eine List<int> anlegen, befüllen, Elemente löschen und sortieren.


Iteratoren
----------
**2.4.1.**
Schreiben Sie einen Iterator für eine eigene Collection indem sie eine interne IEnumarator Klasse verwenden. Machen Sie auch ein Beispiel zur Verwendung.

**2.4.2.**
Was wird mit yield bezweckt? Wie schreiben Sie damit eine vereinfachte Implementation eines Iterators? Was passiert unter der Oberfläche bei der Verwendung?

**2.4.3.**
Wie schreiben Sie spezifische Iteratoren (z.B. einen Range Iterator)?


Linq
====
**3.0.1.**
Was ist Linq? Was sind Linq to Objects, Linq to XML und Linq to SQL?

Extension Methods
-----------------
**3.1.1.**
Was sind Extension Methods? Welches Problem lösen Sie?

**3.1.2.**
Werden extension Method zur Compilezeit oder zur Laufzeit aufgelöst?

**3.1.3.**
Welche Bedingungen müssen die Klasse und die Methodensignatur einer Extension Method erfüllen? Wie übergeben Sie Extension Methods das Objekt, auf dem die Methode aufgerufen wird? Machen Sie ein Beispiel.

**3.1.4.**
Welchen Vorteil bieten vordefinierte Extension Methods wie "where"?

Anonymous Type
--------------
**3.2.1.**
Was ist Compile Time Type Inference? Wie funktioniert es?

**3.2.2.**
Wie definieren Sie einen anonymen Typ (anonymes Objekt)? Konnen Anonyme Objekte weitere Anonyme Objekte enthalten? Welche Methoden enthalten anonyme Typen?

**3.2.3.**
Wie wird bei anonymen die Typensicherheit gewährleistet?

**3.2.4.**
Kann ein anonymes Objekt den Scope der aktuelle Methode verlassen?

**3.2.5.**
Welche Lese- und Schreiboperationen können auf anonymen Typen durchgeführt werden?

Query Expressions
-----------------
**3.3.1.**
Was sind "Query Expressions"? Wären Linq Abfragen ohne "Query Expressions" unmöglich?

**3.3.2.**
Wandeln sie die folgende Expression in Methodenschreibweise um:

.. code-block:: C#

	var result =
		from c in customers
		where c.City == "Vienna"
		orderby c.Name
		select new {c.Name, c.Phone};

**3.3.3.**
Wandeln Sie die folgende Schreibweise in eine Expression um:

.. code-block:: C#

	var result =
		cars
		.Where( c => c.Type.StartsWith('L'))
		.OrderBy( c=> c.Name )
		.Select( c => c.Type.ToUpper() );

**3.3.4.**
Was sind "Range Variables"? Wie werden Sie in der "Query Expression" geschrieben?

**3.3.5.**
Wie funktionieren "Grouping" und "Joining"? Machen Sie je ein Beispiel.

**3.3.6.**
Was ist "Select Many"? Machen Sie ein Beispiel.

**3.3.7.**
Wozu dient die "let" Klausel?


.Net Entity Framework
=====================
**4.0.1.**
Erklären Sie das Grundkonzept des .NET EF's.

**4.0.2.**
Erklären Sie folgende Begriffe in Bezug auf das EF: Entity Data Model, Logical Model, Conceptual Model, Mapping Layer.

**4.0.3.**
Welche Aufgabe übernimmt der Mapping Layer?

**4.0.4.**
Erklären Sie "Database First", "Model First" und "Code First".

**4.0.5.**
Inheritance: Beschreiben Sie wie "Table per Hierarchy", "Table per Type" und "Table per concrete Type" funktionieren.

**4.0.6.**
Was ist "Entity Splitting"?

**4.0.7.**
Was ist der "Object Context" und wie funktioniert er? Wie ist die Context API aufgebaut?

**4.0.8.**
Wie kann Linq zur Abfrage über das EF eingesetzt werden? Machen Sie ein Beispiel.

**4.0.9.**
Was sind "Navigation Properties" und was macht das Framework im Hintergrund für Operationen um die Daten zusammenzubekommen? Zeigen Sie dies am Beispiel einer SQL Datenbank.

**4.0.10.**
Wie funktionieren Lazy und Eager Loading? Wie wir die Ladetiefe definiert? Machen Sie ein Beispiel.

**4.0.11.**
Was passiert im Hintergrund bei implizitem Landen (Nachladen von Lazy Loading Properties/Relations)?


CUD Operationen
---------------
**4.1.1**
Machen Sie je ein Beispiel für eine Create, Update und eine Delete Operation auf einer EF Collection.

**4.1.2.**
Warum benötigen Sie eine Kollisionsüberwachung in ihrer Applikation, die "lost Update" verhindert, obwohl alle Datenbanken und das EF Transaktions unterstützen?


WCF
===
**5.0.1.**
Was ist das WCF? Welche Basistechnologien ersetzt WCF?

**5.0.2.**
Welche Vorteile birgt WCF gegenüber verschiedenen Basistechnologien?

**5.0.3.**
Wie weit sind WCF Services interoperabel mit nicht-WCF services?


Konzepte, Architektur
---------------------

**5.1.1.**
Welche Technologie ist das WCF Standardprotokoll?

**5.1.2.**
Skizzieren Sie einen Cross-Domain Call und bezeichnen Sie folgende Elemente in der Skizze: Service, Proxy, Internet, Client Machine, Client, Process

**5.1.3.**
Was sind Endpoints? Wozu dienen Sie?

**5.1.4.**
Erklären Sie Adress, Bindung, Contract und ABC Schema in Bezug auf Endpoints.

**5.1.5.**
Was ist WSDL? Wozu dient es? Inwiefern bieten die Endpoints einen klaren Vorteil, wenn auch noch ein WSDL Meta Exchange Service angeboten wird?

**5.1.6.**
Welche Informationen beinhaltet ein WSDL Dokument? Kann aus diesen Informationen einen Client implementiert werden, der den Service nutzt?

**5.1.7.**
Was sind "Service COntract", "Data Contract" und "Message Contract" und wozu dienen Sie?

**5.1.8.**
Wie definieren Sie Contracts als Annotations?

**5.1.9.**
Was sind DTO's und wozu werden Sie bei WCF gebraucht?


Hosting
-------
**5.2.1.**
Welche Möglichkeiten gibt es, WCF Services zu Hosten? Welche ist für eine Live Umgebung die geeignetste?

**5.2.2.**
Wozu dient die App.Config? Kann die gleiche Konfiguration auch im Code gemacht werden? Wie? Welchen Vorteil bietet die App.Config bei der Auslieferung?


Client
------
**5.3.1.**
Wie generiert WCF einen Client? Welche Vor- und Nachteile hat dies?

**5.3.2.**
Wie funktioniert ein Client mittels "Shared Assembly"? Welche Vor- und Nachteile hat dies?

**5.3.3.**
Was muss das "Shared Assembly" alles enthalten, damit der Client damit arbeiten kann?


Communication Patterns
----------------------
**5.4.1.**
Erklären Sie "One Way", "Request-Reply" und "Duplex".

**5.4.2.**
Wie deklarieren Sie eine Methode als "OneWay", welche Annotations sind dazu notwendig? Wie implementieren Sie einen Callback? Was braucht es dazu alles?

**5.4.3.**
Wozu dient ein FaultContract? Wie können zusätzliche Informationen übertragen werden?

**5.4.4.**
Warum ist ein FaultContract notwendig? Warum kann keine gewöhnliche Exception übertragen werden?

**5.4.5.**
Skizzieren Sie wie der Fluss einer Exception ist, die serverseitig geworfen wird.


Tech. Details
-------------
**5.5.1.**
Wie ist eine Adresse aufgebaut?

**5.5.2.**
Müssen Client und Server zwingend das gleiche Binding besitzen? Wie werden Bindings publiziert?

**5.5.3.**
Wie definieren Sie DataContracts für Abgeleitete Typen, bzw. allgemein für Polymorphismus?

**5.5.4.**
Wie verhindern Sie redundante Kopien beim Übertragen, wenn Objekte mehrmals auf gleiche Objekte verweisen? Welche Konsequenzen hat das Vergessen dieser Deklaration für den Empfänger der Serialisierten Objekte?

**5.5.5.**
Wie weit sind Contracts Fehlertolerant? Welche Nachteile bringt dies mit sich?



WPF
===
**6.0.1.**
Was ist WPF? Wozu wird es verwendet?

**6.0.2.**
Was ist der MilCore? Welches Problem löst er gegenüber Vorgänertechnologien von WPF?

XAML
----
**6.1.1.**
Was ist XAML? Wie funktioniert es? Was passiert im Hintergrund mit dem XAML?

**6.1.2.**
Welche Namespaces werden normalerweise benötigt? Wie ergänzt man einen eigenen Namespace mit Custom Elements?

**6.1.3.**
Erklären Sie die Attribute Syntax für Properties. Machen Sie ein Beispiel jeweils mit Attributsyntax und mit XML Element Syntax.

**6.1.4.**
Was sind XAML Type Converters? Wie funktionieren sie?

**6.1.5.**
Wie binden Sie Objekte und Properties an Elemente? Welche Arbeiten sind dazu im Controller notwendig?

**6.1.6.**
Wie definieren Sie Event Handler auf Elementen und wie setzen Sie diese im Controller um?

**6.1.7.**
Was ist der Unterschied zwischen "logical Tree" und "Visual Tree"? Verändert sich einer der Trees, wenn ein Style gesetzt wird?

**6.1.8.**
Was ist die XAML Attribute Element Syntax?

**6.1.9.**
Wie sind die WPF Core Klassen aufgebaut? Von welchem Basiselement erben alle visuellen Elemente? Warum ist dies notwendig?

**6.1.10.**
Was sind templates? Wozu werden Sie eingesetzt?


Properties
----------
**6.2.1.**
Was sind XAML Properties?

**6.2.2.**
Was sind Dependency Property? Wo liegt der Vorteil?

**6.2.3.**
In welcher Reihenfolge werden Property Values aufgelöst?

**6.2.4.**
Was sind "Property Change Notifications"?

**6.2.5.**
Was sind Attached Property?


Routed Events
-------------
**6.3.1.**
Was sind "Routed Events"?

**6.3.2.**
Erklären Sie die verschiedenen Routing Strategien.

**6.3.3.**
Was sind "Source", "OriginalSource", "RoutedEvent" und "Handled" eines "RoutedEvent"?

**6.3.4.**
Warum sind RoutedEvents keine normalen Events?

**6.3.5.**
Was ist Event Bubbling?

**6.3.6.**
Wie werden Events behandelt?


Data Binding
------------
**6.4.1.**
Was ist Data Binding?

**6.4.2.**
Was sind Binding Target und Target und was sind OneWay, OneWayToSource und Twoway Binding?

**6.4.3.**
Welche Mechanismen muss eine Klasse im Model umsetzen, damit UI Binding möglich ist?

**6.4.4.**
Welche Rolle übernimmt DataContext in den daus dem XAML generierten Klassen?

**6.4.5.**
Was sind Value Converters und welche Aufgabe übernehmen Sie? Wie implementieren Sie eigene?

**6.4.6.**
Was sind Data Templates?

**6.4.7.**
Wie werden Collections gebunden?

**6.4.8.**
Wie wird ein Master-Detail Binding umgesetzt?

**6.4.9.**
Wozu dient "IsSynchronizedWithCurrentItem"?

**6.4.10.**
Was bieten "Observable Collections"?


WPF Patterns
------------
**6.5.1.**
Wozu braucht es das Command Pattern, bzw. Commands für UI's? Welches Problem löst es?

**6.5.2.**
Was sind RoutedComands?

**6.5.3.**
Was sind DelegateCommands, Wozu dienen Sie?

**6.5.4.**
Wie funktioniert das WPF Command Model?

**6.5.5.**
Was unterscheidet MVP von MVC?

**6.5.6.**
Welche Probleme bringen MVP und MVC mit sich? Inwiefern soll MVVM dies lösen?

**6.5.7.**
Welche Aufgaben übernimmt das ViewModel beim MVVM?

**6.5.8.**
Wie spielen Binding und Notification beim MVVM zusammen?


Validation
----------
**6.6.1.**


Async
=====
**7.0.1.**
Erlären Sie die Begriffe "Concurrent", "Multithreaded", "Parallel" und "Asynchron".


Threads
-------
**7.1.1.**
Erklären Sie die Thread Architektur in .Net. Was sind App-Domains und wozu?

**7.1.2.**
Warum sind die Methoden "CurrentThread" und "Sleep" der Thread API static während alle andern Methoden Memberfunktionen sind?


Tasks
-----
**7.2.1.**
Was sind Tasks. Was unterscheidet sie von Threads?

**7.2.2.**
Wie benutzen Sie parallelisierte Schleifen oder lassen mehrere Statements parallel ausführen?

**7.2.3.**
Was bringt PLINQ? Welchen Vorteil hat dies für den Programmierer? Wie wird es benutzt?

**7.2.4.**
Was ist "Work-Stealing" in einem Thread Pool?

**7.2.5.**
Wie werden Tasks benutzt? Wie werden sie mit einem Future benutzt?

**7.2.6.**
Wie werden Exceptions gefangen? Was sind "Aggregate Exceptions"?

**7.2.7.**
Was sind Continuations? Wie funktioniert "ContinueWith"?


Async
-----
**7.3.1.**
Wie rufen sie eine Methode asynchron auf und wie warten sie auf deren Beendigung?

**7.3.2.**
Wie machen Sie eine async Lambda expression?


WPF
---
**7.4.1.**
Warum müssen Sie eine Message Queue einsetzen, um an Window properties wie Feldinhalte oder Button Events eines andern Threads zu kommen?

**7.4.2.**
Was ist der SynchronizationContext?

**7.4.3.**
Wie stellt der Task Scheduler sicher, das UI Tasks im richtigen Context ablaufen, bzw. OnComplete auf dem richtigen Context ausgeführt wird?

**7.4.4.**
Wie können Tasks gecancelled werden?


Reflection
==========
**8.0.1.**
Erklären Sie den Grundgedanken hinter Reflection.

**8.0.2.**
Was bietet die Klasse System.Type?

**8.0.3.**
Wie funktionieren typeof() und Object.GetType()?

**8.0.4.**
Ist System.Type eine normale Klasse, die ebenfalls Reflection besitzt?

**8.0.5.**
Erklären Sie das Reflection Object Model. Welche Element (Assembly, Modul, Type, Constructor, ...) bieten welche Reflection Methoden?

**8.0.6.**
Welche Informationen können Sie mit System.Reflection.FieldInfo abrufen?

**8.0.7.**
Welche Informationen können Sie über Methoden und Konstruktoren auslesen?

**8.0.8.**
Können Sie mit Reflection auch private Member auslesen sowie setzen?

**8.0.9.**
Eine Klasse mit einem delegate und zwei Properties besitzt mehr als drei Methoden. Warum?


Custom Type Information
-----------------------
**8.1.1.**
Was sind Custom Attributes? Wie können Sie sie definieren? Was bringen sie für einen Vorteil?

**8.1.2.**
Wie können Sie mit Custom Attributes Klassen um Informationen für Exportconverter erweitern ohne in der Klasse selbst Code einfügen zu müssen?





