using Common.Data;

namespace VK.Data
{
    public class TypeDataVK : TypeData
    {
        public TypeDataVK() { }

        public override void Init(string str)
        {
            switch (str.ToLower())
            {
                case "json":
                    Title = "VK";
                    break;
                default:
                    Title = "Неверный тип данных";
                    Code = 0;
                    break;
            }
        }
    }
}