namespace RepasoConceptos
{
    internal class Navegacion
    {
        public void Repaso()
        {
            RepasoVariableLocal();

            RepasoVariableGlobal();

            RepasoVariableLocalVsGlobal();

            var variablePorValor = 10;
            RepasoParametroPorValor(variablePorValor);

            var variablePorReferencia = 20;
            RepasoParametroPorReferencia(ref variablePorReferencia);
        }

        public void RepasoVariableLocal()
        {
            //Este método debe hacer un console write de una variable local
        }

        public void RepasoVariableGlobal()
        {
            //Este método debe hacer un console write de una variable global (dentro de la clase)
        }

        public void RepasoVariableLocalVsGlobal()
        {
            //Este método debe hacer un console write de una variable local, teniendo una variable global llamada igual
        }

        public void RepasoParametroPorValor(int parametroPorValor)
        {
            //Este método debe hacer un console write de parametro pasado por valor y modificado previamente
        }

        public void RepasoParametroPorReferencia(ref int parametroPorReferencia)
        {
            //Este método debe hacer un console write de parametro pasado por referencia y modificado previamente
        }
    }
}
