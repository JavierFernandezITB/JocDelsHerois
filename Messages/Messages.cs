namespace Messages
{
    public class MessagesList
    {
        public const string MainMenuWelcomeMessage = "Bienvenido al juego Heroes Contra Monstruos!\nEspecifica una opción para continuar.";
        public const string MainMenuOptionsMessage = "1. Empezar una nueva batalla\n0. Salir del juego";
        public const string MainMenuErrorNotInRange = "Vaya, te has equivocado. Vuelve a intentarlo!";
        public const string ErrorNoTriesLeft = "Te has quedado sin intentos.";

        public const string DifficultySelectionMessage = "Selecciona una dificultad.";
        public const string DifficultySelectionOptions = "1. Fácil\n2. Difícil\n3. Personalizado\n4. Random";

        public const string DifficultyCustomChangeStat = "Bien, vamos a cambiar la {0} de {1}. [{2} - {3}]";

        public const string ChangedHeroStatMessage = "Se han actualizado valores. [OLD] {0} -> [NEW] {1}";
    }
}