namespace SimpleCalculator
{
    internal class Operations
    {
        private decimal a, b, c;

        public decimal A { get { return a; } set { this.a = value; }}
        public decimal B { get { return b; } set { this.b = value; } }

        public decimal C { get { return c; } }
        
        public void calculate(string? mode)
        {
            if (mode == "add")
                this.c = this.a + this.b;
            else if (mode == "sub")
                this.c = this.a - this.b;
            else if (mode == "mul")
                this.c = this.a * this.b;
            else if (mode == "div")
            {
                try
                {
                    this.c = this.a / this.b;
                }
                catch(DivideByZeroException)
                {
                    return;
                }
            }
            else
                this.c = 0;
        }

        public void reset()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
    }
}
