namespace LogicaValidador
{
    public class Validador
    {
        private bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != 0 || item != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int potencias;
                double acumuladorOperacion;
                potencias = binario.Length;
                acumuladorOperacion = 0;
                foreach (double item in binario)
                {
                    acumuladorOperacion += Math.Pow(item, potencias);
                    potencias--;
                }
                return acumuladorOperacion.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }
    }
}