namespace EventExample
{
    internal class ClassEventTriggeredHandling
    {
        // Méthode qui sera appelée en réponse à l'événement
        public void MethodeDeReponse(object sender, string message)
        {
            Console.WriteLine($"Événement déclenché avec le message : {message}");
            // Autres actions à effectuer en réponse à l'événement...
        }
    }
}
