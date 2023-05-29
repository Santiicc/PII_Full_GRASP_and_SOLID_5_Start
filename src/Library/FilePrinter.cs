using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Irecipe irecipe)
        {
            File.WriteAllText("Recipe.txt", irecipe.GetTextToPrint());
        }
    }
}