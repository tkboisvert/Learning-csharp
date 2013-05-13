namespace TKBoisvert.Calculus.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string chooseWhatToDo = UI.GetSelection();

                if (chooseWhatToDo == "1")
                {
                    QuadraticFormula.Run();
                }

                if (chooseWhatToDo == "2")
                {
                    Factoring.Run();
                }

                if (chooseWhatToDo == "3")
                {
                    AdditionS_S.Run();
                }

                if (chooseWhatToDo == "4")
                {
                    GeometricS_S.Run();
                }
            }
        }
    }
}