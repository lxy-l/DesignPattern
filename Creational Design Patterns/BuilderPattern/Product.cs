namespace BuilderPattern
{
    /// <summary>
    /// 产品
    /// </summary>
    public class Product
    {
        private List<object> list = new List<object>();

        public void Add(string part)
        {
            list.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                str += list[i] + ",";
            }
            str = str.Remove(str.Length - 2);
            return $"Product parts:{str}\n";
        }
    }
}
