namespace mvc.Models
{
    [DbName("CLASS1")]
    public class Class1
    {
        private string _prop1;

        [DbName("PROP1")]
        public string Prop1
        {
            get
            {
                return _prop1;
            }

            set
            {
                _prop1 = value;
            }
        }
    }
}