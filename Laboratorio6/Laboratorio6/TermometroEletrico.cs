﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio6
{
    public class TermometroEletrico : Termometro, IEstadoBinario
    {
        private bool ligado = false;
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public EstadoBinario Estado
        {
            get
            {
                if (ligado) return EstadoBinario.Ligado;
                else return EstadoBinario.Desligado;
            }
        }
    }
}
