namespace PrototypePattern
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string? Name;
        public IdInfo IdInfo = null!;

        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            //String.Copy(Name); https://github.com/dotnet/runtime/issues/27515
            clone.Name = new string(Name);
            return clone;
        }
    }
}
