namespace NewTalents.Test
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "24/09/2023";
            Calculadora calc = new Calculadora("24/09/2023");

            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int x, int y, int res)
        {
           Calculadora calc = ConstruirClasse();

           int resultadoCalculadora = calc.Somar(x, y);
           
           Assert.Equal(res, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Multiplicar(x, y);

            Assert.Equal(res, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Dividir(x, y);

            Assert.Equal(res, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int x, int y, int res)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Subtrair(x, y);

            Assert.Equal(res, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}