[Serializable]
  public class  TestClass
    {
         public int TestProperty { get; set; } 
         public string TestField { get; set; }

    //public TestClass() { }
    public TestClass(int testProperty, string testField)
        {
           TestProperty = testProperty;
            TestField = testField;
        }
    }
