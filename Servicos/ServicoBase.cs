﻿using GisaApiArq.Dominio;
using GisaApiArq.Infra;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaApiArq.Servicos
{
    public class ServicoBase<T> : IServicoBase<T> where T : EntidadeBase
    {
        protected readonly ILogger<ServicoBase<T>> _logger;
        protected readonly IRepositorioBase<T> _repositorio;

        public ServicoBase(ILogger<ServicoBase<T>> logger, IRepositorioBase<T> repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }
    }
}
