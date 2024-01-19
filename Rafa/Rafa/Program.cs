using System;
using System.Collections.Generic;

using Rafa.Fundamentos;

namespace Rafa {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentário - Fundamentos", Comentários.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}