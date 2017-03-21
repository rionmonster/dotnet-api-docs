    public sealed class Add : CodeActivity<int>
    {
        public InArgument<int> X { get; set; }
        public InArgument<int> Y { get; set; }

        protected override int Execute(CodeActivityContext context)
        {
            int x = X.Get(context);
            int y = Y.Get(context);

            return x + y;
        }
    }