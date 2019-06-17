namespace PrivateAccessModifier
{
    class Parent
    {
        // Member is declared as private 
        private int value;

        // value is Accessible  
        // only inside the class 
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }
}
