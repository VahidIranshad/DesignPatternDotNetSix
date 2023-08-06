using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype.SecondImplementation
{
    public static class Extention
    {
        public static T DeepClone<T>(this T obj) where T : IBaseEntity
        {
            //Your class MUST be marked as [Serializable] for this to work.
            //Your source file must include the following code:
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
