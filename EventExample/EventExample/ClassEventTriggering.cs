namespace EventExample
{
    internal class ClassEventTriggering
    {
        // Définition de l'événement avec un délégué approprié
        public event EventHandler<string> MonEvenement;

        // Méthode pour déclencher l'événement
        public void DeclencherEvenement(string message)
        {
            // Vérifiez si au moins un abonné à l'événement existe
            if (MonEvenement != null)
            {
                // Déclenchez l'événement avec le message en argument
                MonEvenement(this, message);
            }
        }
    }
}
