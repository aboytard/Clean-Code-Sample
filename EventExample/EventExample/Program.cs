// See https://aka.ms/new-console-template for more information
using EventExample;

Console.WriteLine("Hello, World!");


ClassEventTriggering instanceA = new ClassEventTriggering();
ClassEventTriggeredHandling instanceB = new ClassEventTriggeredHandling();

// Abonnez la méthode de réponse de ClassB à l'événement de ClassA
instanceA.MonEvenement += instanceB.MethodeDeReponse;

// Déclenchez l'événement en utilisant l'instance de ClassA
instanceA.DeclencherEvenement("COCO");

// Désabonnez la méthode de réponse si nécessaire
instanceA.MonEvenement -= instanceB.MethodeDeReponse;

Console.ReadKey();