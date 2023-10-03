using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            return new Calculadora();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 2, 7)]
        public void RecebeDoisNumwerosInteirs_RealizaASoma_ERetornaOResultadoCorreto(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(6, 4, 24)]
        public void RecebeDoisNumwerosInteirs_RealizaAMultiplicacao_ERetornaOResultadoCorreto(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(9, 5, 4)]
        public void RecebeDoisNumwerosInteirs_RealizaASubtracao_ERetornaOResultadoCorreto(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(22, 2, 11)]
        [InlineData(30, 5, 6)]
        public void RecebeDoisNumwerosInteirs_RealizaADivisao_ERetornaOResultadoCorreto(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            var resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
                );
        }

        [Fact]
        public void VerificaSeHaAsTresUltimasOperacoes()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(3, 2);
            calc.Somar(4, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        public void RecebeDoisNumerosInteiros_ElevaOPrimeiroPeloSegundo_ERetornaOResultadoCorreto(int val1, int val2)
        {
            var calc = new Calculadora();

            var resultado = calc.Pontencia(val1, val2);

            Assert.Equal(Math.Pow(val1, val2), resultado);
        }

        [Theory]
        [InlineData(25)]
        [InlineData(144)]
        [InlineData(10000)]
        public void RecebeUmNumeroInteiro_CalculaARaizQuadrada_ERetornaOResultadoCorreto(int value)
        {
            var calc = new Calculadora();

            var resultado = calc.Raiz(value);

            Assert.Equal(Math.Sqrt(value), resultado);
        }

        [Theory]
        [InlineData(25, 100)]
        [InlineData(144, 200)]
        [InlineData(325, 300)]
        public void RecebeDoisNumerosInteiros_CalculaAPorcentagemDoPrimeiroEmRelacaAoSegundo_ERetornaOResultadoCorreto(int val1, int val2)
        {
            var calc = new Calculadora();

            var resultado = calc.Porcentagem(val1, val2);

            Assert.Equal((((double) val1/ val2) * 100), resultado);
        }
    }
}