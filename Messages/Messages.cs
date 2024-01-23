namespace Messages
{
    public class MessagesList
    {
        public const string MainMenuWelcomeMessage = "Bienvenido al juego Heroes Contra Monstruos!\nEspecifica una opción para continuar.";
        public const string MainMenuOptionsMessage = "\t1. Empezar una nueva batalla\n\t0. Salir del juego";
        public const string MainMenuErrorNotInRange = "Vaya, te has equivocado. Vuelve a intentarlo!";
        public const string ErrorNoTriesLeft = "Te has quedado sin intentos.";

        public const string DifficultySelectionMessage = "Selecciona una dificultad.";
        public const string DifficultySelectionOptions = "\t1. Fácil\n\t2. Difícil\n\t3. Personalizado\n\t4. Random";

        public const string DifficultyCustomChangeStat = "Bien, vamos a cambiar la {0} de {1}. [{2} - {3}]";

        public const string NameSelectionPrompt = "Introduce los nombres para los personajes separados por comas.";

        public const string FightChoiceMessage = "Que deseas hacer?";
        public const string FightChoiceOpciones = "\t1. Atacar\n\t2. Protegerte\n\t3. Ataque especial";
        public const string FightAttackMessage = "Has atacado al monstruo y has hecho {0} de daño.";
        public const string FightCritMessage = "Ataque crítico! Has realizado el doble de daño.";
        public const string FightMissedMessage = "Has fallado tu ataque.";
        public const string FightMonsterTurnMessageMessage = "Turno del Monstruo.";
        public const string FightProtectedMessage = "Te cubres del siguiente ataque del monstruo.";
        public const string FightMonsterAttacksMessage = "El monstruo ataca a {0} y hace {1} de daño.";
        public const string FightMonsterMissedMessage = "El monstruo ataca a {0} y falla.";
        public const string FightMonsterDefMissedMessage = "El monstruo intenta atacar a {0} pero se ha defendido.";

        public const string ArcherSkillMessage = "El arquero ha debilitado al monstruo y no le permitirá atacar por 2 rondas.";
        public const string BarbarianSkillMessage = "El barbaro ha aumentado su resistencia al daño en un 100% durante 2 rondas.";
        public const string MageSkillMessage = "El mago lanza una bola de fuego y hace {0} de daño.";
        public const string DruidSkillMessage = "El druida cura a todos los aliados 500 de vida.";

        public const string MonsterKnockedMessage = "El monstruo está debilitado y no puede atacar.";

        public const string ChangedHeroStatMessage = "Se han actualizado valores. [OLD] {0} -> [NEW] {1}";
        public const string PressAnyKey = "Presiona cualquier tecla para continuar.";
        public const string EndingHeroDead = "Vaya todos tus heroes han muerto, has perdido!";
        public const string EndingMonsterDead = "Felicidades! Has asesinado al monstruo.";
    }
}