===========================
HS13 MsTe Repetitionsfragen
===========================



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
Was passiert, wenn sie eine Methode mit override überschreiben, ohne das diese in der Basisklase ``virtual'' ist?

**1.0.20.**
Was ist die Sichtbarkeit "ìnternal"?

**1.0.21.**
In welcher Reihenfolge werden Objekte initialisiert, wenn sie Baisklassen mit Kindklassen sowie statische Felder in der Klasse haben?

**1.0.22.**
Warum benötigen abstrakte Methoden kein "virtual"?

**1.0.23**
Was sind ``sealed'' Klassen?

**1.0.24.**
Sie implementieren mehrere Interfaces. In den Interfaces gibt es gleich benannte Methoden. Wie spezifizieren Sie, welche Methode sie konkret implementieren?

**1.0.25.**
Wie geben sie optionale Parameter an? Was sind "named parameters"?

**1.0.26.**
Was sind "partial methods"? Wozu werden sie gebraucht? Sollten Sie sie einsetzen?

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







.NET
====