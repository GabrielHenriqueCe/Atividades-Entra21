using System.ComponentModel;
using System.Reflection;


namespace Utilities
{
    static class Helper
    {
        public static string GetDescricao(Enum valor)
        {
            FieldInfo field = valor.GetType().GetField(valor.ToString());

            DescriptionAttribute attr =
                field.GetCustomAttribute<DescriptionAttribute>();

            return attr?.Description ?? valor.ToString();
        }

    }
}
